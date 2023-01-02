using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee
{
    public partial class ForgetPassword : Form
    {
        // password pattern
        private readonly string passwordPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        // email pattern
        private readonly string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

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

        // constructor
        public ForgetPassword()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            // border-radius
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnSend.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSend.Width, btnSend.Height, 50, 50));
            btnBackToLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBackToLogin.Width, btnBackToLogin.Height, 50, 50));
            btnMcesRecoLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMcesRecoLogo.Width, btnMcesRecoLogo.Height, 20, 20));
            txtEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtEmail.Width, txtEmail.Height, 20, 20));
            btnEmailVerification.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEmailVerification.Width, btnEmailVerification.Height, 50, 50));
            mtxtSecurityCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mtxtSecurityCode.Width, mtxtSecurityCode.Height, 20, 20));
            btnNewPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNewPassword.Width, btnNewPassword.Height, 50, 50));
            txtNewPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNewPassword.Width, txtNewPassword.Height, 20, 20));
            txtConfirmPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtConfirmPassword.Width, txtConfirmPassword.Height, 20, 20));
            btnHidePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnHidePassword.Width, btnHidePassword.Height, 20, 20));
            btnShowPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnShowPassword.Width, btnShowPassword.Height, 20, 20));
            btnConfirmHidePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmHidePassword.Width, btnConfirmHidePassword.Height, 20, 20));
            btnConfirmShowPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmShowPassword.Width, btnConfirmShowPassword.Height, 20, 20));

            // gorunurluklerini false yap
            lblNewPassword.Visible = false;
            txtNewPassword.Visible = false;
            lblConfirmPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            btnNewPassword.Visible = false;
            lblSecurityCode.Visible = false;
            mtxtSecurityCode.Visible = false;
            btnEmailVerification.Visible = false;
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = false;
            btnConfirmShowPassword.Visible = false;
            btnConfirmHidePassword.Visible = false;
            pnlHorizonal2.Visible = false;

            tmrLoad.Start();
        }

        // logoya tiklanirsa linke git
        private void BtnMcesRecoLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mces58");
        }

        // sayfayi kucult
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // uygulamayi kapat
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Home.Home home = new Home.Home();
            home.Show();
            this.Hide();
        }

        // btnSend animasyon
        private void BtnSend_MouseEnter(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.FromArgb(89, 150, 25);
            btnSend.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnSend.TextAlign = ContentAlignment.TopCenter;
        }

        // btnSend animasyon
        private void BtnSend_MouseLeave(object sender, EventArgs e)
        {
            btnSend.BackColor = Color.FromArgb(243, 116, 60);
            btnSend.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnSend.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnBackToLogin animasyon
        private void BtnBackToLogin_MouseEnter(object sender, EventArgs e)
        {
            btnBackToLogin.BackColor = Color.FromArgb(248, 8, 68);
            btnBackToLogin.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnBackToLogin.TextAlign = ContentAlignment.TopCenter;
        }

        // btnBackToLogin animasyon
        private void BtnBackToLogin_MouseLeave(object sender, EventArgs e)
        {
            btnBackToLogin.BackColor = Color.FromArgb(17, 97, 238);
            btnBackToLogin.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
            btnBackToLogin.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnEmailVerification animasyon
        private void BtnEmailVerification_MouseEnter(object sender, EventArgs e)
        {
            btnEmailVerification.BackColor = Color.FromArgb(89, 150, 25);
            btnEmailVerification.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnEmailVerification.TextAlign = ContentAlignment.TopCenter;
        }

        // btnEmailVerification animasyon
        private void BtnEmailVerification_MouseLeave(object sender, EventArgs e)
        {
            btnEmailVerification.BackColor = Color.FromArgb(243, 116, 60);
            btnEmailVerification.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnEmailVerification.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnNewPassword animasyon
        private void BtnNewPassword_MouseEnter(object sender, EventArgs e)
        {
            btnNewPassword.BackColor = Color.FromArgb(89, 150, 25);
            btnNewPassword.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnNewPassword.TextAlign = ContentAlignment.TopCenter;
        }

        // btnNewPassword animasyon
        private void BtnNewPassword_MouseLeave(object sender, EventArgs e)
        {
            btnNewPassword.BackColor = Color.FromArgb(243, 116, 60);
            btnNewPassword.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnNewPassword.TextAlign = ContentAlignment.MiddleCenter;
        }

        // errorProvider temizle
        private void CheckedChanged(object sender, EventArgs e)
        {
            errEmployeeType.Clear();
        }

        // errorProvider temizle
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        // errorProvider temizle
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            errEmail.Clear();
        }

        // renk degistir
        private void TxtEmail_EnabledChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.Beige;
        }

        // errorProvider temizle
        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // errorProvider temizle
        private void TxtNewPassword_Leave(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // errorProvider temizle
        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            errConfirmPassword.Clear();
        }

        // errorProvider temizle
        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            errConfirmPassword.Clear();
        }

        // errorProvider temizle
        private void MtxtSecurityCode_TextChanged(object sender, EventArgs e)
        {
            errSecurityCode.Clear();
        }

        // errorProvider temizle
        private void MtxtSecurityCode_Leave(object sender, EventArgs e)
        {
            errSecurityCode.Clear();
        }

        // sifreyi gizle
        private void BtnHidePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '•')
            {
                btnShowPassword.BringToFront();
                txtNewPassword.PasswordChar = '\0';
            }
        }

        // sifreyi goster
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '\0')
            {
                btnHidePassword.BringToFront();
                txtNewPassword.PasswordChar = '•';
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

        // sifreyi goster
        private void BtnConfirmShowPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                btnConfirmHidePassword.BringToFront();
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        // login sayfasina geri don
        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        // manager tablosunda email kayitli mi
        private int IsExistEmailManager(string email)
        {
            int valid = 1;
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM Manager WHERE EmailAddress = @EmailAddress";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", email);
                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                // girilen email database de yok mu
                if (!dataReader.Read())
                {
                    // yoksa hata ver
                    txtEmail.Focus();
                    errEmail.SetError(lblEmail, email + " ilişkili herhangi bir hesap bulunamadı. Lütfen alternatif bir e-posta ile deneyin");
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

        // staff tablosunda email kayitli mi
        private int IsExistEmailStaff(string email)
        {
            int valid = 1;
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM Staff WHERE EmailAddress = @EmailAddress";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", email);
                connection.Open();
                dataReader = sqlCommand.ExecuteReader();

                // girilen email database de yok mu
                if (!dataReader.Read())
                {
                    // yoksa hata ver
                    txtEmail.Focus();
                    errEmail.SetError(lblEmail, email + " ilişkili herhangi bir hesap bulunamadı. Lütfen alternatif bir e-posta ile deneyin");
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

        // manager tablosunda email kayitli mi
        private int IsExistEmailTechnician(string email)
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

                // girilen email database de yok mu
                if (!dataReader.Read())
                {
                    // yoksa hata ver
                    txtEmail.Focus();
                    errEmail.SetError(lblEmail, email + " ilişkili herhangi bir hesap bulunamadı. Lütfen alternatif bir e-posta ile deneyin");
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

        // email gonder butonuna basilirsa
        private void BtnSend_Click(object sender, EventArgs e)
        {
            // txtEmail bos mu
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errEmail.SetError(this.lblEmail, "Boş bırakılamaz");
                return;
            }
            // email dogru formatta mi
            else if (Regex.IsMatch(txtEmail.Text, emailPattern) == false)
            {
                string message = "Emailin doğru formatta olduğundan emin olunuz.";
                errEmail.SetError(this.lblEmail, message);
                return;
            }

            else if (rdoManager.Checked == false && rdoStaff.Checked == false && rdoTechnician.Checked == false)
            {
                errEmployeeType.SetError(lblEmployeeType, "Seçim yapınız");
                return;
            }

            if (rdoManager.Checked == true && IsExistEmailManager(txtEmail.Text.ToString().Trim()) == 0)
            {
                return;
            }

            if (rdoStaff.Checked == true && IsExistEmailStaff(txtEmail.Text.ToString().Trim()) == 0)
            {
                return;
            }

            if (rdoTechnician.Checked == true && IsExistEmailTechnician(txtEmail.Text.ToString().Trim()) == 0)
            {
                return;
            }

            // mail gonderildi
            new MessageBoxes.SendEmailSuccesMessageBox().ShowDialog();

            // form uyelerini yeniden gorunur yap ve konumlarini ayarla
            lblSecurityCode.Visible = true;
            mtxtSecurityCode.Visible = true;
            pnlHorizonal2.Visible = true;

            lblSecurityCode.Location = new Point(85, 340);
            mtxtSecurityCode.Location = new Point(85, 380);
            btnSend.Visible = false;
            btnEmailVerification.Visible = true;
            btnEmailVerification.Location = new Point(85, 450);
            btnBackToLogin.Location = new Point(85, 515);
            pnlHorizonal2.Location = new Point(85, 415);
            txtEmail.Enabled = false;
            lblEmployeeType.Visible = false;
            rdoManager.Visible = false;
            rdoStaff.Visible = false;
            rdoTechnician.Visible = false;
        }

        // email dogrulama
        private void BtnEmailVerification_Click(object sender, EventArgs e)
        {
            // mailde ki kod
            string code = "123 123";
            if (!mtxtSecurityCode.MaskFull)
            {
                mtxtSecurityCode.Focus();
                errSecurityCode.SetError(this.lblSecurityCode, "Boş bırakılamaz");
                return;
            }

            // form uyelerinin konumlarini ayarla
            if (code == mtxtSecurityCode.Text)
            {
                lblEmail.Visible = false;
                txtEmail.Visible = false;
                lblSecurityCode.Visible = false;
                mtxtSecurityCode.Visible = false;
                btnEmailVerification.Visible = false;
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                lblConfirmPassword.Visible = true;
                txtConfirmPassword.Visible = true;
                btnShowPassword.Visible = true;
                btnHidePassword.Visible = true;
                btnConfirmShowPassword.Visible = true;
                btnConfirmHidePassword.Visible = true;
                btnNewPassword.Visible = true;
                btnNewPassword.Location = new Point(85, 450);
                lblNewPassword.Location = new Point(85, 240);
                txtNewPassword.Location = new Point(85, 280);
                btnShowPassword.Location = new Point(385, 280);
                btnHidePassword.Location = new Point(385, 280);
                lblConfirmPassword.Location = new Point(85, 340);
                txtConfirmPassword.Location = new Point(85, 380);
                btnConfirmShowPassword.Location = new Point(385, 380);
                btnConfirmHidePassword.Location = new Point(385, 380);
            }
            else
            {
                new MessageBoxes.SecurityCodeErrorMessageBox().ShowDialog();
                mtxtSecurityCode.Clear();
            }
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

        // manager sifresini degis
        private void ChangePasswordManager(string newPassword, string emailAddress)
        {
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                // sql sorgusu
                string query = "UPDATE Manager SET PasswordHash = @PasswordHash WHERE EmailAddress = @EmailAddress";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@PasswordHash", newPassword);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", emailAddress);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // staff sifresini degis
        private void ChangePasswordStaff(string newPassword, string emailAddress)
        {
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                // sql sorgusu
                string query = "UPDATE Staff SET PasswordHash = @PasswordHash WHERE EmailAddress = @EmailAddress";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@PasswordHash", newPassword);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", emailAddress);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // technician sifresini degis
        private void ChangePasswordTechnician(string newPassword, string emailAddress)
        {
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                // sql sorgusu
                string query = "UPDATE Technician SET PasswordHash = @PasswordHash WHERE EmailAddress = @EmailAddress";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@PasswordHash", newPassword);
                sqlCommand.Parameters.AddWithValue("@EmailAddress", emailAddress);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // btnNewPassword tiklanirsa
        private void BtnNewPassword_Click(object sender, EventArgs e)
        {
            string passwordHash = HashString(txtNewPassword.Text);
            string emailAddress = txtEmail.Text;

            // bos mu kontrol et
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                txtNewPassword.Focus();
                errPassword.SetError(lblNewPassword, "Boş bırakılamaz");
                return;
            }

            // duzgun formatta mi
            else if (Regex.IsMatch(txtNewPassword.Text, passwordPattern) == false)
            {
                txtNewPassword.Focus();
                string message = "Sifre en az 8 haneli olmalıdır. İçerisinde büyük harf, küçük harf, sayı, özel karakter içermelidir ve türkçe karakter bulunmamalıdır.";
                errPassword.SetError(this.lblNewPassword, message);
                return;
            }

            // ayni sifre girilmis mi
            else if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Focus();
                errConfirmPassword.SetError(lblConfirmPassword, "Aynı şifreyi girdiğinizden emin olun");
                return;
            }

            if (rdoManager.Checked == true)
            {
                ChangePasswordManager(passwordHash, emailAddress);
            }

            else if (rdoStaff.Checked == true)
            {
                ChangePasswordStaff(passwordHash, emailAddress);
            }

            else if (rdoTechnician.Checked == true)
            {
                ChangePasswordTechnician(passwordHash, emailAddress);
            }

            new MessageBoxes.PasswordChangeSuccessfulMessageBox().ShowDialog();
            btnNewPassword.Enabled = false;
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            btnBackToLogin.Text = "Giriş Yap";
        }

        // gorevli sifremi unuttum sayfasinin yuklenmesi
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
