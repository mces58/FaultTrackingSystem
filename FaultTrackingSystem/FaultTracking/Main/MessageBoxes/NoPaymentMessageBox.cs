using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.MessageBoxes
{
    public partial class NoPaymentMessageBox : Form
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
        public NoPaymentMessageBox()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void NoPaymentMessageBox_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnOk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOk.Width, btnOk.Height, 50, 50));

            tmrLoad.Start();
        }

        // buton alanina girilirse renk ve font degissin
        private void BtnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(89, 150, 25);
            btnOk.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnOk.TextAlign = ContentAlignment.TopCenter;
        }

        // butonun alanindan cikilirsa font ve renk eski ayarlarina donsun
        private void BtnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(243, 116, 60);
            btnOk.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnOk.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnOk tiklanirsa
        private void BtnOk_Click(object sender, EventArgs e)
        {
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
