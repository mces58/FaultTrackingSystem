namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    partial class FaultRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaultRequest));
            this.cboDeviceType = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtxtOpenAddress = new System.Windows.Forms.RichTextBox();
            this.lblOpenAddress = new System.Windows.Forms.Label();
            this.cboDistrict = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.picDeviceImage = new System.Windows.Forms.PictureBox();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.picLocation = new System.Windows.Forms.PictureBox();
            this.picDeviceType = new System.Windows.Forms.PictureBox();
            this.picPromo = new System.Windows.Forms.PictureBox();
            this.btnFaultRequest = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errDeviceImage = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.errOpenAddress = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDeviceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOpenAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDeviceType
            // 
            this.cboDeviceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDeviceType.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeviceType.ForeColor = System.Drawing.Color.Beige;
            this.cboDeviceType.FormattingEnabled = true;
            this.cboDeviceType.Location = new System.Drawing.Point(150, 235);
            this.cboDeviceType.Margin = new System.Windows.Forms.Padding(0);
            this.cboDeviceType.Name = "cboDeviceType";
            this.cboDeviceType.Size = new System.Drawing.Size(250, 25);
            this.cboDeviceType.TabIndex = 70;
            this.cboDeviceType.SelectedIndexChanged += new System.EventHandler(this.CboDeviceType_SelectedIndexChanged);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.rtxtDescription.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.ForeColor = System.Drawing.Color.Beige;
            this.rtxtDescription.Location = new System.Drawing.Point(150, 490);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(250, 180);
            this.rtxtDescription.TabIndex = 69;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.TextChanged += new System.EventHandler(this.RtxtDescription_TextChanged);
            this.rtxtDescription.Leave += new System.EventHandler(this.RtxtDescription_Leave);
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceStatus.ForeColor = System.Drawing.Color.Beige;
            this.lblDeviceStatus.Location = new System.Drawing.Point(150, 450);
            this.lblDeviceStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(136, 21);
            this.lblDeviceStatus.TabIndex = 68;
            this.lblDeviceStatus.Text = "Cihazın Durumu";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.Color.Beige;
            this.txtSubject.Location = new System.Drawing.Point(150, 405);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(0);
            this.txtSubject.MaxLength = 50;
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(250, 30);
            this.txtSubject.TabIndex = 67;
            this.txtSubject.WordWrap = false;
            this.txtSubject.TextChanged += new System.EventHandler(this.TxtSubject_TextChanged);
            this.txtSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtSubject.Leave += new System.EventHandler(this.TxtSubject_Leave);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Beige;
            this.lblSubject.Location = new System.Drawing.Point(150, 370);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(109, 21);
            this.lblSubject.TabIndex = 66;
            this.lblSubject.Text = "Konu Başlığı";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice.ForeColor = System.Drawing.Color.Beige;
            this.lblDevice.Location = new System.Drawing.Point(150, 120);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(53, 21);
            this.lblDevice.TabIndex = 65;
            this.lblDevice.Text = "Cihaz";
            // 
            // cboBrand
            // 
            this.cboBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBrand.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrand.ForeColor = System.Drawing.Color.Beige;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(150, 315);
            this.cboBrand.Margin = new System.Windows.Forms.Padding(0);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(250, 25);
            this.cboBrand.TabIndex = 62;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.Beige;
            this.lblBrand.Location = new System.Drawing.Point(150, 280);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(63, 21);
            this.lblBrand.TabIndex = 61;
            this.lblBrand.Text = "Marka";
            // 
            // cboDevice
            // 
            this.cboDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDevice.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevice.ForeColor = System.Drawing.Color.Beige;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(150, 155);
            this.cboDevice.Margin = new System.Windows.Forms.Padding(0);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(250, 25);
            this.cboDevice.TabIndex = 60;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.CboDevice_SelectedIndexChanged);
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceType.ForeColor = System.Drawing.Color.Beige;
            this.lblDeviceType.Location = new System.Drawing.Point(150, 200);
            this.lblDeviceType.Margin = new System.Windows.Forms.Padding(0);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(93, 21);
            this.lblDeviceType.TabIndex = 59;
            this.lblDeviceType.Text = "Cihaz Türü";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Beige;
            this.lblAddress.Location = new System.Drawing.Point(555, 175);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(180, 21);
            this.lblAddress.TabIndex = 78;
            this.lblAddress.Text = "Teslim Edilecek Adres";
            // 
            // rtxtOpenAddress
            // 
            this.rtxtOpenAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.rtxtOpenAddress.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOpenAddress.ForeColor = System.Drawing.Color.Beige;
            this.rtxtOpenAddress.Location = new System.Drawing.Point(555, 455);
            this.rtxtOpenAddress.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtOpenAddress.Name = "rtxtOpenAddress";
            this.rtxtOpenAddress.Size = new System.Drawing.Size(220, 180);
            this.rtxtOpenAddress.TabIndex = 77;
            this.rtxtOpenAddress.Text = "";
            this.rtxtOpenAddress.TextChanged += new System.EventHandler(this.RtxtOpenAddress_TextChanged);
            this.rtxtOpenAddress.Leave += new System.EventHandler(this.RtxtOpenAddress_Leave);
            // 
            // lblOpenAddress
            // 
            this.lblOpenAddress.AutoSize = true;
            this.lblOpenAddress.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenAddress.ForeColor = System.Drawing.Color.Beige;
            this.lblOpenAddress.Location = new System.Drawing.Point(555, 415);
            this.lblOpenAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblOpenAddress.Name = "lblOpenAddress";
            this.lblOpenAddress.Size = new System.Drawing.Size(95, 21);
            this.lblOpenAddress.TabIndex = 76;
            this.lblOpenAddress.Text = "Açık Adres";
            // 
            // cboDistrict
            // 
            this.cboDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDistrict.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrict.ForeColor = System.Drawing.Color.Beige;
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Location = new System.Drawing.Point(555, 360);
            this.cboDistrict.Margin = new System.Windows.Forms.Padding(0);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(220, 25);
            this.cboDistrict.TabIndex = 75;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.Beige;
            this.lblDistrict.Location = new System.Drawing.Point(555, 325);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(38, 21);
            this.lblDistrict.TabIndex = 74;
            this.lblDistrict.Text = "İlçe";
            // 
            // cboCity
            // 
            this.cboCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCity.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.ForeColor = System.Drawing.Color.Beige;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(555, 265);
            this.cboCity.Margin = new System.Windows.Forms.Padding(0);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(220, 25);
            this.cboCity.TabIndex = 73;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.CboCity_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Beige;
            this.lblCity.Location = new System.Drawing.Point(555, 230);
            this.lblCity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(21, 21);
            this.lblCity.TabIndex = 72;
            this.lblCity.Text = "İl";
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.Beige;
            this.btnRemoveImage.Location = new System.Drawing.Point(925, 520);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(220, 40);
            this.btnRemoveImage.TabIndex = 83;
            this.btnRemoveImage.Text = "Kaldır";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            this.btnRemoveImage.MouseEnter += new System.EventHandler(this.BtnRemoveImage_MouseEnter);
            this.btnRemoveImage.MouseLeave += new System.EventHandler(this.BtnRemoveImage_MouseEnter);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImage.FlatAppearance.BorderSize = 0;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.ForeColor = System.Drawing.Color.Beige;
            this.btnUploadImage.Location = new System.Drawing.Point(925, 460);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(220, 40);
            this.btnUploadImage.TabIndex = 82;
            this.btnUploadImage.Text = "Yükle";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.BtnUploadImage_Click);
            this.btnUploadImage.MouseEnter += new System.EventHandler(this.BtnUploadImage_MouseEnter);
            this.btnUploadImage.MouseLeave += new System.EventHandler(this.BtnUploadImage_MouseLeave);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.Beige;
            this.lblImage.Location = new System.Drawing.Point(950, 175);
            this.lblImage.Margin = new System.Windows.Forms.Padding(0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(147, 21);
            this.lblImage.TabIndex = 80;
            this.lblImage.Text = "Cihazın Fotoğrafı";
            // 
            // picDeviceImage
            // 
            this.picDeviceImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.picDeviceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDeviceImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDeviceImage.Location = new System.Drawing.Point(925, 220);
            this.picDeviceImage.Margin = new System.Windows.Forms.Padding(0);
            this.picDeviceImage.Name = "picDeviceImage";
            this.picDeviceImage.Size = new System.Drawing.Size(220, 220);
            this.picDeviceImage.TabIndex = 81;
            this.picDeviceImage.TabStop = false;
            // 
            // picCamera
            // 
            this.picCamera.Image = global::FaultTrackingSystem.Properties.Resources.cameraOrange;
            this.picCamera.Location = new System.Drawing.Point(980, 65);
            this.picCamera.Margin = new System.Windows.Forms.Padding(0);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(65, 65);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.TabIndex = 79;
            this.picCamera.TabStop = false;
            // 
            // picLocation
            // 
            this.picLocation.Image = global::FaultTrackingSystem.Properties.Resources.locationOrange;
            this.picLocation.Location = new System.Drawing.Point(600, 65);
            this.picLocation.Margin = new System.Windows.Forms.Padding(0);
            this.picLocation.Name = "picLocation";
            this.picLocation.Size = new System.Drawing.Size(65, 65);
            this.picLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLocation.TabIndex = 71;
            this.picLocation.TabStop = false;
            // 
            // picDeviceType
            // 
            this.picDeviceType.Image = global::FaultTrackingSystem.Properties.Resources.deviceOrange;
            this.picDeviceType.Location = new System.Drawing.Point(50, 65);
            this.picDeviceType.Margin = new System.Windows.Forms.Padding(0);
            this.picDeviceType.Name = "picDeviceType";
            this.picDeviceType.Size = new System.Drawing.Size(65, 65);
            this.picDeviceType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeviceType.TabIndex = 58;
            this.picDeviceType.TabStop = false;
            // 
            // picPromo
            // 
            this.picPromo.Image = global::FaultTrackingSystem.Properties.Resources.promo;
            this.picPromo.Location = new System.Drawing.Point(1220, 0);
            this.picPromo.Margin = new System.Windows.Forms.Padding(0);
            this.picPromo.Name = "picPromo";
            this.picPromo.Size = new System.Drawing.Size(100, 700);
            this.picPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPromo.TabIndex = 57;
            this.picPromo.TabStop = false;
            // 
            // btnFaultRequest
            // 
            this.btnFaultRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaultRequest.FlatAppearance.BorderSize = 0;
            this.btnFaultRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaultRequest.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaultRequest.ForeColor = System.Drawing.Color.Beige;
            this.btnFaultRequest.Location = new System.Drawing.Point(925, 630);
            this.btnFaultRequest.Margin = new System.Windows.Forms.Padding(0);
            this.btnFaultRequest.Name = "btnFaultRequest";
            this.btnFaultRequest.Size = new System.Drawing.Size(220, 40);
            this.btnFaultRequest.TabIndex = 84;
            this.btnFaultRequest.Text = "Arıza Talebi Oluştur";
            this.btnFaultRequest.UseVisualStyleBackColor = true;
            this.btnFaultRequest.Click += new System.EventHandler(this.BtnFaultRequest_Click);
            this.btnFaultRequest.MouseEnter += new System.EventHandler(this.BtnFaultRequest_MouseEnter);
            this.btnFaultRequest.MouseLeave += new System.EventHandler(this.BtnFaultRequest_MouseLeave);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errDeviceImage
            // 
            this.errDeviceImage.ContainerControl = this;
            this.errDeviceImage.Icon = ((System.Drawing.Icon)(resources.GetObject("errDeviceImage.Icon")));
            // 
            // errDescription
            // 
            this.errDescription.ContainerControl = this;
            this.errDescription.Icon = ((System.Drawing.Icon)(resources.GetObject("errDescription.Icon")));
            // 
            // errSubject
            // 
            this.errSubject.ContainerControl = this;
            this.errSubject.Icon = ((System.Drawing.Icon)(resources.GetObject("errSubject.Icon")));
            // 
            // errOpenAddress
            // 
            this.errOpenAddress.ContainerControl = this;
            this.errOpenAddress.Icon = ((System.Drawing.Icon)(resources.GetObject("errOpenAddress.Icon")));
            // 
            // FaultRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnFaultRequest);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.picDeviceImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.rtxtOpenAddress);
            this.Controls.Add(this.lblOpenAddress);
            this.Controls.Add(this.cboDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.picLocation);
            this.Controls.Add(this.cboDeviceType);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDeviceStatus);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.picDeviceType);
            this.Controls.Add(this.picPromo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaultRequest";
            this.Text = "FaultRequest";
            this.Load += new System.EventHandler(this.FaultRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDeviceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOpenAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPromo;
        private System.Windows.Forms.ComboBox cboDeviceType;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.PictureBox picDeviceType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtxtOpenAddress;
        private System.Windows.Forms.Label lblOpenAddress;
        private System.Windows.Forms.ComboBox cboDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.PictureBox picLocation;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox picDeviceImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnFaultRequest;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errDeviceImage;
        private System.Windows.Forms.ErrorProvider errDescription;
        private System.Windows.Forms.ErrorProvider errSubject;
        private System.Windows.Forms.ErrorProvider errOpenAddress;
    }
}