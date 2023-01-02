namespace FaultTrackingSystem.FaultTracking.Main.Employee.Manager.Parent
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnTechnician = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.picDesktop = new System.Windows.Forms.PictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).BeginInit();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Controls.Add(this.btnCustomer);
            this.pnlSideBar.Controls.Add(this.btnCategory);
            this.pnlSideBar.Controls.Add(this.btnRegion);
            this.pnlSideBar.Controls.Add(this.btnStaff);
            this.pnlSideBar.Controls.Add(this.btnTechnician);
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(65, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 800);
            this.pnlSideBar.TabIndex = 2;
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
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Beige;
            this.btnCustomer.Image = global::FaultTrackingSystem.Properties.Resources.customerOrange40px;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 130);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(200, 50);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "       Müşteriler";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Beige;
            this.btnCategory.Image = global::FaultTrackingSystem.Properties.Resources.categoryOrange40px;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 210);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(200, 50);
            this.btnCategory.TabIndex = 6;
            this.btnCategory.Text = "       Kategori Ekle";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // btnRegion
            // 
            this.btnRegion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegion.FlatAppearance.BorderSize = 0;
            this.btnRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegion.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegion.ForeColor = System.Drawing.Color.Beige;
            this.btnRegion.Image = global::FaultTrackingSystem.Properties.Resources.addressOrange40px;
            this.btnRegion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegion.Location = new System.Drawing.Point(0, 290);
            this.btnRegion.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegion.Size = new System.Drawing.Size(200, 50);
            this.btnRegion.TabIndex = 5;
            this.btnRegion.Text = "     Bölge Ekle";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.BtnRegion_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Beige;
            this.btnStaff.Image = global::FaultTrackingSystem.Properties.Resources.staffOrange40px;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 370);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(200, 50);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "       Personeller";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnTechnician
            // 
            this.btnTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTechnician.FlatAppearance.BorderSize = 0;
            this.btnTechnician.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnician.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnician.ForeColor = System.Drawing.Color.Beige;
            this.btnTechnician.Image = global::FaultTrackingSystem.Properties.Resources.technicianOrange40px;
            this.btnTechnician.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTechnician.Location = new System.Drawing.Point(0, 450);
            this.btnTechnician.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnTechnician.Name = "btnTechnician";
            this.btnTechnician.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTechnician.Size = new System.Drawing.Size(200, 50);
            this.btnTechnician.TabIndex = 4;
            this.btnTechnician.Text = "        Teknisyenler";
            this.btnTechnician.UseVisualStyleBackColor = true;
            this.btnTechnician.Click += new System.EventHandler(this.BtnTechnician_Click);
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
            this.pnlTitleBar.TabIndex = 4;
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
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.pnlDesktop.Controls.Add(this.picDesktop);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(200, 100);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1200, 700);
            this.pnlDesktop.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).EndInit();
            this.pnlDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSideBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnTechnician;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Timer tmrSideBar;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.PictureBox picDesktop;
        private System.Windows.Forms.Panel pnlDesktop;
    }
}