using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Technician.Child
{
    public partial class UpdateDevice : Form
    {
        private bool isChecked;
        private int repairId;

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
        public UpdateDevice()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void UpdateDevice_Load(object sender, EventArgs e)
        {
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 50, 50));
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 50, 50));

            dataGrid.ClearSelection();
            LoadTheme();

            btnSearch.Enabled = false;

            UpdateDeviceList();
        }

        // animasyon ekle
        private void BtnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 15.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.TopCenter;
        }

        // animasyon kaldir
        private void BtnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUpdate.TextAlign = ContentAlignment.MiddleCenter;
        }

        // errProviver temizle
        private void RtxtDeviceTitle_TextChanged(object sender, EventArgs e)
        {
            errDeviceTitle.Clear();
        }

        // errProviver temizle
        private void RtxtDeviceTitle_Leave(object sender, EventArgs e)
        {
            errDeviceTitle.Clear();
        }

        // errProvider temizle
        private void RtxtDeviceDescription_TextChanged(object sender, EventArgs e)
        {
            errDeviceDescription.Clear();
        }

        // errProvider temizle
        private void RtxtDeviceDescription_Leave(object sender, EventArgs e)
        {
            errDeviceDescription.Clear();
        }

        // guncellenecek verileri listele
        private void UpdateDeviceList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "A.Id AS 'Id'," +
                "R.Id AS 'Onarım Id'," +
                "A.FaultId AS 'Cihaz Id'," +
                "F.SerialNumber AS 'Seri Numarası'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'," +
                "T.Code AS 'Çalışan Kodu'," +
                "F.Title AS 'Başlık', " +
                "F.Description AS 'Açıklama'" +
                "FROM Repair AS R " +
                "INNER JOIN Assignment AS A ON A.Id = R.AssignmentId " +
                "INNER JOIN Fault AS F ON F.Id = R.FaultId " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
                "INNER JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "INNER JOIN Device AS D ON D.Id = DT.DeviceId " +
                "INNER JOIN Customer AS C ON C.Id = F.CustomerId " +
                "INNER JOIN Technician AS T ON T.Id = A.TechnicianId " +
                "WHERE " +
                "F.IsGrouped = 'E' AND F.IsPay = 'H'";

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
            dataGrid.Columns["Onarım Id"].Visible = false;
            dataGrid.Columns["Cihaz Id"].Visible = false;
            dataGrid.Columns["Başlık"].Visible = false;
            dataGrid.Columns["Açıklama"].Visible = false;

            CreateCheckBox();

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // checkbox sutunu olustur
        private void CreateCheckBox()
        {
            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            dataGrid.Columns.Add(checkBox);

            checkBox.Name = "chkUpdate";
            checkBox.HeaderText = "Güncelle";
            checkBox.Width = 80;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.ReadOnly = false;
            dataGrid.Columns[0].ReadOnly = true;
            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[2].ReadOnly = true;
            dataGrid.Columns[3].ReadOnly = true;
            dataGrid.Columns[4].ReadOnly = true;
            dataGrid.Columns[5].ReadOnly = true;
            dataGrid.Columns[6].ReadOnly = true;
            dataGrid.Columns[7].ReadOnly = true;
            dataGrid.Columns[8].ReadOnly = true;
            dataGrid.Columns[9].ReadOnly = true;
        }

        // listede hucreye tiklanirsa
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 || dataGrid.SelectedCells.Count == dataGrid.Rows.Count * dataGrid.Columns.Count)
            {
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                repairId = (int)row.Cells["Onarım Id"].Value;
                txtTitle.Text = row.Cells["Başlık"].Value.ToString();
                rtxtDescription.Text = row.Cells["Açıklama"].Value.ToString();
            }
        }

        // hucredeki verinin degeri degisirse
        private void DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                isChecked = (bool)dataGrid[e.ColumnIndex, e.RowIndex].Value;
            }
        }

        // guncelle butonuna tiklanirsa
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                if (string.IsNullOrEmpty(rtxtDeviceTitle.Text))
                {
                    errDeviceTitle.SetError(lblDeviceTitle, "Boş bırakılamaz");
                    return;
                }

                else if (string.IsNullOrEmpty(rtxtDeviceDescription.Text))
                {
                    errDeviceDescription.SetError(lblDeviceDescription, "Boş bırakılamaz");
                    return;
                }

                string title = rtxtDeviceTitle.Text.ToString().Trim();
                string description = rtxtDeviceDescription.Text.ToString().Trim();

                connection = new SqlConnection(connectionUrl);
                string query = "UPDATE Repair SET RepairDate = GETDATE(), Title = @Title, Description = @Description, DeviceStatus = 'Tamir Süreci Bitti' WHERE Id = " + repairId + "";
                sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@Title", title);
                sqlCommand.Parameters.AddWithValue("@Description", description);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();

                Reset();
            }
        }

        // guncelleme sonrasi verileri temizle
        private void Reset()
        {
            rtxtDeviceTitle.Clear();
            rtxtDeviceDescription.Clear();

            if (dataGrid.SelectedCells.Count > 0)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGrid.SelectedCells[0];
                checkCell.Value = false;
            }
        }

        // data grid de filtre uygula 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "A.Id AS 'Id'," +
                "R.Id AS 'Onarım Id'," +
                "A.FaultId AS 'Cihaz Id'," +
                "F.SerialNumber AS 'Seri Numarası'," +
                "D.Name AS 'Cihaz'," +
                "DT.Name AS 'Cihaz Türü'," +
                "B.Name AS 'Markası'," +
                "T.Code AS 'Çalışan Kodu' " +
                "FROM Repair AS R " +
                "INNER JOIN Assignment AS A ON A.Id = R.AssignmentId " +
                "INNER JOIN Fault AS F ON F.Id = R.FaultId " +
                "INNER JOIN Brand AS B ON B.Id = F.BrandId " +
                "INNER JOIN DeviceType AS DT ON DT.Id = B.DeviceTypeId " +
                "INNER JOIN Device AS D ON D.Id = DT.DeviceId " +
                "INNER JOIN Customer AS C ON C.Id = F.CustomerId " +
                "INNER JOIN Technician AS T ON T.Id = A.TechnicianId " +
                "WHERE " +
                "F.IsGrouped = 'E' AND F.IsPay = 'H'" +
                "AND " +
                "(F.SerialNumber LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "DT.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "B.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.Code LIKE '" + txtSearch.Text.ToString() + "%')";

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
