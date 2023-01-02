using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    public partial class Payment : Form
    {
        public static int paid;
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // border-radius
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
        public Payment()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void Payment_Load(object sender, EventArgs e)
        {
            LoadTheme();
            picMasterCardFront.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picMasterCardFront.Width, picMasterCardFront.Height, 20, 20));
            picMasterCardBack.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picMasterCardBack.Width, picMasterCardBack.Height, 20, 20));
            picVisaCardFront.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picVisaCardFront.Width, picVisaCardFront.Height, 20, 20));
            picVisaCardBack.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picVisaCardBack.Width, picVisaCardBack.Height, 20, 20));
            btnPayment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPayment.Width, btnPayment.Height, 50, 50));
            lblVisaCardNumber.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblVisaCardNumber.Width, lblVisaCardNumber.Height, 30, 30));

            pnlVisaCardFront.Visible = false;
            pnlVisaCardBack.Visible = false;

            AddYearMonth();
            AddItemCreditCardType();
            Pay();

            paid = Convert.ToInt32(lblPrice.Text);
        }

        // ay ve yillari ekle
        private void AddYearMonth()
        {
            int year;
            int month;

            for (month = 1; month < 13; month++)
            {
                if (month < 10)
                {
                    cboMonth.Items.Add("0" + month);
                    continue;
                }
                cboMonth.Items.Add(month);
            }
            for (year = 22; year < 30; year++)
            {
                cboYear.Items.Add(year);
            }

            cboMonth.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
        }

        // kart turunu degistirme
        private void CardType()
        {
            if (cboCardType.Text != "MASTERCARD")
            {
                pnlMasterCardFront.Visible = false;
                pnlMasterCardBack.Visible = false;

                pnlVisaCardFront.Visible = true;
                pnlVisaCardBack.Visible = true;
                pnlVisaCardFront.Location = new Point(825, 150);
                pnlVisaCardBack.Location = new Point(825, 425);
            }
            else
            {
                pnlMasterCardFront.Visible = true;
                pnlMasterCardBack.Visible = true;

                pnlVisaCardFront.Visible = false;
                pnlVisaCardBack.Visible = false;
            }
        }

        // cboCardType panel kapandiginda kart turunu degistir fonksiyonunu calistir
        private void CboCardType_DropDownClosed(object sender, EventArgs e)
        {
            CardType();
        }

        // errorProvider temizle
        private void TxtName_Leave(object sender, EventArgs e)
        {
            errName.Clear();
        }

        // errProvider temizle
        private void CboMonth_DropDown(object sender, EventArgs e)
        {
            errMonth.Clear();
        }

        // errProvider temizle
        private void CboYear_DropDown(object sender, EventArgs e)
        {
            errYear.Clear();
        }

        // kartlara ismi gir
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            lblMasterCardName.Text = txtName.Text.ToUpper();
            lblVisaCardName.Text = txtName.Text.ToUpper();
            errName.Clear();
        }

        // kartlara kart numarasini gir 
        private void MtxtCardNumber_KeyUp(object sender, KeyEventArgs e)
        {
            lblMasterCardNumber.Text = mtxtCardNumber.Text;
            lblVisaCardNumber.Text = mtxtCardNumber.Text;
            errCardNumber.Clear();
        }

        // karlara aylari gir
        private void CboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMasterCardDate.Text = cboMonth.Text + "/" + cboYear.Text;
            lblVisaCardDate.Text = cboMonth.Text + "/" + cboYear.Text;
        }

        // kartlara yillari gir
        private void CboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMasterCardDate.Text = cboMonth.Text + "/" + cboYear.Text;
            lblVisaCardDate.Text = cboMonth.Text + "/" + cboYear.Text;
        }

        // kartlara cvv degerlerini gir
        private void MtxtCVV_KeyUp(object sender, KeyEventArgs e)
        {
            lblMasterCardCVV.Text = mtxtCVV.Text;
            lblVisaCardCVV.Text = mtxtCVV.Text;
            errCVV.Clear();
        }

        // cihaz turlerini veri tabanindan cekip combobox yazma
        private void AddItemCreditCardType()
        {
            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM CreditCardType ORDER BY Id";
            sqlCommand = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cboCardType.ValueMember = "Id";
            cboCardType.DataSource = dataTable;
            cboCardType.DisplayMember = "Name";

            connection.Close();
        }

        // btnPayment animasyon
        private void BtnPayment_MouseEnter(object sender, EventArgs e)
        {
            btnPayment.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnPayment.TextAlign = ContentAlignment.TopCenter;
        }

        // btnPayment animasyon
        private void BtnPayment_MouseLeave(object sender, EventArgs e)
        {
            btnPayment.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnPayment.TextAlign = ContentAlignment.MiddleCenter;
        }

        // id degerine gore musteriyi yakala
        private int CustomerId()
        {
            int customerId;
            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM Customer WHERE UserName = @UserName";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@UserName", Customer.Parent.Login.globalUserName);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            customerId = Convert.ToInt32(dataReader["Id"].ToString());

            connection.Close();

            return customerId;
        }

        // odenmesi gereken miktari dondur
        private float Pay()
        {
            int pay;
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "R.TotalPrice AS 'Ücreti' " +
                "FROM Repair AS R " +
                "INNER JOIN Fault AS F ON F.Id = R.FaultId " +
                "INNER JOIN Customer AS C ON C.Id = F.CustomerId " +
                "WHERE C.Id = " + CustomerId() + " AND R.Id = " + Detail.repairId + "";

            sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            dataReader = sqlCommand.ExecuteReader();

            dataReader.Read();
            lblPrice.Text = dataReader["Ücreti"].ToString();
            pay = Convert.ToInt32(dataReader["Ücreti"]);
            connection.Close();

            return pay;
        }

        // degerleri sifirla
        private void Reset()
        {
            lblPrice.Text = Pay().ToString();
            txtName.Clear();
            mtxtCardNumber.Clear();
            cboMonth.SelectedIndex = 0;
            cboYear.SelectedIndex = 0;
            mtxtCVV.Clear();

            lblVisaCardNumber.Text = "0000 0000 0000 0000";
            lblVisaCardName.Text = "İSİM SOYİSİM";
            lblVisaCardDate.Text = "AY/YIL";
            lblVisaCardCVV.Text = "CVV";

            lblMasterCardNumber.Text = "0000 0000 0000 0000";
            lblMasterCardName.Text = "İSİM SOYİSİM";
            lblMasterCardDate.Text = "AY/YIL";
            lblMasterCardCVV.Text = "CVV";
        }

        // btnPayment butonuna tiklanirsa
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            if (Pay() == 0)
            {
                new MessageBoxes.NoPaymentMessageBox().ShowDialog();
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                txtName.Focus();
                errName.SetError(lblName, "Boş bırakılamaz");
                return;
            }

            else if (!mtxtCardNumber.MaskFull)
            {

                mtxtCardNumber.Focus();
                errCardNumber.SetError(lblCardNumber, "Boş bırakılamaz");
                return;
            }

            else if (!mtxtCVV.MaskFull)
            {
                errCVV.SetError(lblCVV, "Boş bırakılamaz");
                mtxtCVV.Focus();
                return;
            }

            new MessageBoxes.SslSecurePaymentMessageBox().ShowDialog();
            Reset();
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
