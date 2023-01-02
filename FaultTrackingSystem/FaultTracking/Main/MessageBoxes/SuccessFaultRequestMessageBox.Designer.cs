namespace FaultTrackingSystem.FaultTracking.Main.MessageBoxes
{
    partial class SuccessFaultRequestMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessFaultRequestMessageBox));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.lblSuccesMessage = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.picSuccesLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccesLogo)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.ForeColor = System.Drawing.Color.Beige;
            this.lblTitle.Location = new System.Drawing.Point(155, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "İnceleme Süreci";
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Beige;
            this.btnOk.Location = new System.Drawing.Point(170, 185);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 40);
            this.btnOk.TabIndex = 12;
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
            this.lblSuccesMessage.Location = new System.Drawing.Point(55, 125);
            this.lblSuccesMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblSuccesMessage.Name = "lblSuccesMessage";
            this.lblSuccesMessage.Size = new System.Drawing.Size(360, 42);
            this.lblSuccesMessage.TabIndex = 11;
            this.lblSuccesMessage.Text = "Talebiniz alınmıştır. İncelemeler sonucu size \r\n24 saat içinde geri bildirim yapı" +
    "lacaktır.";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 230);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 20);
            this.pnlBottom.TabIndex = 13;
            // 
            // picSuccesLogo
            // 
            this.picSuccesLogo.Image = global::FaultTrackingSystem.Properties.Resources.administration;
            this.picSuccesLogo.Location = new System.Drawing.Point(185, 50);
            this.picSuccesLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picSuccesLogo.Name = "picSuccesLogo";
            this.picSuccesLogo.Size = new System.Drawing.Size(100, 60);
            this.picSuccesLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSuccesLogo.TabIndex = 10;
            this.picSuccesLogo.TabStop = false;
            // 
            // SuccessFaultRequestMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(470, 250);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSuccesMessage);
            this.Controls.Add(this.picSuccesLogo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuccessFaultRequestMessageBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessFaultRequestMessageBox";
            this.Load += new System.EventHandler(this.SuccessFaultRequestMessageBox_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuccesLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSuccesMessage;
        private System.Windows.Forms.PictureBox picSuccesLogo;
        private System.Windows.Forms.Panel pnlBottom;
    }
}