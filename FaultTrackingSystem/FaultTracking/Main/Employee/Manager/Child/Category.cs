using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Manager.Child
{
    public partial class Category : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;

        private int deviceId;
        private int deviceTypeId;
        private int brandId;

        private readonly DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

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
        public Category()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void Category_Load(object sender, EventArgs e)
        {
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 50, 50));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 50, 50));
            LoadTheme();

            btnSearch.Enabled = false;
            CategoryList();
            dataGrid.ClearSelection();
        }

        // listele
        private void CategoryList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "D.Id AS 'DeviceId'," +
                "DT.Id AS 'DeviceTypeId'," +
                "B.Id AS 'BrandId'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'" +
                "FROM Device AS D " +
                "INNER JOIN DeviceType AS DT ON D.Id = Dt.DeviceId " +
                "INNER JOIN Brand AS B ON B.DeviceTypeId = DT.Id " +
                "ORDER BY D.Name, DT.Name, B.Name";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
            };

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGrid.DataSource = dataTable;

            dataGrid.Columns["DeviceId"].Visible = false;
            dataGrid.Columns["DeviceTypeId"].Visible = false;
            dataGrid.Columns["BrandId"].Visible = false;

            CreateButtomColumn();

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
                txtDevice.Text = row.Cells["Cihaz"].Value.ToString();
                txtDeviceType.Text = row.Cells["Cihaz Türü"].Value.ToString();
                txtBrand.Text = row.Cells["Markası"].Value.ToString();
                deviceId = (int)row.Cells["DeviceId"].Value;
                deviceTypeId = (int)row.Cells["DeviceTypeId"].Value;
                brandId = (int)row.Cells["BrandId"].Value;
            }

            if (e.ColumnIndex == dataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = (int)dataGrid.Rows[e.RowIndex].Cells["BrandId"].Value;

                using (SqlConnection connection = new SqlConnection(connectionUrl))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM Brand WHERE Id = @Id", connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", id);
                        sqlCommand.ExecuteNonQuery();

                        sqlCommand.CommandText = "IF EXISTS (SELECT * FROM Brand WHERE DeviceTypeId = (SELECT TOP 1 Id FROM DeviceType WHERE Name = @DeviceTypeName)) SELECT 1 ELSE SELECT 0";
                        sqlCommand.Parameters.AddWithValue("@DeviceTypeName", txtDeviceType.Text.ToString().Trim());
                        int resultBrand = (int)sqlCommand.ExecuteScalar();

                        if (resultBrand == 0)
                        {
                            sqlCommand.CommandText = "DELETE FROM DeviceType WHERE Id = @DeviceTypeId";
                            sqlCommand.Parameters.AddWithValue("@DeviceTypeId", deviceTypeId);
                            sqlCommand.ExecuteNonQuery();

                            sqlCommand.CommandText = "IF EXISTS (SELECT * FROM DeviceType WHERE DeviceId = (SELECT Id FROM Device WHERE Name = @DeviceName)) SELECT 1 ELSE SELECT 0";
                            sqlCommand.Parameters.AddWithValue("@DeviceName", txtDevice.Text.ToString().Trim());
                            int resultDeviceType = (int)sqlCommand.ExecuteScalar();

                            if (resultDeviceType == 0)
                            {
                                sqlCommand.CommandText = "DELETE FROM Device WHERE Id = @DeviceId";
                                sqlCommand.Parameters.AddWithValue("@DeviceId", deviceId);
                                sqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                dataGrid.Columns.Remove(buttonColumn);
                CategoryList();
            }
        }

        // tablolara veri ekle
        private void AddList()
        {
            string deviceName = txtDevice.Text.Trim().ToUpper();
            string deviceTypeName = txtDeviceType.Text.Trim().ToUpper();
            string brandName = txtBrand.Text.Trim().ToUpper();
            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Device (Name) SELECT @DeviceName WHERE NOT EXISTS (SELECT * FROM Device WHERE Name = @DeviceName);INSERT INTO DeviceType (Name, DeviceId) SELECT @DeviceTypeName, Id FROM Device WHERE Name = @DeviceName AND NOT EXISTS (SELECT * FROM DeviceType WHERE Name = @DeviceTypeName AND DeviceId = (SELECT Id FROM Device WHERE Name = @DeviceName));INSERT INTO Brand (Name, DeviceTypeId) SELECT @BrandName, Id FROM DeviceType WHERE Name = @DeviceTypeName AND NOT EXISTS (SELECT * FROM Brand WHERE Name = @BrandName AND DeviceTypeId = (SELECT TOP 1 Id FROM DeviceType WHERE Name = @DeviceTypeName));", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@DeviceName", deviceName);
                    sqlCommand.Parameters.AddWithValue("@DeviceTypeName", deviceTypeName);
                    sqlCommand.Parameters.AddWithValue("@BrandName", brandName);
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // listeye kategori ekle
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDevice.Text))
            {
                errDevice.SetError(lblDevice, "Boş bırakılamaz");
                return;
            }

            if (string.IsNullOrEmpty(txtDeviceType.Text))
            {
                errDeviceType.SetError(lblDeviceType, "Boş bırakılamaz");
                return;
            }

            if (string.IsNullOrEmpty(txtBrand.Text))
            {
                errBrand.SetError(lblBrand, "Boş bırakılamaz");
                return;
            }

            AddList();
            dataGrid.Columns.Remove(buttonColumn);
            CategoryList();
        }

        // errorProvider temizle
        private void TxtDevice_TextChanged(object sender, EventArgs e)
        {
            errDevice.Clear();
        }

        // errorProvider temizle
        private void TxtDeviceType_TextChanged(object sender, EventArgs e)
        {
            errDeviceType.Clear();
        }

        // errorProvider temizle
        private void TxtBrand_TextChanged(object sender, EventArgs e)
        {
            errBrand.Clear();
        }

        // errorProvider temizle
        private void TxtDevice_Leave(object sender, EventArgs e)
        {
            errDevice.Clear();
        }

        // errorProvider temizle
        private void TxtDeviceType_Leave(object sender, EventArgs e)
        {
            errDeviceType.Clear();
        }

        // errorProvider temizle
        private void TxtBrand_Leave(object sender, EventArgs e)
        {
            errBrand.Clear();
        }

        // btnAdd animasyon
        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Font = new Font("Segoe UI Black", 14.5F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnAdd.TextAlign = ContentAlignment.TopCenter;
        }

        // btnAdd animasyon
        private void BtnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnUpdate animasyon
        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 14.5F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.TopCenter;
        }

        // btnUpdate animasyon
        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.MiddleCenter;
        }

        // tablolari guncelle
        private void UpdateList()
        {
            string deviceName = txtDevice.Text.Trim().ToUpper();
            string deviceTypeName = txtDeviceType.Text.Trim().ToUpper();
            string brandName = txtBrand.Text.Trim().ToUpper();

            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = connection;

                    // Device tablosunu guncelle
                    sqlCommand.CommandText = "UPDATE Device SET Name = @DeviceName WHERE Id = @DeviceId";
                    sqlCommand.Parameters.AddWithValue("@DeviceName", deviceName);
                    sqlCommand.Parameters.AddWithValue("@DeviceId", deviceId);
                    sqlCommand.ExecuteNonQuery();

                    // DeviceType tablosunu guncelle
                    sqlCommand.CommandText = "UPDATE DeviceType SET Name = @DeviceTypeName WHERE Id = @DeviceTypeId";
                    sqlCommand.Parameters.AddWithValue("@DeviceTypeName", deviceTypeName);
                    sqlCommand.Parameters.AddWithValue("@DeviceTypeId", deviceTypeId);
                    sqlCommand.ExecuteNonQuery();

                    // Brand tablosunu guncelle
                    sqlCommand.CommandText = "UPDATE Brand SET Name = @BrandName WHERE Id = @BrandId";
                    sqlCommand.Parameters.AddWithValue("@BrandName", brandName);
                    sqlCommand.Parameters.AddWithValue("@BrandId", brandId);
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // Listeyi guncelle
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
            dataGrid.Columns.Remove(buttonColumn);
            CategoryList();
        }

        // buton kolonu olustur
        private void CreateButtomColumn()
        {
            buttonColumn.HeaderText = "Cihaz Sil";
            buttonColumn.Name = "Delete";
            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            buttonColumn.Text = "Sil";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(buttonColumn);
        }

        // textboxta arama yap
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "D.Id AS 'DeviceId'," +
                "DT.Id AS 'DeviceTypeId'," +
                "B.Id AS 'BrandId'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'" +
                "FROM Device AS D " +
                "INNER JOIN DeviceType AS DT ON D.Id = Dt.DeviceId " +
                "INNER JOIN Brand AS B ON B.DeviceTypeId = DT.Id " +
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
