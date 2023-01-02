using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Home
{
    public partial class Home : Form
    {
        // slayt gosterisi icin degiskenler
        private int index = 0;
        private readonly string[] images = Directory.GetFiles(@"C:\Users\mc_es\Desktop\Yeni klasör\FaultTrackingSystem\FaultTracking\Main\Picture");

        // constructor
        public Home()
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

        // sayfa yuklenirken
        private void Home_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnCorporate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCorporate.Width, btnCorporate.Height, 30, 30));
            btnIndividual.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnIndividual.Width, btnIndividual.Height, 30, 30));
            lblLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblLogin.Width, lblLogin.Height, 30, 30));
            picImages.Image = Image.FromFile(images[index]);
            
            tmrPicture.Start();
            btnIndividual.Visible = false;
            btnCorporate.Visible = false;
            pnlHorizonal.Visible = false;

            tmrLoad.Start();
        }

        // sayfayi minimize yap
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // uygulamayi kapat
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // musteri giris butonu animasyonu
        private void BtnIndividual_MouseEnter(object sender, EventArgs e)
        {
            btnIndividual.BackColor = Color.FromArgb(89, 150, 25);
            btnIndividual.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnIndividual.TextAlign = ContentAlignment.TopCenter;
        }

        // musteri giris butonu animasyonunu kaldir
        private void BtnIndividual_MouseLeave(object sender, EventArgs e)
        {
            btnIndividual.BackColor = Color.FromArgb(243, 116, 60);
            btnIndividual.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnIndividual.TextAlign = ContentAlignment.MiddleCenter;
            lblLogin.Location = new Point(875, 40);
            btnIndividual.Visible = false;
            btnCorporate.Visible = false;
            pnlHorizonal.Visible = false;
        }

        // kurumsal giris butonu animasyonu
        private void BtnCorporate_MouseEnter(object sender, EventArgs e)
        {
            btnCorporate.BackColor = Color.FromArgb(89, 150, 25);
            btnCorporate.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnCorporate.TextAlign = ContentAlignment.TopCenter;
        }

        // kurumsal giris butonu animasyonunu kaldir
        private void BtnCorporate_MouseLeave(object sender, EventArgs e)
        {
            btnCorporate.BackColor = Color.FromArgb(17, 97, 238);
            btnCorporate.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnCorporate.TextAlign = ContentAlignment.MiddleCenter;
            lblLogin.Location = new Point(875, 40);
            btnCorporate.Visible = false;
            btnIndividual.Visible = false;
            pnlHorizonal.Visible = false;
        }

        // musteri girisi
        private void BtnIndividual_Click(object sender, EventArgs e)
        {
            tmrIndividualTransition.Start();
        }

        // kurumsal girisi
        private void BtnCorporate_Click(object sender, EventArgs e)
        {
            tmrCorporateTransition.Start();
        }

        // slayt gosteri icin timer
        private void TmrPicture_Tick(object sender, EventArgs e)
        {
            index++;

            if (index == images.Length)
            {
                index = 0;
            }

            picImages.Image = Image.FromFile(images[index]);
        }

        // efektif giris
        private void LblLogin_MouseEnter(object sender, EventArgs e)
        {
            btnIndividual.Visible = true;
            btnCorporate.Visible = true;
            pnlHorizonal.Visible = true;
            lblLogin.Location = new Point(1000, 1000);
        }

        // efektif giris
        private void LblLogin_MouseLeave(object sender, EventArgs e)
        {
            btnIndividual.Visible = true;
            btnCorporate.Visible = true;
            pnlHorizonal.Visible = true;
            lblLogin.Visible = true;
        }

        // efektif giris
        private void PnlHorizonal_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.Location = new Point(875, 40);
            btnIndividual.Visible = false;
            btnCorporate.Visible = false;
            pnlHorizonal.Visible = false;
        }

        // home sayfasinin yuklenmesi
        private void TmrLoad_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmrLoad.Stop();
            }

            Opacity += 0.1;
        }

        // musteri sayfasina gidis
        private void TmrIndividualTransition_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                tmrIndividualTransition.Stop();
                new Customer.Parent.Login().Show();
                this.Hide();
            }
        }

        // kurumsal sayfaya gidis
        private void TmrCorporateTransition_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;

            if (this.Opacity == 0)
            {
                tmrCorporateTransition.Stop();
                new Employee.Login().Show();
                this.Hide();
            }
        }
    }
}
