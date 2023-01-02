using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FaultTrackingSystem.FaultTracking.Main.Employee
{
    public partial class Login : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // global technicianCode
        public static string globalEmployeeCode;

        // constructor
        public Login()
        {
            InitializeComponent();
            Init_Data();
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

        // sayfa yuklenirken
        private void Login_Load(object sender, EventArgs e)
        {
            // border-radius
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 50, 50));
            btnMcesRecoLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMcesRecoLogo.Width, btnMcesRecoLogo.Height, 20, 20));
            mtxtEmployeeCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mtxtEmployeeCode.Width, mtxtEmployeeCode.Height, 20, 20));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 20, 20));
            btnHidePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnHidePassword.Width, btnHidePassword.Height, 20, 20));
            btnShowPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnShowPassword.Width, btnShowPassword.Height, 20, 20));

            tmrLoad.Start();
        }

        // remember me
        // onbellekteki verileri textbox'lara yaz
        private void Init_Data()
        {
            if (Properties.Settings.Default.EmployeeCode != String.Empty)
            {
                if (Properties.Settings.Default.EmployeeRememberMe == true)
                {
                    mtxtEmployeeCode.Text = Properties.Settings.Default.EmployeeCode;
                    txtPassword.Text = Properties.Settings.Default.EmployeePassword;
                    chkRememberMe.Checked = true;
                }
                else
                {
                    mtxtEmployeeCode.Text = Properties.Settings.Default.EmployeeCode;
                }
            }
        }

        // remember me
        // textbox'larda ki verileri onbellege kaydet
        private void Save_Data()
        {
            // checkBox tiklanirsa calisir
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.EmployeeCode = mtxtEmployeeCode.Text;
                Properties.Settings.Default.EmployeePassword = txtPassword.Text;
                Properties.Settings.Default.EmployeeRememberMe = true;
                Properties.Settings.Default.Save();
            }
            // checkBox tik kaldirilirsa calisir onbellek temizlenir
            else
            {
                Properties.Settings.Default.EmployeeCode = "";
                Properties.Settings.Default.EmployeePassword = "";
                Properties.Settings.Default.EmployeeRememberMe = false;
                Properties.Settings.Default.Save();
            }
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

        // formu kapat
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Home.Home home = new Home.Home();
            home.Show();
            this.Hide();
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
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnHidePassword.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        // errorProvider temizle
        private void CheckedChanged(object sender, EventArgs e)
        {
            errEmployeeType.Clear();
        }

        // errorProvider temizle
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // errProvider temizle
        private void MtxtEmployeeCode_KeyUp(object sender, KeyEventArgs e)
        {
            errEmployeeCode.Clear();
        }

        // password textbox'da degisirken
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // parolami unuttum sayfasina git
        private void LnklblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ForgetPassword().Show();
        }

        // btnLogin alanina girilirse renk ve font degissin
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(89, 150, 25);
            btnLogin.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnLogin.TextAlign = ContentAlignment.TopCenter;
        }

        // btnLogin alanindan cikilirsa eski haline geri don
        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(243, 116, 60);
            btnLogin.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnLogin.TextAlign = ContentAlignment.MiddleCenter;
        }

        // linkin font ayari
        private void LnklblForgetPassword_MouseEnter(object sender, EventArgs e)
        {
            lnklblForgetPassword.Font = new Font("Segoe UI Black", 10F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblForgetPassword.Location = new Point(170, 690);
            lnklblForgetPassword.LinkColor = Color.FromArgb(248, 8, 68);
            lnklblForgetPassword.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // linkin font eski ayarina donder
        private void LnklblForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            lnklblForgetPassword.Font = new Font("Segoe UI Black", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblForgetPassword.Location = new Point(175, 695);
            lnklblForgetPassword.LinkColor = Color.Silver;
            lnklblForgetPassword.LinkBehavior = LinkBehavior.AlwaysUnderline;
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

        // yonetici girisi
        private void LoginManager(string code, string password)
        {
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                sqlCommand = new SqlCommand();
                connection.Open();
                sqlCommand.Connection = connection;
                // sql sorgusu
                string query = "SELECT * FROM Manager WHERE Code = '" + code + "' AND PasswordHash  = '" + password + "'";
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    // kullaniciyi on bellege kaydet
                    Save_Data();
                    this.Hide();
                    new Manager.Parent.Menu().ShowDialog();
                }

                else
                {
                    new MessageBoxes.EmployeeLoginErrorMessageBox().ShowDialog();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // personel girisi
        private void LoginStaff(string code, string password)
        {
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                sqlCommand = new SqlCommand();
                connection.Open();
                sqlCommand.Connection = connection;
                // sql sorgusu
                string query = "SELECT * FROM Staff WHERE Code = '" + code + "' AND PasswordHash  = '" + password + "'";
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    // kullaniciyi on bellege kaydet
                    Save_Data();
                    this.Hide();
                    new Staff.Parent.Menu().ShowDialog();
                }

                else
                {
                    new MessageBoxes.EmployeeLoginErrorMessageBox().ShowDialog();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // teknisyen girisi
        private void LoginTechnician(string code, string password)
        {
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                sqlCommand = new SqlCommand();
                connection.Open();
                sqlCommand.Connection = connection;
                // sql sorgusu
                string query = "SELECT * FROM Technician WHERE Code = '" + code + "' AND PasswordHash  = '" + password + "'";
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    // kullaniciyi on bellege kaydet
                    Save_Data();
                    this.Hide();
                    new Technician.Parent.Menu().ShowDialog();
                }

                else
                {
                    new MessageBoxes.EmployeeLoginErrorMessageBox().ShowDialog();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // login butonuna tiklanirsa
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // gorevli kodu bos mu
            if (string.IsNullOrEmpty(mtxtEmployeeCode.Text))
            {
                mtxtEmployeeCode.Focus();
                errEmployeeCode.SetError(this.lblEmployeeCode, "Boş bırakılamaz");
                return;
            }

            // password bos mu
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errPassword.SetError(this.lblPassword, "Boş bırakılamaz");
                return;
            }

            // giris tipine bak
            if (rdoManager.Checked == false && rdoStaff.Checked == false && rdoTechnician.Checked == false)
            {
                errEmployeeType.SetError(lblEmployeeType, "Seçim yapın");
                return;
            }

            // employeeCode ile password yakala
            string code = mtxtEmployeeCode.Text.Trim();
            string passwordHash = HashString(txtPassword.Text.Trim());
            globalEmployeeCode = code;

            if (rdoManager.Checked == true)
            {
                LoginManager(code, passwordHash);
            }

            else if (rdoStaff.Checked == true)
            {
                LoginStaff(code, passwordHash);
            }

            else if (rdoTechnician.Checked == true)
            {
                LoginTechnician(code, passwordHash);
            }
        }

        // employee login sayfasinin yuklenmesi
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
