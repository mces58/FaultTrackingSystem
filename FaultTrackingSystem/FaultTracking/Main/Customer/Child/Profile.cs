using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    public partial class Profile : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // name pattern
        private readonly string namePattern = @"^[a-zA-ZçğıöşüÇĞİÖŞÜ]+$";
        // password pattern
        private readonly string passwordPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        // border-radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWitdhEllipse,
            int nHeightEllipse
        );

        // rengin uygulanmasi
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        // constructor
        public Profile()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void Profile_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 50, 50));
            errInfo.SetError(lblInfo, "Mevcut Parolanızı doğru girdiğinizde şifrenizi değiştirebilirsiniz");

            Print();
        }

        // isim dogru formatta mi
        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtFirstName.Text.Trim(), namePattern) == false && !string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                errFirstName.SetError(this.lblFirstName, "Doğru formatta yazınız");
                return;
            }
        }

        // soyisim dogru formatta mi
        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtLastName.Text.Trim(), namePattern) == false && !string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                errLastName.SetError(this.lblLastName, "Doğru formatta yazınız");
                return;
            }
        }

        // errProviver temizle
        private void TxtCurrentPassword_Leave(object sender, EventArgs e)
        {
            errCurrentPassword.Clear();
        }

        // mevcut sifre dogru girilirse yeni sifreyi girmesine izin ver
        private void TxtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            errCurrentPassword.Clear();

            if (HashString(txtCurrentPassword.Text.Trim()) != OldCustomerInfo()[5].ToString() && !string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                txtNewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                txtNewPassword.BackColor = Color.Beige;
                txtConfirmPassword.BackColor = Color.Beige;
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
                return;
            }

            if (HashString(txtCurrentPassword.Text.Trim()) == OldCustomerInfo()[5].ToString())
            {
                txtConfirmPassword.Enabled = true;
                txtNewPassword.Enabled = true;
            }
        }

        // yeni sifre dogru formatta mi
        private void TxtNewPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNewPassword.Text.Trim(), passwordPattern) == false && !string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errNewPassword.SetError(this.lblNewPassword, "Şifre en az 8 haneli olmalıdır. İçerisinde büyük harf, küçük harf, sayı, özel karakter içermelidir ve türkçe karakter bulunmamalıdır.");
                return;
            }

            else
            {
                errNewPassword.Clear();
            }
        }

        // sifreyi onayla
        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                errConfirmPassword.SetError(this.lblConfirmPassword, "Aynı Şifreyi Girdiğinizden Emin Olun!!");
                return;
            }

            else
            {
                errConfirmPassword.Clear();
            }
        }

        // arka plan rengini degistir
        private void TxtNewPassword_EnabledChanged(object sender, EventArgs e)
        {
            txtNewPassword.BackColor = Color.FromArgb(36, 45, 65);
            txtConfirmPassword.BackColor = Color.FromArgb(36, 45, 65);
        }

        // animasyon ekle
        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.TopCenter;
        }

        // animasyon kaldir
        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.MiddleCenter;
        }

        // errProviver temizle
        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {
            errNewPassword.Clear();
        }

        // errProviver temizle
        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errConfirmPassword.Clear();
        }

        // errProviver temizle
        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            errFirstName.Clear();
        }

        // errProviver temizle
        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            errLastName.Clear();
        }

        // encoding ile return yap
        private string HashString(string clearText)
        {
            byte[] clearBytes = Encoding.UTF8.GetBytes(clearText);

            return HashBytes(clearBytes);
        }

        // sifreyi hash koduna cevir
        private string HashBytes(byte[] clearBytes)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hasBytes = sha1.ComputeHash(clearBytes);
            string hash = Convert.ToBase64String(hasBytes);
            sha1.Clear();
            return hash;
        }

        // musteri id geri don
        private int CustomerId()
        {
            int customerId;

            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM Customer WHERE UserName = @UserName";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@UserName", Customer.Parent.Login.globalUserName);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            customerId = Convert.ToInt32(dataReader["Id"].ToString());

            connection.Close();

            return customerId;
        }

        // veri tabaninda kayitli verileri liste seklinde don
        private List<object> OldCustomerInfo()
        {
            int customerId = CustomerId();
            List<object> oldCustomerInfoList = new List<object>();

            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM Customer WHERE Id = @Id";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Id", customerId);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();

            if (dataReader.Read())
            {
                oldCustomerInfoList.Add(dataReader["FirstName"].ToString().Trim());
                oldCustomerInfoList.Add(dataReader["LastName"].ToString().Trim());
                oldCustomerInfoList.Add(dataReader["Gender"].ToString().Trim());
                oldCustomerInfoList.Add(dataReader["UserName"].ToString().Trim());
                oldCustomerInfoList.Add(dataReader["EmailAddress"].ToString().Trim());
                oldCustomerInfoList.Add(dataReader["PasswordHash"].ToString().Trim());
            }
            connection.Close();

            return oldCustomerInfoList;
        }

        // guncel verileri listeye ekle
        private List<object> NewCustomerInfo(string firstName, string lastName, string gender, string passwordhash)
        {
            List<object> newCustomerInfoList = new List<object>()
            {
                firstName,
                lastName,
                gender,
                passwordhash
            };

            return newCustomerInfoList;
        }

        // Customer tablosunu guncelle
        private void UpdateCustomerTable(List<object> newCustomerInfoList)
        {
            string firstName = newCustomerInfoList[0].ToString().ToUpper();
            string lastName = newCustomerInfoList[1].ToString().ToUpper();
            string gender = newCustomerInfoList[2].ToString();
            string passwordhash;

            if (string.IsNullOrEmpty(newCustomerInfoList[0].ToString()))
            {
                firstName = OldCustomerInfo()[0].ToString().ToUpper();
            }

            if (string.IsNullOrEmpty(newCustomerInfoList[1].ToString()))
            {
                lastName = OldCustomerInfo()[1].ToString().ToUpper();
            }

            if (string.IsNullOrEmpty(newCustomerInfoList[2].ToString()))
            {
                gender = OldCustomerInfo()[2].ToString();
            }

            if (string.IsNullOrEmpty(newCustomerInfoList[3].ToString()))
            {
                passwordhash = OldCustomerInfo()[5].ToString();
            }

            else
            {
                passwordhash = HashString(newCustomerInfoList[3].ToString());
            }

            string query =
                "UPDATE Customer SET " +
                "FirstName = '" + firstName + "'," +
                "LastName = '" + lastName + "'," +
                "Gender = '" + gender + "'," +
                "PasswordHash = '" + passwordhash + "'" +
                "WHERE Id = " + CustomerId() + "";

            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        // butona tiklanirsa
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtFirstName.Text.Trim(), namePattern) == false && !string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                txtFirstName.Focus();
                errFirstName.SetError(this.lblFirstName, "Doğru formatta yazınız");
                return;
            }

            if (Regex.IsMatch(txtLastName.Text.Trim(), namePattern) == false && !string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                txtLastName.Focus();
                errLastName.SetError(this.lblLastName, "Doğru formatta yazınız");
                return;
            }

            if (HashString(txtCurrentPassword.Text.Trim()) != OldCustomerInfo()[5].ToString() && !string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                string message = "Mevcut şifreniz hatalı";
                errCurrentPassword.SetError(this.lblCurrentPassword, message);
                txtNewPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                txtNewPassword.BackColor = Color.Beige;
                txtConfirmPassword.BackColor = Color.Beige;
                return;
            }

            if (HashString(txtCurrentPassword.Text.Trim()) == OldCustomerInfo()[5].ToString())
            {
                txtConfirmPassword.Enabled = true;
                txtNewPassword.Enabled = true;
                errCurrentPassword.Clear();
            }

            if (Regex.IsMatch(txtNewPassword.Text.Trim(), passwordPattern) == false && !string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                txtNewPassword.Focus();
                errNewPassword.SetError(this.lblNewPassword, "Şifre en az 8 haneli olmalıdır. İçerisinde büyük harf, küçük harf, sayı, özel karakter içermelidir ve türkçe karakter bulunmamalıdır.");
                return;
            }

            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                txtConfirmPassword.Focus();
                errConfirmPassword.SetError(this.lblConfirmPassword, "Aynı Şifreyi Girdiğinizden Emin Olun!!");
                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string gender = "";

            if (rdoMale.Checked)
            {
                gender = rdoMale.Text.Substring(0, 1);
            }

            if (rdoFemale.Checked)
            {
                gender = rdoFemale.Text.Substring(0, 1);
            }

            if (rdoOther.Checked)
            {
                gender = rdoOther.Text.Substring(0, 1);
            }

            string newPassword = txtNewPassword.Text.ToString().Trim();

            List<object> newCustomerInfoList = NewCustomerInfo(firstName, lastName, gender, newPassword);

            UpdateCustomerTable(newCustomerInfoList);
            Reset();
            new MessageBoxes.UpdateProfileSuccesMessageBox().ShowDialog();
            Print();
            txtNewPassword.Enabled = false;
            txtNewPassword.BackColor = Color.Beige;
            txtConfirmPassword.Enabled = false;
            txtConfirmPassword.BackColor = Color.Beige;
        }

        // temizle
        private void Reset()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        // mevcut bilgileri yazdir
        private void Print()
        {
            txtUserName.Text = OldCustomerInfo()[3].ToString();
            txtEmail.Text = OldCustomerInfo()[4].ToString();
            txtFirstName.Text = OldCustomerInfo()[0].ToString();
            txtLastName.Text = OldCustomerInfo()[1].ToString();

            if (OldCustomerInfo()[2].ToString() == "E")
            {
                rdoMale.Checked = true;
            }
            if (OldCustomerInfo()[2].ToString() == "K")
            {
                rdoFemale.Checked = true;
            }
            if (OldCustomerInfo()[2].ToString() == "D")
            {
                rdoOther.Checked = true;
            }
        }

        // enter tusunu disable et
        private void DisableEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
