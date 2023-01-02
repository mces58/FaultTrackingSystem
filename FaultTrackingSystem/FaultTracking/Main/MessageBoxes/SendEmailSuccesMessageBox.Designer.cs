namespace FaultTrackingSystem.FaultTracking.Main.MessageBoxes
{
    partial class SendEmailSuccesMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmailSuccesMessageBox));
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSuccesMessage = new System.Windows.Forms.Label();
            this.picSuccesLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccesLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(470, 50);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(186)))), ((int)(((byte)(124)))));
            this.lblTitle.Location = new System.Drawing.Point(155, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mail Gönderildi";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.Beige;
            this.btnGo.Location = new System.Drawing.Point(80, 180);
            this.btnGo.Margin = new System.Windows.Forms.Padding(0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(130, 40);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Git";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            this.btnGo.MouseEnter += new System.EventHandler(this.BtnGo_MouseEnter);
            this.btnGo.MouseLeave += new System.EventHandler(this.BtnGo_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Beige;
            this.btnOk.Location = new System.Drawing.Point(255, 180);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 40);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.BtnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.BtnOk_MouseLeave);
            // 
            // lblSuccesMessage
            // 
            this.lblSuccesMessage.AutoSize = true;
            this.lblSuccesMessage.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccesMessage.ForeColor = System.Drawing.Color.Beige;
            this.lblSuccesMessage.Location = new System.Drawing.Point(70, 135);
            this.lblSuccesMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblSuccesMessage.Name = "lblSuccesMessage";
            this.lblSuccesMessage.Size = new System.Drawing.Size(334, 21);
            this.lblSuccesMessage.TabIndex = 12;
            this.lblSuccesMessage.Text = "Lütfen mailde ki güvenlik kodunu giriniz.";
            // 
            // picSuccesLogo
            // 
            this.picSuccesLogo.Image = global::FaultTrackingSystem.Properties.Resources._checked;
            this.picSuccesLogo.Location = new System.Drawing.Point(185, 55);
            this.picSuccesLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picSuccesLogo.Name = "picSuccesLogo";
            this.picSuccesLogo.Size = new System.Drawing.Size(100, 60);
            this.picSuccesLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuccesLogo.TabIndex = 11;
            this.picSuccesLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 230);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 20);
            this.pnlBottom.TabIndex = 15;
            // 
            // SendEmailSuccesMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(470, 250);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSuccesMessage);
            this.Controls.Add(this.picSuccesLogo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendEmailSuccesMessageBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmailSuccesMessageBox";
            this.Load += new System.EventHandler(this.SendEmailSuccesMessageBox_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccesLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSuccesMessage;
        private System.Windows.Forms.PictureBox picSuccesLogo;
        private System.Windows.Forms.Panel pnlBottom;
    }
}