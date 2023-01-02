namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.lblMisson = new System.Windows.Forms.Label();
            this.lblVision = new System.Windows.Forms.Label();
            this.picVision = new System.Windows.Forms.PictureBox();
            this.picMission = new System.Windows.Forms.PictureBox();
            this.picPromo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMisson
            // 
            this.lblMisson.AutoSize = true;
            this.lblMisson.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisson.ForeColor = System.Drawing.Color.Beige;
            this.lblMisson.Location = new System.Drawing.Point(140, 60);
            this.lblMisson.Margin = new System.Windows.Forms.Padding(0);
            this.lblMisson.Name = "lblMisson";
            this.lblMisson.Size = new System.Drawing.Size(1039, 336);
            this.lblMisson.TabIndex = 8;
            this.lblMisson.Text = resources.GetString("lblMisson.Text");
            // 
            // lblVision
            // 
            this.lblVision.AutoSize = true;
            this.lblVision.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVision.ForeColor = System.Drawing.Color.Beige;
            this.lblVision.Location = new System.Drawing.Point(140, 455);
            this.lblVision.Margin = new System.Windows.Forms.Padding(0);
            this.lblVision.Name = "lblVision";
            this.lblVision.Size = new System.Drawing.Size(1047, 210);
            this.lblVision.TabIndex = 9;
            this.lblVision.Text = resources.GetString("lblVision.Text");
            // 
            // picVision
            // 
            this.picVision.Image = global::FaultTrackingSystem.Properties.Resources.visionOrange;
            this.picVision.Location = new System.Drawing.Point(35, 485);
            this.picVision.Margin = new System.Windows.Forms.Padding(0);
            this.picVision.Name = "picVision";
            this.picVision.Size = new System.Drawing.Size(65, 65);
            this.picVision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVision.TabIndex = 12;
            this.picVision.TabStop = false;
            // 
            // picMission
            // 
            this.picMission.Image = global::FaultTrackingSystem.Properties.Resources.missionOrange;
            this.picMission.Location = new System.Drawing.Point(35, 90);
            this.picMission.Margin = new System.Windows.Forms.Padding(0);
            this.picMission.Name = "picMission";
            this.picMission.Size = new System.Drawing.Size(65, 65);
            this.picMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMission.TabIndex = 11;
            this.picMission.TabStop = false;
            // 
            // picPromo
            // 
            this.picPromo.Image = global::FaultTrackingSystem.Properties.Resources.promo;
            this.picPromo.Location = new System.Drawing.Point(1220, 0);
            this.picPromo.Margin = new System.Windows.Forms.Padding(0);
            this.picPromo.Name = "picPromo";
            this.picPromo.Size = new System.Drawing.Size(100, 700);
            this.picPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPromo.TabIndex = 10;
            this.picPromo.TabStop = false;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.picVision);
            this.Controls.Add(this.picMission);
            this.Controls.Add(this.picPromo);
            this.Controls.Add(this.lblVision);
            this.Controls.Add(this.lblMisson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            ((System.ComponentModel.ISupportInitialize)(this.picVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisson;
        private System.Windows.Forms.Label lblVision;
        private System.Windows.Forms.PictureBox picPromo;
        private System.Windows.Forms.PictureBox picVision;
        private System.Windows.Forms.PictureBox picMission;
    }
}