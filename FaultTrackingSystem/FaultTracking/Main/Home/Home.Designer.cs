namespace FaultTrackingSystem.FaultTracking.Main.Home
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlHorizonal = new System.Windows.Forms.Panel();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btnCorporate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tmrPicture = new System.Windows.Forms.Timer(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.tmrIndividualTransition = new System.Windows.Forms.Timer(this.components);
            this.tmrCorporateTransition = new System.Windows.Forms.Timer(this.components);
            this.picImages = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlTop.Controls.Add(this.lblLogin);
            this.pnlTop.Controls.Add(this.pnlHorizonal);
            this.pnlTop.Controls.Add(this.picTitle);
            this.pnlTop.Controls.Add(this.btnCorporate);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnIndividual);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1300, 100);
            this.pnlTop.TabIndex = 3;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Beige;
            this.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(875, 30);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(197, 30);
            this.lblLogin.TabIndex = 31;
            this.lblLogin.Text = "          Giriş Yap          ";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogin.MouseEnter += new System.EventHandler(this.LblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.LblLogin_MouseLeave);
            // 
            // pnlHorizonal
            // 
            this.pnlHorizonal.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal.Enabled = false;
            this.pnlHorizonal.Location = new System.Drawing.Point(980, 30);
            this.pnlHorizonal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal.Name = "pnlHorizonal";
            this.pnlHorizonal.Size = new System.Drawing.Size(2, 40);
            this.pnlHorizonal.TabIndex = 31;
            this.pnlHorizonal.MouseLeave += new System.EventHandler(this.PnlHorizonal_MouseLeave);
            // 
            // picTitle
            // 
            this.picTitle.Image = global::FaultTrackingSystem.Properties.Resources.fault_tracking;
            this.picTitle.Location = new System.Drawing.Point(150, 25);
            this.picTitle.Margin = new System.Windows.Forms.Padding(0);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(400, 50);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 30;
            this.picTitle.TabStop = false;
            // 
            // btnCorporate
            // 
            this.btnCorporate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnCorporate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorporate.FlatAppearance.BorderSize = 0;
            this.btnCorporate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorporate.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorporate.ForeColor = System.Drawing.Color.Beige;
            this.btnCorporate.Location = new System.Drawing.Point(1000, 30);
            this.btnCorporate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCorporate.Name = "btnCorporate";
            this.btnCorporate.Size = new System.Drawing.Size(180, 40);
            this.btnCorporate.TabIndex = 25;
            this.btnCorporate.Text = "Kurumsal";
            this.btnCorporate.UseVisualStyleBackColor = false;
            this.btnCorporate.Click += new System.EventHandler(this.BtnCorporate_Click);
            this.btnCorporate.MouseEnter += new System.EventHandler(this.BtnCorporate_MouseEnter);
            this.btnCorporate.MouseLeave += new System.EventHandler(this.BtnCorporate_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.closeOrange;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1270, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnIndividual
            // 
            this.btnIndividual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnIndividual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIndividual.FlatAppearance.BorderSize = 0;
            this.btnIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividual.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividual.ForeColor = System.Drawing.Color.Beige;
            this.btnIndividual.Location = new System.Drawing.Point(780, 30);
            this.btnIndividual.Margin = new System.Windows.Forms.Padding(0);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(180, 40);
            this.btnIndividual.TabIndex = 24;
            this.btnIndividual.Text = "Bireysel";
            this.btnIndividual.UseVisualStyleBackColor = false;
            this.btnIndividual.Click += new System.EventHandler(this.BtnIndividual_Click);
            this.btnIndividual.MouseEnter += new System.EventHandler(this.BtnIndividual_MouseEnter);
            this.btnIndividual.MouseLeave += new System.EventHandler(this.BtnIndividual_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.minimizeOrange;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1240, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FaultTrackingSystem.Properties.Resources.faultTracking;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tmrPicture
            // 
            this.tmrPicture.Interval = 2000;
            this.tmrPicture.Tick += new System.EventHandler(this.TmrPicture_Tick);
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // tmrIndividualTransition
            // 
            this.tmrIndividualTransition.Interval = 10;
            this.tmrIndividualTransition.Tick += new System.EventHandler(this.TmrIndividualTransition_Tick);
            // 
            // tmrCorporateTransition
            // 
            this.tmrCorporateTransition.Interval = 10;
            this.tmrCorporateTransition.Tick += new System.EventHandler(this.TmrCorporateTransition_Tick);
            // 
            // picImages
            // 
            this.picImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImages.Location = new System.Drawing.Point(0, 100);
            this.picImages.Margin = new System.Windows.Forms.Padding(0);
            this.picImages.Name = "picImages";
            this.picImages.Size = new System.Drawing.Size(1300, 600);
            this.picImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImages.TabIndex = 4;
            this.picImages.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.picImages);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlHorizonal;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btnCorporate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picImages;
        private System.Windows.Forms.Timer tmrPicture;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Timer tmrIndividualTransition;
        private System.Windows.Forms.Timer tmrCorporateTransition;
    }
}