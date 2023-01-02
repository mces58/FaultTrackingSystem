namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.picPromo = new System.Windows.Forms.PictureBox();
            this.pnlLineTotal = new System.Windows.Forms.Panel();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.mtxtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.picPayment = new System.Windows.Forms.PictureBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.mtxtCVV = new System.Windows.Forms.MaskedTextBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlMasterCardFront = new System.Windows.Forms.Panel();
            this.lblMasterCardName = new System.Windows.Forms.Label();
            this.lblMasterCardDate = new System.Windows.Forms.Label();
            this.lblMasterCardNumber = new System.Windows.Forms.Label();
            this.picMasterCardFront = new System.Windows.Forms.PictureBox();
            this.pnlMasterCardBack = new System.Windows.Forms.Panel();
            this.lblMasterCardCVV = new System.Windows.Forms.Label();
            this.picMasterCardBack = new System.Windows.Forms.PictureBox();
            this.pnlVisaCardFront = new System.Windows.Forms.Panel();
            this.lblVisaCardNumber = new System.Windows.Forms.Label();
            this.lblVisaCardDate = new System.Windows.Forms.Label();
            this.lblVisaCardName = new System.Windows.Forms.Label();
            this.picVisaCardFront = new System.Windows.Forms.PictureBox();
            this.pnlVisaCardBack = new System.Windows.Forms.Panel();
            this.lblVisaCardCVV = new System.Windows.Forms.Label();
            this.picVisaCardBack = new System.Windows.Forms.PictureBox();
            this.errPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCardNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMonth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCVV = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).BeginInit();
            this.pnlLineTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            this.pnlMasterCardFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMasterCardFront)).BeginInit();
            this.pnlMasterCardBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMasterCardBack)).BeginInit();
            this.pnlVisaCardFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisaCardFront)).BeginInit();
            this.pnlVisaCardBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisaCardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCVV)).BeginInit();
            this.SuspendLayout();
            // 
            // picPromo
            // 
            this.picPromo.Image = global::FaultTrackingSystem.Properties.Resources.promo;
            this.picPromo.Location = new System.Drawing.Point(1220, 0);
            this.picPromo.Margin = new System.Windows.Forms.Padding(0);
            this.picPromo.Name = "picPromo";
            this.picPromo.Size = new System.Drawing.Size(100, 700);
            this.picPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPromo.TabIndex = 64;
            this.picPromo.TabStop = false;
            // 
            // pnlLineTotal
            // 
            this.pnlLineTotal.BackColor = System.Drawing.Color.Beige;
            this.pnlLineTotal.Controls.Add(this.lblCurrency);
            this.pnlLineTotal.Controls.Add(this.lblPrice);
            this.pnlLineTotal.Location = new System.Drawing.Point(85, 275);
            this.pnlLineTotal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLineTotal.Name = "pnlLineTotal";
            this.pnlLineTotal.Size = new System.Drawing.Size(200, 25);
            this.pnlLineTotal.TabIndex = 74;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(174, 4);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(23, 17);
            this.lblCurrency.TabIndex = 1;
            this.lblCurrency.Text = "TL";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 4);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(16, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "0";
            // 
            // cboCardType
            // 
            this.cboCardType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCardType.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCardType.ForeColor = System.Drawing.Color.Beige;
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Location = new System.Drawing.Point(85, 375);
            this.cboCardType.Margin = new System.Windows.Forms.Padding(0);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(200, 28);
            this.cboCardType.TabIndex = 73;
            this.cboCardType.DropDownClosed += new System.EventHandler(this.CboCardType_DropDownClosed);
            // 
            // mtxtCardNumber
            // 
            this.mtxtCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.mtxtCardNumber.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCardNumber.ForeColor = System.Drawing.Color.Beige;
            this.mtxtCardNumber.Location = new System.Drawing.Point(85, 585);
            this.mtxtCardNumber.Margin = new System.Windows.Forms.Padding(0);
            this.mtxtCardNumber.Mask = "0000 0000 0000 0000";
            this.mtxtCardNumber.Name = "mtxtCardNumber";
            this.mtxtCardNumber.PromptChar = '-';
            this.mtxtCardNumber.Size = new System.Drawing.Size(200, 29);
            this.mtxtCardNumber.TabIndex = 72;
            this.mtxtCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtCardNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MtxtCardNumber_KeyUp);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.Beige;
            this.lblCardNumber.Location = new System.Drawing.Point(85, 545);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(65, 20);
            this.lblCardNumber.TabIndex = 71;
            this.lblCardNumber.Text = "Kart No";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Beige;
            this.txtName.Location = new System.Drawing.Point(85, 480);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 22;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 70;
            this.txtName.WordWrap = false;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Beige;
            this.lblName.Location = new System.Drawing.Point(85, 440);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 20);
            this.lblName.TabIndex = 69;
            this.lblName.Text = "Ad Soyad";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.ForeColor = System.Drawing.Color.Beige;
            this.lblCardType.Location = new System.Drawing.Point(85, 335);
            this.lblCardType.Margin = new System.Windows.Forms.Padding(0);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(77, 20);
            this.lblCardType.TabIndex = 68;
            this.lblCardType.Text = "Kart Türü";
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineTotal.ForeColor = System.Drawing.Color.Beige;
            this.lblLineTotal.Location = new System.Drawing.Point(85, 235);
            this.lblLineTotal.Margin = new System.Windows.Forms.Padding(0);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(132, 20);
            this.lblLineTotal.TabIndex = 67;
            this.lblLineTotal.Text = "Ödenecek Miktar";
            // 
            // picPayment
            // 
            this.picPayment.Image = global::FaultTrackingSystem.Properties.Resources.securityPaymentOrange;
            this.picPayment.Location = new System.Drawing.Point(145, 140);
            this.picPayment.Margin = new System.Windows.Forms.Padding(0);
            this.picPayment.Name = "picPayment";
            this.picPayment.Size = new System.Drawing.Size(65, 65);
            this.picPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPayment.TabIndex = 66;
            this.picPayment.TabStop = false;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Beige;
            this.lblPayment.Location = new System.Drawing.Point(50, 70);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(275, 25);
            this.lblPayment.TabIndex = 65;
            this.lblPayment.Text = "ÖDEMENİZİ TAMAMLAYIN !";
            // 
            // btnPayment
            // 
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Beige;
            this.btnPayment.Location = new System.Drawing.Point(880, 630);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(200, 40);
            this.btnPayment.TabIndex = 75;
            this.btnPayment.Text = "Öde";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            this.btnPayment.MouseEnter += new System.EventHandler(this.BtnPayment_MouseEnter);
            this.btnPayment.MouseLeave += new System.EventHandler(this.BtnPayment_MouseLeave);
            // 
            // mtxtCVV
            // 
            this.mtxtCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.mtxtCVV.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCVV.ForeColor = System.Drawing.Color.Beige;
            this.mtxtCVV.Location = new System.Drawing.Point(505, 525);
            this.mtxtCVV.Margin = new System.Windows.Forms.Padding(0);
            this.mtxtCVV.Mask = "000";
            this.mtxtCVV.Name = "mtxtCVV";
            this.mtxtCVV.PromptChar = '-';
            this.mtxtCVV.Size = new System.Drawing.Size(145, 29);
            this.mtxtCVV.TabIndex = 83;
            this.mtxtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtCVV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MtxtCVV_KeyUp);
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.ForeColor = System.Drawing.Color.Beige;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(505, 420);
            this.cboYear.Margin = new System.Windows.Forms.Padding(0);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(145, 28);
            this.cboYear.TabIndex = 82;
            this.cboYear.DropDown += new System.EventHandler(this.CboYear_DropDown);
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.CboYear_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMonth.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.Color.Beige;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(505, 315);
            this.cboMonth.Margin = new System.Windows.Forms.Padding(0);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(145, 28);
            this.cboMonth.TabIndex = 81;
            this.cboMonth.DropDown += new System.EventHandler(this.CboMonth_DropDown);
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.CboMonth_SelectedIndexChanged);
            // 
            // picDate
            // 
            this.picDate.Image = ((System.Drawing.Image)(resources.GetObject("picDate.Image")));
            this.picDate.Location = new System.Drawing.Point(555, 145);
            this.picDate.Margin = new System.Windows.Forms.Padding(0);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(55, 55);
            this.picDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDate.TabIndex = 80;
            this.picDate.TabStop = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Beige;
            this.lblMonth.Location = new System.Drawing.Point(505, 275);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(30, 20);
            this.lblMonth.TabIndex = 79;
            this.lblMonth.Text = "AY";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Beige;
            this.lblYear.Location = new System.Drawing.Point(505, 380);
            this.lblYear.Margin = new System.Windows.Forms.Padding(0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 20);
            this.lblYear.TabIndex = 78;
            this.lblYear.Text = "YIL";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.ForeColor = System.Drawing.Color.Beige;
            this.lblCVV.Location = new System.Drawing.Point(505, 485);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(40, 20);
            this.lblCVV.TabIndex = 77;
            this.lblCVV.Text = "CVV";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Beige;
            this.lblDate.Location = new System.Drawing.Point(505, 235);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(153, 20);
            this.lblDate.TabIndex = 76;
            this.lblDate.Text = "Son Kullanım Tarihi";
            // 
            // pnlMasterCardFront
            // 
            this.pnlMasterCardFront.Controls.Add(this.lblMasterCardName);
            this.pnlMasterCardFront.Controls.Add(this.lblMasterCardDate);
            this.pnlMasterCardFront.Controls.Add(this.lblMasterCardNumber);
            this.pnlMasterCardFront.Controls.Add(this.picMasterCardFront);
            this.pnlMasterCardFront.Location = new System.Drawing.Point(825, 150);
            this.pnlMasterCardFront.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMasterCardFront.Name = "pnlMasterCardFront";
            this.pnlMasterCardFront.Size = new System.Drawing.Size(300, 150);
            this.pnlMasterCardFront.TabIndex = 84;
            // 
            // lblMasterCardName
            // 
            this.lblMasterCardName.AutoSize = true;
            this.lblMasterCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lblMasterCardName.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasterCardName.ForeColor = System.Drawing.Color.Beige;
            this.lblMasterCardName.Location = new System.Drawing.Point(4, 124);
            this.lblMasterCardName.Name = "lblMasterCardName";
            this.lblMasterCardName.Size = new System.Drawing.Size(88, 15);
            this.lblMasterCardName.TabIndex = 30;
            this.lblMasterCardName.Text = "İSİM SOYİSİM";
            // 
            // lblMasterCardDate
            // 
            this.lblMasterCardDate.AutoSize = true;
            this.lblMasterCardDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lblMasterCardDate.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterCardDate.ForeColor = System.Drawing.Color.Beige;
            this.lblMasterCardDate.Location = new System.Drawing.Point(169, 94);
            this.lblMasterCardDate.Name = "lblMasterCardDate";
            this.lblMasterCardDate.Size = new System.Drawing.Size(52, 17);
            this.lblMasterCardDate.TabIndex = 29;
            this.lblMasterCardDate.Text = "AY/YIL";
            // 
            // lblMasterCardNumber
            // 
            this.lblMasterCardNumber.AutoSize = true;
            this.lblMasterCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lblMasterCardNumber.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterCardNumber.ForeColor = System.Drawing.Color.Beige;
            this.lblMasterCardNumber.Location = new System.Drawing.Point(32, 66);
            this.lblMasterCardNumber.Name = "lblMasterCardNumber";
            this.lblMasterCardNumber.Size = new System.Drawing.Size(219, 25);
            this.lblMasterCardNumber.TabIndex = 28;
            this.lblMasterCardNumber.Text = "0000 0000 0000 0000";
            // 
            // picMasterCardFront
            // 
            this.picMasterCardFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMasterCardFront.Image = global::FaultTrackingSystem.Properties.Resources.masterCardFront;
            this.picMasterCardFront.Location = new System.Drawing.Point(0, 0);
            this.picMasterCardFront.Margin = new System.Windows.Forms.Padding(0);
            this.picMasterCardFront.Name = "picMasterCardFront";
            this.picMasterCardFront.Size = new System.Drawing.Size(300, 150);
            this.picMasterCardFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMasterCardFront.TabIndex = 24;
            this.picMasterCardFront.TabStop = false;
            // 
            // pnlMasterCardBack
            // 
            this.pnlMasterCardBack.Controls.Add(this.lblMasterCardCVV);
            this.pnlMasterCardBack.Controls.Add(this.picMasterCardBack);
            this.pnlMasterCardBack.Location = new System.Drawing.Point(825, 425);
            this.pnlMasterCardBack.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMasterCardBack.Name = "pnlMasterCardBack";
            this.pnlMasterCardBack.Size = new System.Drawing.Size(300, 150);
            this.pnlMasterCardBack.TabIndex = 85;
            // 
            // lblMasterCardCVV
            // 
            this.lblMasterCardCVV.AutoSize = true;
            this.lblMasterCardCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblMasterCardCVV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterCardCVV.ForeColor = System.Drawing.Color.Beige;
            this.lblMasterCardCVV.Location = new System.Drawing.Point(200, 74);
            this.lblMasterCardCVV.Name = "lblMasterCardCVV";
            this.lblMasterCardCVV.Size = new System.Drawing.Size(34, 17);
            this.lblMasterCardCVV.TabIndex = 31;
            this.lblMasterCardCVV.Text = "CVV";
            // 
            // picMasterCardBack
            // 
            this.picMasterCardBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMasterCardBack.Image = global::FaultTrackingSystem.Properties.Resources.masterCardBack;
            this.picMasterCardBack.Location = new System.Drawing.Point(0, 0);
            this.picMasterCardBack.Margin = new System.Windows.Forms.Padding(0);
            this.picMasterCardBack.Name = "picMasterCardBack";
            this.picMasterCardBack.Size = new System.Drawing.Size(300, 150);
            this.picMasterCardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMasterCardBack.TabIndex = 25;
            this.picMasterCardBack.TabStop = false;
            // 
            // pnlVisaCardFront
            // 
            this.pnlVisaCardFront.Controls.Add(this.lblVisaCardNumber);
            this.pnlVisaCardFront.Controls.Add(this.lblVisaCardDate);
            this.pnlVisaCardFront.Controls.Add(this.lblVisaCardName);
            this.pnlVisaCardFront.Controls.Add(this.picVisaCardFront);
            this.pnlVisaCardFront.Location = new System.Drawing.Point(600, 0);
            this.pnlVisaCardFront.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVisaCardFront.Name = "pnlVisaCardFront";
            this.pnlVisaCardFront.Size = new System.Drawing.Size(300, 150);
            this.pnlVisaCardFront.TabIndex = 86;
            // 
            // lblVisaCardNumber
            // 
            this.lblVisaCardNumber.AutoSize = true;
            this.lblVisaCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(172)))), ((int)(((byte)(81)))));
            this.lblVisaCardNumber.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVisaCardNumber.Location = new System.Drawing.Point(3, 90);
            this.lblVisaCardNumber.Name = "lblVisaCardNumber";
            this.lblVisaCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVisaCardNumber.Size = new System.Drawing.Size(219, 25);
            this.lblVisaCardNumber.TabIndex = 41;
            this.lblVisaCardNumber.Text = "0000 0000 0000 0000";
            // 
            // lblVisaCardDate
            // 
            this.lblVisaCardDate.AutoSize = true;
            this.lblVisaCardDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(172)))), ((int)(((byte)(81)))));
            this.lblVisaCardDate.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisaCardDate.Location = new System.Drawing.Point(75, 58);
            this.lblVisaCardDate.Name = "lblVisaCardDate";
            this.lblVisaCardDate.Size = new System.Drawing.Size(52, 17);
            this.lblVisaCardDate.TabIndex = 40;
            this.lblVisaCardDate.Text = "AY/YIL";
            // 
            // lblVisaCardName
            // 
            this.lblVisaCardName.AutoSize = true;
            this.lblVisaCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(172)))), ((int)(((byte)(81)))));
            this.lblVisaCardName.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisaCardName.Location = new System.Drawing.Point(3, 124);
            this.lblVisaCardName.Name = "lblVisaCardName";
            this.lblVisaCardName.Size = new System.Drawing.Size(88, 15);
            this.lblVisaCardName.TabIndex = 39;
            this.lblVisaCardName.Text = "İSİM SOYİSİM";
            // 
            // picVisaCardFront
            // 
            this.picVisaCardFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVisaCardFront.Image = global::FaultTrackingSystem.Properties.Resources.visaCardFront;
            this.picVisaCardFront.Location = new System.Drawing.Point(0, 0);
            this.picVisaCardFront.Margin = new System.Windows.Forms.Padding(0);
            this.picVisaCardFront.Name = "picVisaCardFront";
            this.picVisaCardFront.Size = new System.Drawing.Size(300, 150);
            this.picVisaCardFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVisaCardFront.TabIndex = 31;
            this.picVisaCardFront.TabStop = false;
            // 
            // pnlVisaCardBack
            // 
            this.pnlVisaCardBack.Controls.Add(this.lblVisaCardCVV);
            this.pnlVisaCardBack.Controls.Add(this.picVisaCardBack);
            this.pnlVisaCardBack.Location = new System.Drawing.Point(900, 0);
            this.pnlVisaCardBack.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVisaCardBack.Name = "pnlVisaCardBack";
            this.pnlVisaCardBack.Size = new System.Drawing.Size(300, 150);
            this.pnlVisaCardBack.TabIndex = 87;
            // 
            // lblVisaCardCVV
            // 
            this.lblVisaCardCVV.AutoSize = true;
            this.lblVisaCardCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(153)))));
            this.lblVisaCardCVV.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisaCardCVV.Location = new System.Drawing.Point(153, 76);
            this.lblVisaCardCVV.Name = "lblVisaCardCVV";
            this.lblVisaCardCVV.Size = new System.Drawing.Size(34, 17);
            this.lblVisaCardCVV.TabIndex = 37;
            this.lblVisaCardCVV.Text = "CVV";
            // 
            // picVisaCardBack
            // 
            this.picVisaCardBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVisaCardBack.Image = global::FaultTrackingSystem.Properties.Resources.visaCardBack;
            this.picVisaCardBack.Location = new System.Drawing.Point(0, 0);
            this.picVisaCardBack.Margin = new System.Windows.Forms.Padding(0);
            this.picVisaCardBack.Name = "picVisaCardBack";
            this.picVisaCardBack.Size = new System.Drawing.Size(300, 150);
            this.picVisaCardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVisaCardBack.TabIndex = 32;
            this.picVisaCardBack.TabStop = false;
            // 
            // errPrice
            // 
            this.errPrice.ContainerControl = this;
            this.errPrice.Icon = ((System.Drawing.Icon)(resources.GetObject("errPrice.Icon")));
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            this.errName.Icon = ((System.Drawing.Icon)(resources.GetObject("errName.Icon")));
            // 
            // errCardNumber
            // 
            this.errCardNumber.ContainerControl = this;
            this.errCardNumber.Icon = ((System.Drawing.Icon)(resources.GetObject("errCardNumber.Icon")));
            // 
            // errMonth
            // 
            this.errMonth.ContainerControl = this;
            this.errMonth.Icon = ((System.Drawing.Icon)(resources.GetObject("errMonth.Icon")));
            // 
            // errYear
            // 
            this.errYear.ContainerControl = this;
            this.errYear.Icon = ((System.Drawing.Icon)(resources.GetObject("errYear.Icon")));
            // 
            // errCVV
            // 
            this.errCVV.ContainerControl = this;
            this.errCVV.Icon = ((System.Drawing.Icon)(resources.GetObject("errCVV.Icon")));
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlVisaCardBack);
            this.Controls.Add(this.pnlVisaCardFront);
            this.Controls.Add(this.pnlMasterCardBack);
            this.Controls.Add(this.pnlMasterCardFront);
            this.Controls.Add(this.mtxtCVV);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.picDate);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.pnlLineTotal);
            this.Controls.Add(this.cboCardType);
            this.Controls.Add(this.mtxtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.lblLineTotal);
            this.Controls.Add(this.picPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.picPromo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).EndInit();
            this.pnlLineTotal.ResumeLayout(false);
            this.pnlLineTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            this.pnlMasterCardFront.ResumeLayout(false);
            this.pnlMasterCardFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMasterCardFront)).EndInit();
            this.pnlMasterCardBack.ResumeLayout(false);
            this.pnlMasterCardBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMasterCardBack)).EndInit();
            this.pnlVisaCardFront.ResumeLayout(false);
            this.pnlVisaCardFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisaCardFront)).EndInit();
            this.pnlVisaCardBack.ResumeLayout(false);
            this.pnlVisaCardBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisaCardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPromo;
        private System.Windows.Forms.Panel pnlLineTotal;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.MaskedTextBox mtxtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.PictureBox picPayment;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.MaskedTextBox mtxtCVV;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlMasterCardFront;
        private System.Windows.Forms.Label lblMasterCardName;
        private System.Windows.Forms.Label lblMasterCardDate;
        private System.Windows.Forms.Label lblMasterCardNumber;
        private System.Windows.Forms.PictureBox picMasterCardFront;
        private System.Windows.Forms.Panel pnlMasterCardBack;
        private System.Windows.Forms.Label lblMasterCardCVV;
        private System.Windows.Forms.PictureBox picMasterCardBack;
        private System.Windows.Forms.Panel pnlVisaCardFront;
        private System.Windows.Forms.Label lblVisaCardNumber;
        private System.Windows.Forms.Label lblVisaCardDate;
        private System.Windows.Forms.Label lblVisaCardName;
        private System.Windows.Forms.PictureBox picVisaCardFront;
        private System.Windows.Forms.Panel pnlVisaCardBack;
        private System.Windows.Forms.Label lblVisaCardCVV;
        private System.Windows.Forms.PictureBox picVisaCardBack;
        private System.Windows.Forms.ErrorProvider errPrice;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errCardNumber;
        private System.Windows.Forms.ErrorProvider errMonth;
        private System.Windows.Forms.ErrorProvider errYear;
        private System.Windows.Forms.ErrorProvider errCVV;
    }
}