using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Technician.Child
{
    public partial class SparePart : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        private SqlDataReader dataReader;

        private int sparePartId;

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
        public SparePart()
        {
            InitializeComponent();
        }

        // sayfa yukenirken
        private void SparePart_Load(object sender, EventArgs e)
        {
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 50, 50));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 50, 50));
            LoadTheme();
            dataGrid.ClearSelection();
            SparePartList();

            AddItemDeviceType();
        }

        // yedek parcalari listele
        private void SparePartList()
        {
            connection = new SqlConnection(connectionUrl);
            string query = 
                "SELECT " +
                "S.Id AS 'YedekParcaId'," +
                "DT.Id AS 'CihazTuruId'," +
                "S.Name AS 'Adı'," +
                "S.Amount AS 'Adet'," +
                "S.PurchaseDate AS 'Satın Alma Tarihi'," +
                "S.Price AS 'Birim Fiyatı'," +
                "DT.Name AS 'Cihaz Türü'" +
                "FROM SparePart AS S " +
                "INNER JOIN DeviceType AS DT ON DT.Id = S.DeviceTypeId";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
            };

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGrid.DataSource = dataTable;
            dataGrid.Columns["YedekParcaId"].Visible = false;
            dataGrid.Columns["CihazTuruId"].Visible = false;

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
                btnUpdate.Enabled = true;
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                txtName.Text = row.Cells["Adı"].Value.ToString();
                numAmount.Text = row.Cells["Adet"].Value.ToString();
                numPrice.Text = row.Cells["Birim Fiyatı"].Value.ToString();
                cboDeviceType.Text = row.Cells["Cihaz Türü"].Value.ToString();

                sparePartId = (int)row.Cells["YedekParcaId"].Value;
            }

            if (e.ColumnIndex == dataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = (int)dataGrid.Rows[e.RowIndex].Cells["YedekParcaId"].Value;

                using (SqlConnection connection = new SqlConnection(connectionUrl))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM SparePart WHERE Id = @Id", connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                dataGrid.Columns.Remove(buttonColumn);
                SparePartList();
            }
        }

        // cihazlari veri tabanindan cekip combobox yazma
        private void AddItemDeviceType()
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT DISTINCT Name FROM DeviceType ORDER BY Name";
                sqlCommand = new SqlCommand(query, connection);
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                cboDeviceType.DataSource = dataTable;
                cboDeviceType.DisplayMember = "Name";

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // cihaz id degerini yakala
        private int DeviceTypeId()
        {
            int deviceTypeId;

            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM DeviceType WHERE Name = @Name";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Name", cboDeviceType.Text);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            deviceTypeId = Convert.ToInt32(dataReader["Id"].ToString());

            connection.Close();

            return deviceTypeId;
        }

        // tablolara veri ekle
        private void AddList()
        {
            string name = txtName.Text.Trim().ToUpper();
            int price = (int)numPrice.Value;
            int amount = (int)numAmount.Value;
            int deviceTypeId = DeviceTypeId();

            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO SparePart (Name, Amount, PurchaseDate, Price, DeviceTypeId) VALUES (@Name, @Amount, GETDATE(), @Price, @DeviceTypeId)", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@Name", name);
                    sqlCommand.Parameters.AddWithValue("@Amount", amount);
                    sqlCommand.Parameters.AddWithValue("@Price", price);
                    sqlCommand.Parameters.AddWithValue("@DeviceTypeId", deviceTypeId);
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // listeye kategori ekle
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errName.SetError(lblName, "Boş bırakılamaz");
                return;
            }

            if (numAmount.Value == 0)
            {
                errPrice.SetError(lblAmount, "Değer giriniz");
                return;
            }

            if (numPrice.Value == 0)
            {
                errAmount.SetError(lblPrice, "Değer giriniz");
                return;
            }

            AddList();
            dataGrid.Columns.Remove(buttonColumn);
            SparePartList();
        }

        // errorProvider temizle
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            errName.Clear();
        }

        // errorProvider temizle
        private void TxtName_Leave(object sender, EventArgs e)
        {
            errName.Clear();
        }

        // errorProvider temizle
        private void NumPrice_ValueChanged(object sender, EventArgs e)
        {
            errPrice.Clear();
        }

        // errorProvider temizle
        private void NumPrice_Leave(object sender, EventArgs e)
        {
            errPrice.Clear();
        }

        // errorProvider temizle
        private void NumAmount_ValueChanged(object sender, EventArgs e)
        {
            errAmount.Clear();
        }

        // errorProvider temizle
        private void NumAmount_Leave(object sender, EventArgs e)
        {
            errAmount.Clear();
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
            string name = txtName.Text.Trim().ToUpper();
            int amount = (int)numAmount.Value;
            int price = (int)numPrice.Value;
            int deviceTypeId = DeviceTypeId();

            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = connection;

                    // SparePart tablosunu guncelle
                    sqlCommand.CommandText = "UPDATE SparePart SET Name = @Name, Amount = @Amount, Price = @Price, DeviceTypeId = @DeviceTypeId WHERE Id = @SparePartId";
                    sqlCommand.Parameters.AddWithValue("@Name", name);
                    sqlCommand.Parameters.AddWithValue("@Amount", amount);
                    sqlCommand.Parameters.AddWithValue("@Price", price);
                    sqlCommand.Parameters.AddWithValue("@SparePartId", sparePartId);
                    sqlCommand.Parameters.AddWithValue("@DeviceTypeId", deviceTypeId);
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
            SparePartList();
        }

        // buton kolonu olustur
        private void CreateButtomColumn()
        {
            buttonColumn.HeaderText = "Yedek Parça Sil";
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
                "S.Id AS 'YedekParcaId'," +
                "DT.Id AS 'CihazTuruId'," +
                "S.Name AS 'Adı'," +
                "S.Amount AS 'Adet'," +
                "S.PurchaseDate AS 'Satın Alma Tarihi'," +
                "S.Price AS 'Birim Fiyatı'," +
                "DT.Name AS 'Cihaz Türü'" +
                "FROM SparePart AS S " +
                "INNER JOIN DeviceType AS DT ON DT.Id = S.DeviceTypeId " +
                "WHERE " +
                "(S.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "S.Amount LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "S.Price LIKE '" + txtSearch.Text.ToString() + "%') " +
                "ORDER BY S.Name, S.Amount";

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
