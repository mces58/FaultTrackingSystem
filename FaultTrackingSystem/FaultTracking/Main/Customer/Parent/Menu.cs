﻿using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Parent
{
    public partial class Menu : Form
    {
        private bool sideBarExpand;
        private Button currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form activeForm;

        // constructor
        public Menu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

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

        // random renk uret
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
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

        // formun hareketi
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // formun hareketi
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // formun hareketi
        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // sayfa yuklenirken
        private void Menu_Load(object sender, EventArgs e)
        {
            // border-radius
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnFaultRequest.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFaultRequest.Width, btnFaultRequest.Height, 50, 50));
            btnDetail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDetail.Width, btnDetail.Height, 50, 50));
            btnProfile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnProfile.Width, btnProfile.Height, 50, 50));
            btnAboutUs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAboutUs.Width, btnAboutUs.Height, 50, 50));
            btnContactUs.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnContactUs.Width, btnContactUs.Height, 50, 50));
            btnExit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 50, 50));
            btnOpenMenu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOpenMenu.Width, btnOpenMenu.Height, 20, 20));

            tmrLoad.Start();
        }

        // menunun hareketi
        private void TmrSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                // kenar cubugu genisletilirse simge durumuna kucultun
                pnlSideBar.Width -= 10;
                if (pnlSideBar.Width == pnlSideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    tmrSideBar.Stop();
                }
            }
            else
            {
                pnlSideBar.Width += 10;
                if (pnlSideBar.Width == pnlSideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    tmrSideBar.Stop();
                }
            }
        }

        // hangi buton aktiv ise ona renk ve animasyon koy
        private void ActivateButtom(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
                    pnlTitleBar.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrighness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrighness(color, -0.3);
                }
            }
        }

        // buton disable olursa eski haline geri donsun
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlSideBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI Black", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        // ana govdede ki butonlara da uygula
        private void OpenChildForm(Form childForm, object btnSender)
        {
            activeForm?.Close();
            ActivateButtom(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // timer baslat
        private void BtnOpenMenu_Click(object sender, EventArgs e)
        {
            tmrSideBar.Start();
        }

        // FaultRequest formuna git
        private void BtnFaultRequest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child.FaultRequest(), sender);
        }

        // Detail formuna git
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child.Detail(), sender);
        }

        // Payment formuna git
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child.Profile(), sender);
        }

        // AboutUs formuna git
        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child.AboutUs(), sender);
        }

        // ContactUs formuna git
        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child.ContactUs(), sender);
        }

        // ana sayfaya don
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        // musteri menusu sayfasinin yuklenmesi
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
