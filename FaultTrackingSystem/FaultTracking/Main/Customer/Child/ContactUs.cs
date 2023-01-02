using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    public partial class ContactUs : Form
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
        public ContactUs()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void ContactUs_Load(object sender, EventArgs e)
        {
            LoadTheme();
            btnSend.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSend.Width, btnSend.Height, 50, 50));
        }

        // btnSend animasyon
        private void BtnSend_MouseEnter(object sender, EventArgs e)
        {
            btnSend.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnSend.TextAlign = ContentAlignment.TopCenter;
        }

        // btnSend animasyon
        private void BtnSend_MouseLeave(object sender, EventArgs e)
        {
            btnSend.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnSend.TextAlign = ContentAlignment.MiddleCenter;
        }

        // lnklblAddress animasyon
        private void LnklblAddress_MouseEnter(object sender, EventArgs e)
        {
            lnklblAddress.Font = new Font("Segoe UI Black", 11F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblAddress.Location = new Point(185, 155);
            lnklblAddress.LinkColor = Color.FromArgb(248, 8, 68);
            lnklblAddress.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // lnklblAddress animasyon
        private void LnklblAddress_MouseLeave(object sender, EventArgs e)
        {
            lnklblAddress.Font = new Font("Segoe UI Black", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblAddress.Location = new Point(190, 160);
            lnklblAddress.LinkColor = Color.Silver;
            lnklblAddress.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        // lnklblEmail animasyon
        private void LnklblEmail_MouseEnter(object sender, EventArgs e)
        {
            lnklblEmail.Font = new Font("Segoe UI Black", 11F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblEmail.Location = new Point(185, 510);
            lnklblEmail.LinkColor = Color.FromArgb(248, 8, 68);
            lnklblEmail.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        // lnklblEmail animasyon
        private void LnklblEmail_MouseLeave(object sender, EventArgs e)
        {
            lnklblEmail.Font = new Font("Segoe UI Black", 9.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            lnklblEmail.Location = new Point(190, 515);
            lnklblEmail.LinkColor = Color.Silver;
            lnklblEmail.LinkBehavior = LinkBehavior.AlwaysUnderline;
        }

        // errorProvider temizle
        private void TxtSubject_Leave(object sender, EventArgs e)
        {
            errSubject.Clear();
        }

        // errorProvider temizle
        private void RtxtContent_Leave(object sender, EventArgs e)
        {
            errContent.Clear();
        }

        // errProvider temizle
        private void TxtSubject_TextChanged(object sender, EventArgs e)
        {
            errSubject.Clear();
        }

        // errProvider temizle
        private void RtxtContent_TextChanged(object sender, EventArgs e)
        {
            errContent.Clear();
        }

        // adres linkine tiklanirsa
        private void LnklblAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/maps/place/Band%C4%B1rma,+Bal%C4%B1kesir/@40.3388967,27.9312125,13z/data=!3m1!4b1!4m5!3m4!1s0x14b5d377a8bfb0f1:0xbd33d2bd7058850e!8m2!3d40.353707!4d27.971405");
        }

        // butona tiklanirsa
        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                txtSubject.Focus();
                errSubject.SetError(lblSubject, "Boş bırakılamaz");
                return;
            }

            else if (string.IsNullOrEmpty(rtxtContent.Text))
            {
                rtxtContent.Focus();
                errContent.SetError(lblContent, "Boş bırakılamaz");
                return;
            }

            txtSubject.Clear();
            rtxtContent.Clear();
            new MessageBoxes.SendMessageBox().ShowDialog();
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
