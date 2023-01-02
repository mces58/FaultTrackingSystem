using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Staff.Child
{
    public partial class FaultList : Form
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
        public FaultList()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void FaultList_Load(object sender, EventArgs e)
        {
            dataGrid.ClearSelection();
            LoadTheme();
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 50, 50));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));

            FaultDeviceList();
            btnSearch.Enabled = false;
        }

        // arizali cihazlarin veritabanindan cekilmesi
        private void FaultDeviceList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "F.Id AS 'Id'," +
                "F.SerialNumber AS 'Seri Numarası'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü', " +
                "B.Name AS 'Markası', " +
                "F.Title AS 'Konu Başlığı', " +
                "F.Description AS 'Açıklama'," +
                "F.ReportedAt AS 'Bildirim Tarihi'," +
                "F.DeviceImage AS 'Cihazın Fotoğrafı', " +
                "CI.Name AS 'İl'," +
                "DI.Name AS 'İlçe', " +
                "F.OpenAddress AS 'Açık Adres' " +
                "FROM Fault AS F " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
                "INNER JOIN Customer AS C ON C.Id = F.CustomerId " +
                "INNER JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "INNER JOIN Device AS D ON D.Id = DT.DeviceId " +
                "INNER JOIN District AS DI ON DI.Id = F.DistrictId " +
                "INNER JOIN City AS CI ON CI.Id = DI.CityId " +
                "WHERE " +
                "F.IsPay = 'H'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
            };

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGrid.DataSource = dataTable;
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[5].Visible = false;
            dataGrid.Columns[6].Visible = false;
            dataGrid.Columns[8].Visible = false;
            dataGrid.Columns[9].Visible = false;
            dataGrid.Columns[10].Visible = false;
            dataGrid.Columns[11].Visible = false;

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // data gridde bir hucreye tiklanirsa
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || dataGrid.SelectedCells.Count == dataGrid.Rows.Count * dataGrid.Columns.Count)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                rtxtDeviceTitle.Text = row.Cells["Konu Başlığı"].Value.ToString();
                rtxtDeviceDescription.Text = row.Cells["Açıklama"].Value.ToString();
                txtCity.Text = row.Cells["İl"].Value.ToString();
                txtDistrict.Text = row.Cells["İlçe"].Value.ToString();
                rtxtOpenAddress.Text = row.Cells["Açık Adres"].Value.ToString();

                byte[] imageBytes = (byte[])row.Cells["Cihazın Fotoğrafı"].Value;
                MemoryStream stream = new MemoryStream(imageBytes);
                Image image = Image.FromStream(stream);
                picDeviceImage.Image = image;
                picDeviceImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // data grid de filtre uygula 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "F.Id AS 'Id'," +
                "F.SerialNumber AS 'Seri Numarası'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü', " +
                "B.Name AS 'Markası', " +
                "F.Title AS 'Konu Başlığı', " +
                "F.Description AS 'Açıklama'," +
                "F.ReportedAt AS 'Bildirim Tarihi'," +
                "F.DeviceImage AS 'Cihazın Fotoğrafı', " +
                "CI.Name AS 'İl'," +
                "DI.Name AS 'İlçe', " +
                "F.OpenAddress AS 'Açık Adres' " +
                "FROM Fault AS F " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
                "INNER JOIN Customer AS C ON C.Id = F.CustomerId " +
                "INNER JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "INNER JOIN Device AS D ON D.Id = DT.DeviceId " +
                "INNER JOIN District AS DI ON DI.Id = F.DistrictId " +
                "INNER JOIN City AS CI ON CI.Id = DI.CityId " +
                "WHERE " +
                "F.IsPay = 'H'"+
                "AND " +
                "(F.SerialNumber LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "DT.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "B.Name LIKE '" + txtSearch.Text.ToString() + "%') ";

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
