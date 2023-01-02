using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Manager.Child
{
    public partial class Technician : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // email pattern
        private readonly string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        // name pattern
        private readonly string namePattern = @"^[a-zA-ZÇŞĞÜÖİçşğüöı]+([ ][a-zA-ZÇŞĞÜÖİçşğüöı]+)*$";

        private int technicianId;

        private readonly DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

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
        public Technician()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void Technician_Load(object sender, EventArgs e)
        {
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 50, 50));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 50, 50));
            LoadTheme();
            dataGrid.ClearSelection();

            btnSearch.Enabled = false;

            TechnicianList();

            AddItemDevice();
        }

        private void TechnicianList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "T.Id AS 'Id'," +
                "T.Code AS 'Kod'," +
                "T.EmailAddress AS 'Email'," +
                "T.NationalNumber AS 'Kimlik'," +
                "T.FirstName AS 'Ad'," +
                "T.LastName AS 'Soyad'," +
                "T.Gender AS 'Cinsiyet'," +
                "T.Salary AS 'Maaş'," +
                "D.Name AS 'Cihaz'" +
                "FROM Technician AS T " +
                "LEFT JOIN Device AS D ON D.Id = T.DeviceId " +
                "ORDER BY T.NationalNumber";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
            };

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGrid.DataSource = dataTable;
            dataGrid.Columns["Id"].Visible = false;

            CreateButtomColumn();

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // data gridde hucreye tiklanirsa
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || dataGrid.SelectedCells.Count == dataGrid.Rows.Count * dataGrid.Columns.Count)
            {
                btnUpdate.Enabled = true;
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                mtxtNationalNumber.Text = row.Cells["Kimlik"].Value.ToString();
                txtFirstName.Text = row.Cells["Ad"].Value.ToString();
                txtLastName.Text = row.Cells["Soyad"].Value.ToString();
                cboDevice.Text = row.Cells["Cihaz"].Value.ToString();
                string gender = row.Cells["Cinsiyet"].Value.ToString();

                if (gender == "E")
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }

                numSalary.Value = Convert.ToInt32(row.Cells["Maaş"].Value);

                technicianId = (int)row.Cells["Id"].Value;
            }

            if (e.ColumnIndex == dataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = (int)dataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                using (SqlConnection connection = new SqlConnection(connectionUrl))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Technician WHERE Id = @Id", connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                dataGrid.Columns.Remove(buttonColumn);
                TechnicianList();
            }
        }

        // cihaz id degerini yakala
        private int DeviceId()
        {
            int deviceId;

            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM Device WHERE Name = @Name";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Name", cboDevice.Text);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            deviceId = Convert.ToInt32(dataReader["Id"].ToString());

            connection.Close();

            return deviceId;
        }

        // email daha onceden kayitli miydi
        private int IsExistEmailAddress(string email)
        {
            int valid = 1;
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM Technician WHERE EmailAddress = @EmailAddress";
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

        // kimlik numarasi daha once kayitli miydi
        private int IsExistNationalNumber(string nationalNumber)
        {
            int valid = 1;
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT T.NationalNumber FROM Technician AS T WHERE T.NationalNumber = @NationalNumber UNION ALL SELECT S.NationalNumber FROM Staff AS S WHERE S.NationalNumber = @NationalNumber";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    mtxtNationalNumber.Focus();
                    errNationalNumber.SetError(lblNationalNumber, nationalNumber + " kayıtlı. Başka bir kimlik numarası deneyeniz");
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

        // tabloya ekle
        private void AddList()
        {
            string passwordHash = HashString("FaultTracking1.");
            string code = Guid.NewGuid().ToString().Substring(0, 13);
            int deviceId = DeviceId();
            connection = new SqlConnection(connectionUrl);
            connection.Open();
            string query = "INSERT INTO Technician(Code, EmailAddress, PasswordHash, NationalNumber, FirstName, LastName, Gender, UserType, Salary, DeviceId) VALUES(@Code, @EmailAddress, @PasswordHash, @NationalNumber, @FirstName, @LastName, @Gender, 'T', @Salary, @DeviceId)";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Code", code);
            sqlCommand.Parameters.AddWithValue("@EmailAddress", txtEmail.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@PasswordHash", passwordHash);
            sqlCommand.Parameters.AddWithValue("@NationalNumber", mtxtNationalNumber.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim().ToUpper());
            sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim().ToUpper());
            sqlCommand.Parameters.AddWithValue("@Salary", numSalary.Value);
            sqlCommand.Parameters.AddWithValue("@DeviceId", deviceId);

            if (rdoMale.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", "E");
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Gender", "K");
            }

            sqlCommand.ExecuteNonQuery();
            connection.Close();
            dataGrid.ClearSelection();
        }

        // listeye ekle
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string nationalNumber = mtxtNationalNumber.Text;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errEmail.SetError(lblEmail, "Boş bırakılamaz");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                string message = "Emailin doğru formatta olduğundan emin olunuz.";
                errEmail.SetError(lblEmail, message);
                return;
            }

            if (IsExistEmailAddress(email) == 0)
            {
                return;
            }

            if (!mtxtNationalNumber.MaskFull)
            {
                mtxtNationalNumber.Focus();
                errNationalNumber.SetError(lblNationalNumber, "Boş bırakılamaz");
                return;
            }

            if (IsExistNationalNumber(nationalNumber) == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Focus();
                errFirstName.SetError(lblFirstName, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtFirstName.Text.Trim(), namePattern) == false)
            {
                txtFirstName.Focus();
                errFirstName.SetError(lblFirstName, "Doğru formatta yazınız");
                return;
            }


            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Focus();
                errLastName.SetError(lblLastName, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtLastName.Text.Trim(), namePattern) == false)
            {
                txtLastName.Focus();
                errLastName.SetError(lblLastName, "Doğru formatta yazınız");
                return;
            }

            if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                errGender.SetError(lblGender, "Seçim yapın");
                return;
            }

            AddList();
            dataGrid.Columns.Remove(buttonColumn);
            TechnicianList();
        }

        // tabloyu guncelle
        private void UpdateList()
        {
            int deviceId = DeviceId();

            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = connection;

                    sqlCommand.CommandText = "UPDATE Technician SET EmailAddress = @EmailAddress, FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Salary = @Salary, DeviceId = @DeviceId WHERE Id = @TechnicianId";
                    sqlCommand.Parameters.AddWithValue("@EmailAddress", txtEmail.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@NationalNumber", mtxtNationalNumber.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim().ToUpper());
                    sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim().ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Salary", numSalary.Value);
                    sqlCommand.Parameters.AddWithValue("@DeviceId", deviceId);

                    if (rdoMale.Checked)
                    {
                        sqlCommand.Parameters.AddWithValue("@Gender", "E");
                    }

                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@Gender", "K");

                    }

                    sqlCommand.Parameters.AddWithValue("@TechnicianId", technicianId);
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
                dataGrid.ClearSelection();
            }
        }

        // listeyi guncelle
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string nationalNumber = mtxtNationalNumber.Text;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errEmail.SetError(lblEmail, "Boş bırakılamaz");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                string message = "Emailin doğru formatta olduğundan emin olunuz.";
                errEmail.SetError(lblEmail, message);
                return;
            }

            if (!mtxtNationalNumber.MaskFull)
            {
                mtxtNationalNumber.Focus();
                errNationalNumber.SetError(lblNationalNumber, "Boş bırakılamaz");
                return;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.Focus();
                errFirstName.SetError(lblFirstName, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtFirstName.Text.Trim(), namePattern) == false)
            {
                txtFirstName.Focus();
                errFirstName.SetError(lblFirstName, "Doğru formatta yazınız");
                return;
            }


            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                txtLastName.Focus();
                errLastName.SetError(lblLastName, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtLastName.Text.Trim(), namePattern) == false)
            {
                txtLastName.Focus();
                errLastName.SetError(lblLastName, "Doğru formatta yazınız");
                return;
            }

            UpdateList();
            dataGrid.Columns.Remove(buttonColumn);
            TechnicianList();
        }

        // errorProvider temizle
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        // errorProvider temizle
        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            errFirstName.Clear();
        }

        // errorProvider temizle
        private void MtxtNationalNumber_KeyUp(object sender, KeyEventArgs e)
        {
            errNationalNumber.Clear();
        }

        // errorProvider temizle
        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            errLastName.Clear();
        }

        // errorProvider temizle
        private void RdoMale_CheckedChanged(object sender, EventArgs e)
        {
            errGender.Clear();
        }

        // errorProvider temizle
        private void RdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            errGender.Clear();
        }

        // errorProvider temizle
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        // errorProvider temizle
        private void MtxtNationalNumber_Leave(object sender, EventArgs e)
        {
            errNationalNumber.Clear();
        }

        // errorProvider temizle
        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            errFirstName.Clear();
        }

        // errorProvider temizle
        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            errLastName.Clear();
        }

        // btnAdd animasyon
        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Font = new Font("Segoe UI Black", 14.5F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnAdd.TextAlign = ContentAlignment.TopCenter;
        }

        // btnAdd animasyon
        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnUpdate animasyon
        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 14.5F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.TopCenter;
        }

        // btnUpdate animasyon
        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.MiddleCenter;
        }

        // buton kolonu olustur
        private void CreateButtomColumn()
        {
            buttonColumn.HeaderText = "Teknisyen Sil";
            buttonColumn.Name = "Delete";
            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            buttonColumn.Text = "Sil";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(buttonColumn);
        }

        // cihazlari veri tabanindan cekip combobox yazma
        private void AddItemDevice()
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "  SELECT DISTINCT Name from Device ORDER BY Name";
                sqlCommand = new SqlCommand(query, connection);
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                cboDevice.ValueMember = "Id";
                cboDevice.DataSource = dataTable;
                cboDevice.DisplayMember = "Name";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // arama yap
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "T.Id AS 'Id'," +
                "T.Code AS 'Kod'," +
                "T.EmailAddress AS 'Email'," +
                "T.NationalNumber AS 'Kimlik'," +
                "T.FirstName AS 'Ad'," +
                "T.LastName AS 'Soyad'," +
                "T.Gender AS 'Cinsiyet'," +
                "T.Salary AS 'Maaş'," +
                "D.Name AS 'Cihaz'" +
                "FROM Technician AS T " +
                "INNER JOIN Device AS D ON D.Id = T.DeviceId " +
                "WHERE " +
                "(T.EmailAddress LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.NationalNumber LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.Code LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.FirstName LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.LastName LIKE '" + txtSearch.Text.ToString() + "' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "') " +
                "ORDER BY NationalNumber";

            connection.Open();
            sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
            dataGrid.ClearSelection();

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // buton disable hale geldikten sonra yazi rengini degistir
        private void BtnSearch_Paint(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            using (var drawbrush = new SolidBrush(btn.ForeColor))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                btnSearch.Text = string.Empty;
                e.Graphics.DrawString("Ara", btn.Font, drawbrush, e.ClipRectangle, sf);
            }
        }

        // yazi rengini degistir
        private void BtnSearch_EnabledChanged(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.Beige;
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
