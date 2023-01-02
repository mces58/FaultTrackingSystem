using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.MessageBoxes
{
    public partial class SendEmailSuccesMessageBox : Form
    {
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

        // constructor
        public SendEmailSuccesMessageBox()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void SendEmailSuccesMessageBox_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnGo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGo.Width, btnGo.Height, 50, 50));
            btnOk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOk.Width, btnOk.Height, 50, 50));

            tmrLoad.Start();
        }

        // btnOk animasyon
        private void BtnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(89, 150, 25);
            btnOk.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnOk.TextAlign = ContentAlignment.TopCenter;
        }

        // btnOk animasyon
        private void BtnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(243, 116, 60);
            btnOk.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnOk.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnGo animasyon
        private void BtnGo_MouseEnter(object sender, EventArgs e)
        {
            btnGo.BackColor = Color.FromArgb(248, 8, 68);
            btnGo.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnGo.TextAlign = ContentAlignment.TopCenter;
        }

        // btnGo animasyon
        private void BtnGo_MouseLeave(object sender, EventArgs e)
        {
            btnGo.BackColor = Color.FromArgb(17, 97, 238);
            btnGo.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnGo.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnOk tiklanirsa gizle
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // btnGo tiklanirsa linke git
        private void BtnGo_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com");
            this.Hide();
        }

        // sayfasinin yuklenmesi
        private void TmrLoad_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmrLoad.Stop();
            }

            Opacity += 0.1;
        }
    }
}
