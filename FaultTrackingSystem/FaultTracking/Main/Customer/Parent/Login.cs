using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Parent
{
    public partial class Login : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // global userName
        public static string globalUserName;

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

        // sayfa yuklendiginde
        private void Login_Load(object sender, EventArgs e)
        {
            // border-radius
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 50, 50));
            btnRegister.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegister.Width, btnRegister.Height, 50, 50));
            btnMcesRecoLogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMcesRecoLogo.Width, btnMcesRecoLogo.Height, 20, 20));
            txtUserName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtUserName.Width, txtUserName.Height, 20, 20));
            txtPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtPassword.Width, txtPassword.Height, 20, 20));
            btnHidePassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnHidePassword.Width, btnHidePassword.Height, 20, 20));
            btnShowPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnShowPassword.Width, btnShowPassword.Height, 20, 20));

            tmrLoad.Start();
        }

        // logoya tiklanirsa linke git
        private void BtnMcesRecoLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mces58");
        }

        // logoya tiklanirsa facebook git
        private void PicFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://tr-tr.facebook.com/");
        }

        // logoya tiklanirsa gmail git
        private void PicGmail_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox");
        }

        // logoya tiklanirsa twitter git
        private void PicTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com");
        }

        // remember me
        // onbellekteki verileri textbox'lara yaz
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                if (Properties.Settings.Default.UserRememberMe == true)
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                    txtPassword.Text = Properties.Settings.Default.UserPassword;
                    chkRememberMe.Checked = true;
                }
                else
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
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
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.UserPassword = txtPassword.Text;
                Properties.Settings.Default.UserRememberMe = true;
                Properties.Settings.Default.Save();
            }
            // checkBox tik kaldirilirsa calisir onbellek temizlenir
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.UserPassword = "";
                Properties.Settings.Default.UserRememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        // userName textbox'da text degisirken
        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            errUserName.Clear();
        }

        // password textbox'da degisirken
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            errPassword.Clear();
        }

        // errorProvider temizle
        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            errUserName.Clear();
        }
        // errorProvider temizle
        private void TxtPassword_Leave(object sender, EventArgs e)
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

        // btnRegister alanina girilirse renk ve font degissin
        private void BtnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(248, 8, 68);
            btnRegister.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnRegister.TextAlign = ContentAlignment.TopCenter;
        }

        // btnRegister alanina girilirse renk ve font degissin
        private void BtnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(17, 97, 238);
            btnRegister.Font = new Font("Segoe UI Black", 12F, ((FontStyle)(((FontStyle.Bold | FontStyle.Italic) | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
            btnRegister.TextAlign = ContentAlignment.MiddleCenter;
        }

        // facebook animasyon
        private void PicFacebook_MouseEnter(object sender, EventArgs e)
        {
            picFacebook.Size = new Size(80, 60);
            picFacebook.Location = new Point(80, 665);
        }

        // facebook animasyon kaldir
        private void PicFacebook_MouseLeave(object sender, EventArgs e)
        {
            picFacebook.Size = new Size(70, 45);
            picFacebook.Location = new Point(85, 680);
        }

        // gmail animasyon
        private void PicGmail_MouseEnter(object sender, EventArgs e)
        {
            picGmail.Size = new Size(80, 60);
            picGmail.Location = new Point(190, 665);
        }

        // gmail animasyon kaldir
        private void PicGmail_MouseLeave(object sender, EventArgs e)
        {
            picGmail.Size = new Size(70, 45);
            picGmail.Location = new Point(195, 680);

        }

        // twitter animasyon
        private void PicTwitter_MouseEnter(object sender, EventArgs e)
        {
            picTwitter.Size = new Size(80, 60);
            picTwitter.Location = new Point(310, 665);
        }

        // twitter animasyon kaldir
        private void PicTwitter_MouseLeave(object sender, EventArgs e)
        {
            picTwitter.Size = new Size(70, 45);
            picTwitter.Location = new Point(315, 680);
        }

        // linkin font ayari
        private void LnklblForgetPassword_MouseEnter(object sender, EventArgs e)
        {
            lnklblForgetPassword.Font = new Font("Segoe UI Black", 10F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblForgetPassword.Location = new Point(173, 605);
            lnklblForgetPassword.LinkColor = Color.FromArgb(248, 8, 68);
            lnklblForgetPassword.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // linkin font eski ayarina donder
        private void LnklblForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            lnklblForgetPassword.Font = new Font("Segoe UI Black", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblForgetPassword.Location = new Point(175, 610);
            lnklblForgetPassword.LinkColor = Color.Silver;
            lnklblForgetPassword.LinkBehavior = LinkBehavior.AlwaysUnderline;
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

        // kayit ol formuna git
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
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

        // login tiklanirsa
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // userName bos mu
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                errUserName.SetError(this.lblUserName, "Boş bırakılamaz");
                return;
            }

            // password bos mu
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                errPassword.SetError(this.lblPassword, "Boş bırakılamaz");
                return;
            }

            // userName ile password yakala
            string userName = txtUserName.Text;
            string passwordHash = HashString(txtPassword.Text);
            globalUserName = userName;
            try
            {
                // baglanti islemleri
                connection = new SqlConnection(connectionUrl);
                sqlCommand = new SqlCommand();
                connection.Open();
                sqlCommand.Connection = connection;
                // sql sorgusu
                string query = "SELECT * FROM Customer WHERE UserName = '" + userName + "' AND PasswordHash  = '" + passwordHash + "'";
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();

                // boyle bir kullanici var ise CustomerMenu'ye git
                if (dataReader.Read())
                {
                    // kullaniciyi on bellege kaydet
                    Save_Data();
                    this.Hide();
                    new Menu().ShowDialog();
                }
                // boyle bir kullanici yok ise hata mesajini goster
                else
                {
                    new MessageBoxes.CustomerLoginErrorMessageBox().ShowDialog();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // musteri login sayfasinin yuklenmesi
        private void TmrLoad_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmrLoad.Stop();
            }

            Opacity += .1;
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
