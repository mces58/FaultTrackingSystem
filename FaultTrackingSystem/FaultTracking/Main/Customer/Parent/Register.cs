using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Parent
{
    public partial class Register : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // username pattern
        private readonly string userNamePattern = @"^(?=.{3,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$";
        // password pattern
        private readonly string passwordPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        // email pattern
        private readonly string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public Register()
        {
            InitializeComponent();
        }

        // border-radius -- kenarliklari yumusat
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

        // background shadow -- forma arkaplan golgesi
        private const int CS_DropShadow = 0x24488;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        // formun hareketi
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // formun hareketi
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // formun hareketi
        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // safya yuklenirken
        private void Register_Load(object sender, EventArgs e)
        {
            // border-radius
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnRegister.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegister.Width, btnRegister.Height, 50, 50));
            btnMcesRecoLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMcesRecoLogo.Width, btnMcesRecoLogo.Height, 20, 20));
            txtUserName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUserName.Width, txtUserName.Height, 20, 20));
            txtEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtEmail.Width, txtEmail.Height, 20, 20));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 20, 20));
            txtConfirmPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtConfirmPassword.Width, txtConfirmPassword.Height, 20, 20));
            btnHidePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnHidePassword.Width, btnHidePassword.Height, 20, 20));
            btnShowPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnShowPassword.Width, btnShowPassword.Height, 20, 20));
            btnConfirmHidePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmHidePassword.Width, btnConfirmHidePassword.Height, 20, 20));
            btnConfirmShowPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmShowPassword.Width, btnConfirmShowPassword.Height, 20, 20));

            tmrLoad.Start();
        }

        // logoya tiklanirsa linke git
        private void BtnMcesRecoLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mces58");
        }

        // formu minimize yap
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // uygulamayi kapat
        private void BtnClose_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        // sifreyi goster
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        // sifreyi gizle
        private void BtnHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                btnShowPassword.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        // sifreyi goster
        private void BtnConfirmShowPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                btnConfirmHidePassword.BringToFront();
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        // sifreyi gizle
        private void BtnConfirmHidePassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '•')
            {
                btnConfirmShowPassword.BringToFront();
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        // login sayfayina git
        private void LnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        // errorProvider temizle
        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            errUserName.Clear();
        }

        // errorProvider temizle
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        // errorProvider temizle
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // errorProvider temizle
        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            errConfirmPassword.Clear();
        }

        // errorProvider temizle
        private void ChkTerms_Leave(object sender, EventArgs e)
        {
            errTerms.Clear();
        }

        // errorProvider temizle
        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            errUserName.Clear();
        }

        // errorProvider temizle
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        // errorProvider temizle
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // errorProvider temizle
        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errConfirmPassword.Clear();
        }

        // checkBox kontrol et
        private void ChkTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTerms.Checked == false)
            {
                errTerms.SetError(lnklblTerms, "Sözleşmeyi kabul ediniz");
                return;
            }
            else
            {
                errTerms.Clear();
            }
        }

        // linke tiklanirsa sozlesmeyi goster
        private void LnklblTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MessageBoxes.TermsMessageBox().ShowDialog();
        }

        // link animasyon
        private void LnklblLogin_MouseEnter(object sender, EventArgs e)
        {
            lnklblLogin.Font = new Font("Segoe UI Black", 10F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblLogin.Location = new Point(277, 700);
            lnklblLogin.LinkColor = Color.FromArgb(248, 8, 68);
            lnklblLogin.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // link animasyon
        private void LnklblLogin_MouseLeave(object sender, EventArgs e)
        {
            lnklblLogin.Font = new Font("Segoe UI Black", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblLogin.Location = new Point(280, 705);
            lnklblLogin.LinkColor = Color.FromArgb(235, 215, 95);
            lnklblLogin.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        // btnRegister animasyon
        private void BtnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(89, 150, 25);
            btnRegister.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnRegister.TextAlign = ContentAlignment.TopCenter;
        }

        // btnRegister animasyon
        private void BtnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(243, 116, 60);
            btnRegister.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnRegister.TextAlign = ContentAlignment.MiddleCenter;
        }

        // sozlesme animasyon
        private void LnklblTerms_MouseEnter(object sender, EventArgs e)
        {
            lnklblTerms.Font = new Font("Segoe UI Black", 9F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblTerms.LinkColor = Color.FromArgb(248, 8, 68);
            lnklblTerms.Location = new Point(100, 608);
            lnklblTerms.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // sozlesme animasyon kaldir
        private void LnklblTerms_MouseLeave(object sender, EventArgs e)
        {
            lnklblTerms.Font = new Font("Segoe UI Black", 8.25F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblTerms.LinkColor = Color.Silver;
            lnklblTerms.Location = new Point(105, 610);
            lnklblTerms.LinkBehavior = LinkBehavior.AlwaysUnderline;
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

        // userName daha onceden kayitli miydi
        private int IsExistUserName(string userName)
        {
            int valid = 1;
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM Customer WHERE UserName = @UserName";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@UserName", userName);
                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    txtUserName.Focus();
                    errUserName.SetError(lblUserName, "Kullanıcı adi zaten kayıtlı. Başka bir isim seçiniz");
                    valid = 0;
                    return valid;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return valid;
        }

        // email daha onceden kayitli miydi
        private int IsExistEmailAddress(string email)
        {
            int valid = 1;
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM Customer WHERE EmailAddress = @EmailAddress";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", email);
                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    txtEmail.Focus();
                    errEmail.SetError(lblEmail, email + " kayıtlı. Başka bir e-mail deneyeniz");
                    valid = 0;
                    return valid;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return valid;
        }

        // kisiyi ekle
        private void RegisterCustomer(string userName, string email, string password)
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "INSERT INTO Customer(FirstName, LastName, Gender, UserName, EmailAddress, PasswordHash) " +
                    "VALUES('', '', '', @UserName, @EmailAddress, @PasswordHash)";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@UserName", userName);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", email);
                sqlCommand.Parameters.AddWithValue("@PasswordHash", password);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // btnRegister tiklanirsa
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string password = HashString(txtPassword.Text);

            // userName bos mu
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                errUserName.SetError(this.lblUserName, "Boş bırakılamaz");
                return;
            }

            // userName dogru formatta mi
            if (Regex.IsMatch(txtUserName.Text, userNamePattern) == false)
            {
                txtUserName.Focus();
                errUserName.SetError(this.lblUserName, "En az 3 karakter olmalı ve içerisinde türkçe karakter bulunmamalıdır");
                return;
            }

            // mail bos mu
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errEmail.SetError(this.lblEmail, "Boş bırakılamaz");
                return;
            }

            // mail dogru formatta mi
            else if (Regex.IsMatch(txtEmail.Text, emailPattern) == false)
            {
                string message = "Emailin doğru formatta olduğundan emin olunuz.";
                errEmail.SetError(this.lblEmail, message);
                return;
            }

            // password bos mu
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errPassword.SetError(this.lblPassword, "Boş bırakılamaz");
                return;
            }

            // password dogru formatta mi
            else if (Regex.IsMatch(txtPassword.Text, passwordPattern) == false)
            {
                txtPassword.Focus();
                string message = "Sifre en az 8 haneli olmalıdır. İçerisinde büyük harf, küçük harf, sayı, özel karakter içermelidir ve türkçe karakter bulunmamalıdır";
                errPassword.SetError(this.lblPassword, message);
                return;
            }

            // passwordConfirm bos mu
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                errConfirmPassword.SetError(this.lblConfirmPassword, "Boş bırakılamaz");
                return;
            }

            // sifreler ayni mi
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                txtConfirmPassword.Focus();
                errConfirmPassword.SetError(this.lblConfirmPassword, "Aynı Şifreyi Girdiğinizden Emin Olun!!");
                return;
            }

            // checkBox secili mi
            else if (chkTerms.Checked == false)
            {
                errTerms.SetError(this.lnklblTerms, "Sözleşmeyi kabul ediniz");
                return;
            }

            // userName var mi
            if (IsExistUserName(userName) == 0)
            {
                return;
            }

            // email var mi
            if (IsExistEmailAddress(email) == 0)
            {
                return;
            }

            // ekle
            RegisterCustomer(userName, email, password);
            new MessageBoxes.SuccessCustomerRegisterMessageBox().ShowDialog();
            btnRegister.Enabled = false;
            Reset();
        }

        // temizle
        private void Reset()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkTerms.Checked = false;
            errTerms.Clear();
        }

        // musteri kayit sayfasinin yuklenmesi
        private void TmrLoad_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmrLoad.Stop();
            }

            Opacity += 0.1;
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
