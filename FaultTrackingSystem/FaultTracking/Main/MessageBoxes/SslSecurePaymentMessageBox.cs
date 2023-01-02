using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.MessageBoxes
{
    public partial class SslSecurePaymentMessageBox : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        // border-radius -- kenarliklari yumusat
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

        // background shadow -- forma arkaplan golgesi
        private const int CS_DropShadow = 0x24488;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        // constructor
        public SslSecurePaymentMessageBox()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void SslSecurePaymentMessageBox_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            btnApprove.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnApprove.Width, btnApprove.Height, 50, 50));
            btnOk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOk.Width, btnOk.Height, 50, 50));
            btnOk.Visible = false;

            tmrLoad.Start();
        }

        // btnOk alanina girilirse renk ve font degissin
        private void BtnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(89, 150, 25);
            btnOk.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnOk.TextAlign = ContentAlignment.TopCenter;
        }

        // btnOk alanindan cikilirsa font ve renk eski ayarlarina donsun
        private void BtnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(243, 116, 60);
            btnOk.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnOk.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnApprove alanina girilirse renk ve font degissin
        private void BtnApprove_MouseEnter(object sender, EventArgs e)
        {
            btnApprove.BackColor = Color.FromArgb(89, 150, 25);
            btnApprove.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnApprove.TextAlign = ContentAlignment.TopCenter;
        }

        // btnApprove alanindan cikilirsa font ve renk eski ayarlarina donsun
        private void BtnApprove_MouseLeave(object sender, EventArgs e)
        {
            btnApprove.BackColor = Color.FromArgb(243, 116, 60);
            btnApprove.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnApprove.TextAlign = ContentAlignment.MiddleCenter;
        }

        // errProvider temizle
        private void MtxtSecureCode_KeyUp(object sender, KeyEventArgs e)
        {
            errSecureCode.Clear();
        }

        // errProvider temizle
        private void MtxtSecureCode_Leave(object sender, EventArgs e)
        {
            errSecureCode.Clear();
        }

        // id degerine gore musteriyi yakala
        private int CustomerId()
        {
            int customerId;
            connection = new SqlConnection(connectionUrl);
            connection.Open();
            string query = "SELECT * FROM Customer WHERE UserName = '" + Customer.Parent.Login.globalUserName + "'";
            sqlCommand = new SqlCommand(query, connection);
            dataReader = sqlCommand.ExecuteReader();

            dataReader.Read();
            customerId = Convert.ToInt32(dataReader["Id"].ToString());
            connection.Close();

            return customerId;
        }

        // onayla tiklanirsa
        private void BtnApprove_Click(object sender, EventArgs e)
        {
            string code = "123 123";

            if (!mtxtSecureCode.MaskFull)
            {
                errSecureCode.SetError(lblSecureCode, "Boş bırakılamaz");
                mtxtSecureCode.Focus();
                return;
            }

            else if (!code.Equals(mtxtSecureCode.Text))
            {
                errSecureCode.SetError(lblSecureCode, "Hatalı kod");
                mtxtSecureCode.Focus();
                mtxtSecureCode.Clear();
                return;
            }

            try
            {
                InsertInvoice();
                UpdateCompletedRepair();

                int faultId = Customer.Child.Detail.faultId;
                connection = new SqlConnection(connectionUrl);
                sqlCommand = new SqlCommand("UPDATE Fault SET IsPay = 'E' WHERE Id = @Id", connection);
                sqlCommand.Parameters.AddWithValue("@Id", faultId);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();

                lblSecureCode.Text = "Ödemeniz alınmıştır";
                lblSecureCode.Location = new Point(150, 140);
                mtxtSecureCode.Visible = false;
                btnApprove.Visible = false;
                btnOk.Location = new Point(135, 190);
                btnOk.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // tabloya odenen veriyi ekle
        private void InsertInvoice()
        {
            int userId = CustomerId();
            int repairId = Customer.Child.Detail.repairId;

            connection = new SqlConnection(connectionUrl);
            string query = "INSERT INTO Invoice(CustomerId, RepairId, InvoiceDate, Paid) VALUES(@CustomerId, @RepairId, GETDATE(), @Paid)";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@CustomerId", userId);
            sqlCommand.Parameters.AddWithValue("@RepairId", repairId);
            sqlCommand.Parameters.AddWithValue("@Paid", Customer.Child.Payment.paid);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        // completedRepair tablosunu guncelle
        private void UpdateCompletedRepair()
        {
            int repairId = Customer.Child.Detail.repairId;

            connection = new SqlConnection(connectionUrl);
            string query = "UPDATE Repair SET TotalPrice = 0, DeviceStatus = 'Kargoya Teslim' WHERE Id = @Id";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Id", repairId);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        // tamam tiklanirsa
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // sayfasinin yuklenmesi
        private void TmrLoad_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                tmrLoad.Stop();
            }

            Opacity += 0.1;
        }
    }
}
