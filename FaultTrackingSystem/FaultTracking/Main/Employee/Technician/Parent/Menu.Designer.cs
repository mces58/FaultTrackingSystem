namespace FaultTrackingSystem.FaultTracking.Main.Employee.Technician.Parent
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.tmrSideBar = new System.Windows.Forms.Timer(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.btnSparePart = new System.Windows.Forms.Button();
            this.picDesktop = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btnOpenMenu = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnFaultList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Controls.Add(this.btnFaultList);
            this.pnlSideBar.Controls.Add(this.btnUpdate);
            this.pnlSideBar.Controls.Add(this.btnSparePart);
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(65, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 800);
            this.pnlSideBar.TabIndex = 3;
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
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTitleBar.Controls.Add(this.picTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1200, 100);
            this.pnlTitleBar.TabIndex = 5;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitle_MouseDown);
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
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.pnlDesktop.Controls.Add(this.picDesktop);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(200, 100);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1200, 700);
            this.pnlDesktop.TabIndex = 6;
            // 
            // btnSparePart
            // 
            this.btnSparePart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSparePart.FlatAppearance.BorderSize = 0;
            this.btnSparePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSparePart.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparePart.ForeColor = System.Drawing.Color.Beige;
            this.btnSparePart.Image = global::FaultTrackingSystem.Properties.Resources.sparePartOrange40px;
            this.btnSparePart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSparePart.Location = new System.Drawing.Point(0, 290);
            this.btnSparePart.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnSparePart.Name = "btnSparePart";
            this.btnSparePart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSparePart.Size = new System.Drawing.Size(200, 50);
            this.btnSparePart.TabIndex = 13;
            this.btnSparePart.Text = "            Yedek Parçalar";
            this.btnSparePart.UseVisualStyleBackColor = true;
            this.btnSparePart.Click += new System.EventHandler(this.BtnSparePart_Click);
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
            // btnFaultList
            // 
            this.btnFaultList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaultList.FlatAppearance.BorderSize = 0;
            this.btnFaultList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaultList.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaultList.ForeColor = System.Drawing.Color.Beige;
            this.btnFaultList.Image = global::FaultTrackingSystem.Properties.Resources.homeOrange40px;
            this.btnFaultList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaultList.Location = new System.Drawing.Point(0, 130);
            this.btnFaultList.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnFaultList.Name = "btnFaultList";
            this.btnFaultList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFaultList.Size = new System.Drawing.Size(200, 50);
            this.btnFaultList.TabIndex = 11;
            this.btnFaultList.Text = "            Arızalı Cihazlar";
            this.btnFaultList.UseVisualStyleBackColor = true;
            this.btnFaultList.Click += new System.EventHandler(this.BtnFaultList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Beige;
            this.btnUpdate.Image = global::FaultTrackingSystem.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(0, 210);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "            Cihazı Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateDevice_Click);
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
            this.btnExit.Location = new System.Drawing.Point(0, 370);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDesktop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSideBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnOpenMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Timer tmrSideBar;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Button btnFaultList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSparePart;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox picDesktop;
    }
}