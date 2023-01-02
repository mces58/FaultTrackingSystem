namespace FaultTrackingSystem.FaultTracking.Main.Customer.Parent
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnFaultRequest = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.picDesktop = new System.Windows.Forms.PictureBox();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Controls.Add(this.btnFaultRequest);
            this.pnlSideBar.Controls.Add(this.btnDetail);
            this.pnlSideBar.Controls.Add(this.btnProfile);
            this.pnlSideBar.Controls.Add(this.btnAboutUs);
            this.pnlSideBar.Controls.Add(this.btnContactUs);
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(65, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 800);
            this.pnlSideBar.TabIndex = 1;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.btnOpenMenu);
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 100);
            this.pnlLogo.TabIndex = 1;
            // 
            // btnOpenMenu
            // 
            this.btnOpenMenu.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.openMenuOrange40px;
            this.btnOpenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenMenu.FlatAppearance.BorderSize = 0;
            this.btnOpenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMenu.Location = new System.Drawing.Point(16, 30);
            this.btnOpenMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenMenu.Name = "btnOpenMenu";
            this.btnOpenMenu.Size = new System.Drawing.Size(40, 40);
            this.btnOpenMenu.TabIndex = 2;
            this.btnOpenMenu.UseVisualStyleBackColor = true;
            this.btnOpenMenu.Click += new System.EventHandler(this.BtnOpenMenu_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FaultTrackingSystem.Properties.Resources.faultTracking;
            this.picLogo.Location = new System.Drawing.Point(85, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnFaultRequest
            // 
            this.btnFaultRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaultRequest.FlatAppearance.BorderSize = 0;
            this.btnFaultRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaultRequest.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaultRequest.ForeColor = System.Drawing.Color.Beige;
            this.btnFaultRequest.Image = global::FaultTrackingSystem.Properties.Resources.homeOrange40px;
            this.btnFaultRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaultRequest.Location = new System.Drawing.Point(0, 130);
            this.btnFaultRequest.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnFaultRequest.Name = "btnFaultRequest";
            this.btnFaultRequest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFaultRequest.Size = new System.Drawing.Size(200, 50);
            this.btnFaultRequest.TabIndex = 2;
            this.btnFaultRequest.Text = "     Arıza Talebi";
            this.btnFaultRequest.UseVisualStyleBackColor = true;
            this.btnFaultRequest.Click += new System.EventHandler(this.BtnFaultRequest_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.Beige;
            this.btnDetail.Image = global::FaultTrackingSystem.Properties.Resources.detailOrange40px;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(0, 210);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetail.Size = new System.Drawing.Size(200, 50);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "Detaylar";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Beige;
            this.btnProfile.Image = global::FaultTrackingSystem.Properties.Resources.userOrange40px;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 290);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(200, 50);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profil";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.Beige;
            this.btnAboutUs.Image = global::FaultTrackingSystem.Properties.Resources.informationOrange40px;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 370);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(200, 50);
            this.btnAboutUs.TabIndex = 5;
            this.btnAboutUs.Text = "     Hakkımızda";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.BtnAboutUs_Click);
            // 
            // btnContactUs
            // 
            this.btnContactUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.ForeColor = System.Drawing.Color.Beige;
            this.btnContactUs.Image = global::FaultTrackingSystem.Properties.Resources.addressOrange40px;
            this.btnContactUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactUs.Location = new System.Drawing.Point(0, 450);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContactUs.Size = new System.Drawing.Size(200, 50);
            this.btnContactUs.TabIndex = 6;
            this.btnContactUs.Text = "     Bize Ulaşın";
            this.btnContactUs.UseVisualStyleBackColor = true;
            this.btnContactUs.Click += new System.EventHandler(this.BtnContactUs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Beige;
            this.btnExit.Image = global::FaultTrackingSystem.Properties.Resources.exitOrange40px;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 530);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTitleBar.Controls.Add(this.picTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1200, 100);
            this.pnlTitleBar.TabIndex = 3;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseDown);
            // 
            // picTitle
            // 
            this.picTitle.Image = global::FaultTrackingSystem.Properties.Resources.fault_tracking;
            this.picTitle.Location = new System.Drawing.Point(425, 25);
            this.picTitle.Margin = new System.Windows.Forms.Padding(0);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(400, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.pnlDesktop.Controls.Add(this.picDesktop);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(200, 100);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1200, 700);
            this.pnlDesktop.TabIndex = 4;
            // 
            // picDesktop
            // 
            this.picDesktop.Image = global::FaultTrackingSystem.Properties.Resources.welcome;
            this.picDesktop.Location = new System.Drawing.Point(1, 1);
            this.picDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.picDesktop.Name = "picDesktop";
            this.picDesktop.Size = new System.Drawing.Size(1198, 698);
            this.picDesktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDesktop.TabIndex = 0;
            this.picDesktop.TabStop = false;
            // 
            // tmrSideBar
            // 
            this.tmrSideBar.Interval = 5;
            this.tmrSideBar.Tick += new System.EventHandler(this.TmrSideBar_Tick);
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSideBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnFaultRequest;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox picDesktop;
        private System.Windows.Forms.Timer tmrSideBar;
        private System.Windows.Forms.Timer tmrLoad;
    }
}