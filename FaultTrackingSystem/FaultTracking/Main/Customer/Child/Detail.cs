using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    public partial class Detail : Form
    {
        public static int repairId;
        public static int faultId;

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

        // rengin uygulanmasi
        private void LoadTheme()
        {
            foreach (Control btns in pnlDesktop.Controls)
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
        public Detail()
        {
            InitializeComponent();
            FaultDeviceDetailList();
        }

        // form yuklenirken
        private void Detail_Load(object sender, EventArgs e)
        {
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            btnPay.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPay.Width, btnPay.Height, 50, 50));
            LoadTheme();
            dataGrid.ClearSelection();
            Message();

            btnSearch.Enabled = false;

            
        }

        // data gridde satir var mi kontrol et yoksa form elemanlarini gosterme
        private void Message()
        {
            int rows = dataGrid.Rows.Count;

            if (rows == 0)
            {
                lblMessage.Visible = true;
                dataGrid.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Visible = false;
                lblDeviceStatus.Visible = false;
                txtDeviceStatus.Visible = false;
                lblPrice.Visible = false;
                txtPrice.Visible = false;
                lblDeviceDescription.Visible = false;
                rtxtDeviceDescription.Visible = false;
                lblAddress.Visible = false;
                txtCity.Visible = false;
                txtDistrict.Visible = false;
                rtxtOpenAddress.Visible = false;
                btnPay.Visible = false;
                lblPriceMessage.Visible = false;
            }
            else
            {
                lblMessage.Visible = false;
                dataGrid.Visible = true;
                txtSearch.Visible = true;
                btnSearch.Visible = true;
                lblDeviceStatus.Visible = true;
                txtDeviceStatus.Visible = true;
                lblPrice.Visible = true;
                txtPrice.Visible = true;
                lblDeviceDescription.Visible = true;
                rtxtDeviceDescription.Visible = true;
                lblAddress.Visible = true;
                txtCity.Visible = true;
                txtDistrict.Visible = true;
                rtxtOpenAddress.Visible = true;
                btnPay.Visible = true;
                lblPriceMessage.Visible = false;
            }
        }

        // animasyon ekle
        private void BtnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
        }

        // animasyon kaldir
        private void BtnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnPay.TextAlign = ContentAlignment.MiddleCenter;
        }

        // customer id degerini yakala
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

        // musteriye arizali cihazlarinin listesini goster
        private void FaultDeviceDetailList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "R.Id AS 'Id'," +
                "F.Id AS 'ArızaId'," +
                "C.UserName AS 'Kullanıcı Adı'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'," +
                "R.DeviceStatus AS 'Cihazın Durumu'," +
                "R.Title AS 'Cihazın Başlığı'," +
                "R.Description AS 'Yapılan İşlemler'," +
                "R.TotalPrice AS 'Ücreti'," +
                "R.RepairDate AS 'İşlem Tarihi'," +
                "CI.Name AS 'İl'," +
                "DI.Name AS 'İlçe'," +
                "F.OpenAddress AS 'Açık Adres'" +
                "FROM Repair AS R " +
                "LEFT JOIN Fault AS F ON F.Id = R.FaultId " +
                "LEFT JOIN Brand AS B ON B.Id = F.BrandId " +
                "LEFT JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "LEFT JOIN Device AS D ON D.Id = DT.DeviceId " +
                "LEFT JOIN Customer AS C ON C.Id = F.CustomerId " +
                "LEFT JOIN District AS DI ON DI.Id = F.DistrictId " +
                "LEFT JOIN City AS CI ON CI.Id = DI.CityId " +
                "WHERE C.Id = " + CustomerId() + "";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
            };

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGrid.DataSource = dataTable;
            dataGrid.Columns["Id"].Visible = false;
            dataGrid.Columns["ArızaId"].Visible = false;
            dataGrid.Columns["Cihazın Durumu"].Visible = false;
            dataGrid.Columns["Cihazın Başlığı"].Visible = false;
            dataGrid.Columns["Yapılan İşlemler"].Visible = false;
            dataGrid.Columns["Ücreti"].Visible = false;
            dataGrid.Columns["İl"].Visible = false;
            dataGrid.Columns["İlçe"].Visible = false;
            dataGrid.Columns["Açık Adres"].Visible = false;

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }
            
            else
            {
                dataGrid.Enabled = true;
            }
        }

        // data gridde hucreye tiklanirsa
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || dataGrid.SelectedCells.Count == dataGrid.Rows.Count * dataGrid.Columns.Count)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                txtDeviceStatus.Text = row.Cells["Cihazın Durumu"].Value.ToString();
                rtxtDeviceDescription.Text = row.Cells["Yapılan İşlemler"].Value.ToString();
                txtCity.Text = row.Cells["İl"].Value.ToString();
                txtDistrict.Text = row.Cells["İlçe"].Value.ToString();
                rtxtOpenAddress.Text = row.Cells["Açık Adres"].Value.ToString();
                txtPrice.Text = row.Cells["Ücreti"].Value.ToString() + " TL";
                repairId = (int)row.Cells["Id"].Value;
                faultId = (int)row.Cells["ArızaId"].Value;

                if (txtPrice.Text != "0 TL")
                {
                    lblPriceMessage.Visible = true;
                }

                else
                {
                    lblPriceMessage.Visible = false;
                }
            }
        }

        // odeme islemine git
        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != "0 TL" && dataGrid.SelectedCells.Count > 0)
            {
                pnlDesktop.Visible = false;
                btnPay.Visible = false;
                Payment payment = new Payment
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                payment.BringToFront();
                payment.Show();
                this.Controls.Add(payment);
            }
        }

        // textboxta arama yap
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "R.Id AS 'Id'," +
                "F.Id AS 'ArızaId'," +
                "C.UserName AS 'Kullanıcı Adı'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'," +
                "R.DeviceStatus AS 'Cihazın Durumu'," +
                "R.Title AS 'Cihazın Başlığı'," +
                "R.Description AS 'Yapılan İşlemler'," +
                "R.TotalPrice AS 'Ücreti'," +
                "R.RepairDate AS 'İşlem Tarihi'," +
                "CI.Name AS 'İl'," +
                "DI.Name AS 'İlçe'," +
                "F.OpenAddress AS 'Açık Adres'" +
                "FROM Repair AS R " +
                "INNER JOIN Fault AS F ON F.Id = R.FaultId " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
                "INNER JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "INNER JOIN Device AS D ON D.Id = DT.DeviceId " +
                "INNER JOIN Customer AS C ON C.Id = F.CustomerId " +
                "INNER JOIN District AS DI ON DI.Id = F.DistrictId " +
                "INNER JOIN City AS CI ON CI.Id = DI.CityId " +
                "WHERE " +
                "(D.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "DT.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "B.Name LIKE '" + txtSearch.Text.ToString() + "%') " +
                "ORDER BY D.Name, DT.Name, B.Name";

            connection.Open();
            sqlCommand = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
            dataGrid.ClearSelection();

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // buton disable hale geldikten sonra yazi rengini degistir
        private void BtnSearch_Paint(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            using (var drawbrush = new SolidBrush(btn.ForeColor))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                btnSearch.Text = string.Empty;
                e.Graphics.DrawString("Ara", btn.Font, drawbrush, e.ClipRectangle, sf);
            }
        }

        // yazi rengini degistir
        private void BtnSearch_EnabledChanged(object sender, EventArgs e)
        {
            btnSearch.ForeColor = Color.Beige;
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
