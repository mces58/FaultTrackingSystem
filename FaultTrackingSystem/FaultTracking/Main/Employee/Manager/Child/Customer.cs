using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Manager.Child
{
    public partial class Customer : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;

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
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dataGrid.ClearSelection();
            LoadTheme();
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));

            btnSearch.Enabled = false;
            CustomerList();
        }

        // musterileri listele
        private void CustomerList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT  " +
                "C.Id AS 'Id'," +
                "C.UserName AS 'Müşteri'," +
                "C.EmailAddress AS 'Email Adresi'," +
                "F.SerialNumber AS 'Cihaz Seri Numarası'," +
                "R.DeviceStatus AS 'Cihaz Durumu'," +
                "R.Description AS 'Yapılan İşlemler'," +
                "CI.Name AS 'İl'," +
                "D.Name AS 'İlçe'," +
                "F.OpenAddress AS 'Açık Adres'," +
                "I.Paid AS 'Ödenen Tutar'," +
                "I.InvoiceDate AS 'Ödeme Tarihi' " +
                "FROM Customer AS C " +
                "INNER JOIN Fault AS F ON F.CustomerId = C.Id " +
                "INNER JOIN Repair AS R ON R.FaultId = F.Id " +
                "INNER JOIN District AS D ON D.Id = F.DistrictId " +
                "INNER JOIN City AS CI ON CI.Id = D.CityId " +
                "INNER JOIN Invoice AS I ON C.Id = I.CustomerId";

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
            dataGrid.Columns["Cihaz Durumu"].Visible = false;
            dataGrid.Columns["Yapılan İşlemler"].Visible = false;
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
                txtDeviceStatus.Text = row.Cells["Cihaz Durumu"].Value.ToString();
                rtxtDeviceDescription.Text = row.Cells["Yapılan İşlemler"].Value.ToString();
                txtCity.Text = row.Cells["İl"].Value.ToString();
                txtDistrict.Text = row.Cells["İlçe"].Value.ToString();
                rtxtOpenAddress.Text = row.Cells["Açık Adres"].Value.ToString();
                txtPrice.Text = row.Cells["Ödenen Tutar"].Value.ToString() + " TL";
            }
        }

        // data grid de filtre uygula 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT  " +
                "C.Id AS 'Id'," +
                "C.UserName AS 'Müşteri'," +
                "C.EmailAddress AS 'Email Adresi'," +
                "F.SerialNumber AS 'Cihaz Seri Numarası'," +
                "R.DeviceStatus AS 'Cihaz Durumu'," +
                "R.Description AS 'Yapılan İşlemler'," +
                "CI.Name AS 'İl'," +
                "D.Name AS 'İlçe'," +
                "F.OpenAddress AS 'Açık Adres'," +
                "I.Paid AS 'Ödenen Tutar'," +
                "I.InvoiceDate AS 'Ödeme Tarihi' " +
                "FROM Customer AS C " +
                "INNER JOIN Fault AS F ON F.CustomerId = C.Id " +
                "INNER JOIN Repair AS R ON R.FaultId = F.Id " +
                "INNER JOIN District AS D ON D.Id = F.DistrictId " +
                "INNER JOIN City AS CI ON CI.Id = D.CityId " +
                "INNER JOIN Invoice AS I ON C.Id = I.CustomerId "+
                "WHERE " +
                "F.SerialNumber LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "CI.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "C.UserName LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "C.EmailAddress LIKE '" + txtSearch.Text.ToString() + "%'";

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
