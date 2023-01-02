using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Staff.Child
{
    public partial class GroupingDevice : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        private int faultId;

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

        // rengi uygula
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
        public GroupingDevice()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void GroupingDevice_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGrid.ClearSelection();
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 50, 50));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));

            btnSearch.Enabled = false;
            GroupingDeviceList();
        }

        // cihazlanacak verileri cek
        private void GroupingDeviceList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "D.Id AS 'Cihaz Id'," +
                "F.Id AS 'Id'," +
                "F.SerialNumber AS 'Seri Numarası'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'," +
                "F.Title AS 'Konu Başlığı'," +
                "F.Description AS 'Açıklama'," +
                "F.ReportedAt AS 'Bildirim Tarihi' " +
                "FROM Fault AS F " +
                "INNER JOIN Customer AS C ON C.Id = F.Id " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
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
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[6].Visible = false;
            dataGrid.Columns[7].Visible = false;

            CreateCombobox();

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // combobox sutununu olustur
        private void CreateCombobox()
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            dataGrid.Columns.Add(comboBoxColumn);

            comboBoxColumn.HeaderText = "Teknisyen Ata";
            comboBoxColumn.Name = "AddTechnician";
            comboBoxColumn.MaxDropDownItems = 3;
            comboBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            comboBoxColumn.DefaultCellStyle = cellStyle;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.ReadOnly = false;
            dataGrid.Columns[0].ReadOnly = true;
            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[2].ReadOnly = true;
            dataGrid.Columns[3].ReadOnly = true;
            dataGrid.Columns[4].ReadOnly = true;
            dataGrid.Columns[5].ReadOnly = true;
            dataGrid.Columns[8].ReadOnly = true;

            // combobox yazdir
            comboBoxColumn.DataSource = TechnicianList();
        }

        // calisanlarin listesini donder
        private ArrayList TechnicianList()
        {
            string query = "SELECT * FROM Technician";

            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            ArrayList arrayList = new ArrayList();

            foreach (DataRow item in dataTable.Rows)
            {
                arrayList.Add(item["Code"].ToString());
            }

            return arrayList;
        }

        // combobox da ki veri degisirse
        private void DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string code = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                IsFault(code, faultId);
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
                faultId = (int)row.Cells["Id"].Value;
               
            }
        }

        // calisanin id degerini donder
        private int TechnicianId(string code)
        {
            int workerId;
            string query = "SELECT * FROM Technician WHERE Code = @Code";
            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Code", code);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            workerId = (int)dataReader["Id"];

            dataReader.Close();
            connection.Close();

            return workerId;
        }

        // arizaya atanan calisani guncelle
        private void Update(string code, int faultId)
        {
            int workerId = TechnicianId(code);
            string update = "UPDATE Assignment SET TechnicianId = @TechnicianId WHERE FaultId = @FaultId";
            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand(update, connection);
            sqlCommand.Parameters.AddWithValue("@TechnicianId", workerId);
            sqlCommand.Parameters.AddWithValue("@FaultId", faultId);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        // arizaya calisan ata
        private void Insert(string code, int faultId)
        {
            int workerId = TechnicianId(code);
            string insert = "INSERT INTO Assignment(TechnicianId, FaultId, AssignedAt) values(@TechnicianId, @FaultId, GETDATE())";
            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand(insert, connection);
            sqlCommand.Parameters.AddWithValue("@TechnicianId", workerId);
            sqlCommand.Parameters.AddWithValue("@FaultId", faultId);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            sqlCommand = new SqlCommand("SELECT Id FROM Assignment WHERE FaultId = " + faultId + "", connection);
            connection.Open();
            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            int assignmentId = (int)dataReader["Id"];
            connection.Close();

            InsertRepairTable(faultId, assignmentId);
        }

        // daha onceden arizali cihaz var mi kontrol et
        private void IsFault(string code, int faultId)
        {
            string isFaultExist = "SELECT * FROM Assignment WHERE FaultId = @FaultId";
            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand(isFaultExist, connection);
            sqlCommand.Parameters.AddWithValue("@FaultId", faultId);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();

            if (dataReader.Read())
            {
                Update(code, faultId);
            }
            else
            {
                Insert(code, faultId);
            }

            connection.Close();

            connection = new SqlConnection(connectionUrl);
            sqlCommand = new SqlCommand("UPDATE Fault SET IsGrouped = 'E' WHERE Id = @Id", connection);
            sqlCommand.Parameters.AddWithValue("@Id", faultId);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        // repair tablosuna veri ekle
        private void InsertRepairTable(int faultId, int assignmentId)
        {
            connection = new SqlConnection(connectionUrl);
            string queryInto = "INSERT INTO Repair(FaultId, AssignmentId, RepairDate, Title, Description, DeviceStatus)";
            string queryValues = "VALUES(@FaultId, @AssignmentId, GETDATE(), '', '', 'Tamir Sürecinde') SELECT CAST(scope_identity() AS INT)";
            sqlCommand = new SqlCommand(queryInto + queryValues, connection);
            sqlCommand.Parameters.AddWithValue("@FaultId", faultId);
            sqlCommand.Parameters.AddWithValue("@AssignmentId", assignmentId);

            connection.Open();
            _ = (int)sqlCommand.ExecuteScalar();
            connection.Close();
        }

        // data grid de filtre uygula 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "D.Id AS 'Cihaz Id'," +
                "F.Id AS 'Id'," +
                "F.SerialNumber AS 'Seri Numarası'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'," +
                "F.Title AS 'Konu Başlığı'," +
                "F.Description AS 'Açıklama'," +
                "F.ReportedAt AS 'Bildirim Tarihi' " +
                "FROM Fault AS F " +
                "INNER JOIN Customer AS C ON C.Id = F.Id " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
                "INNER JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "INNER JOIN Device AS D ON D.Id = DT.DeviceId " +
                "INNER JOIN District AS DI ON DI.Id = F.DistrictId " +
                "INNER JOIN City AS CI ON CI.Id = DI.CityId " +
                "WHERE " +
                "F.IsPay = 'H'" +
                "AND " +
                "(F.SerialNumber LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "DT.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "B.Name LIKE '" + txtSearch.Text.ToString() + "%')";

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
