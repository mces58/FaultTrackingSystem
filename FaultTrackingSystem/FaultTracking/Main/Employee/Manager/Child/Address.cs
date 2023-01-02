using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Manager.Child
{
    public partial class Address : Form
    {
        // veritabani baglanti url
        private static readonly string connectionUrl = "Data Source=.;Initial Catalog=FaultTrackingAutomation;Integrated Security=True";
        // veritabani baglantisi
        private SqlConnection connection;
        private SqlCommand sqlCommand;

        // name pattern
        private readonly string name = @"^[a-zA-ZçğıöşüÇĞİÖŞÜ]+$";

        private int cityId;
        private int districtId;

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
        public Address()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void Address_Load(object sender, EventArgs e)
        {
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 30, 30));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 50, 50));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 50, 50));
            LoadTheme();
            dataGrid.ClearSelection();
            btnSearch.Enabled = false;

            AddressList();
        }

        // errorProvider temizle
        private void TxtCityCode_TextChanged(object sender, EventArgs e)
        {
            errCityCode.Clear();
        }

        // errorProvider temizle
        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            errCity.Clear();
        }

        // errorProvider temizle
        private void TxtDistrict_TextChanged(object sender, EventArgs e)
        {
            errDistrict.Clear();
        }

        // errorProvider temizle
        private void TxtCityCode_Leave(object sender, EventArgs e)
        {
            errCityCode.Clear();
        }

        // errorProvider temizle
        private void TxtCity_Leave(object sender, EventArgs e)
        {
            errCity.Clear();
        }

        // errorProvider temizle
        private void TxtDistrict_Leave(object sender, EventArgs e)
        {
            errDistrict.Clear();
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

        // adresleri listele
        private void AddressList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "C.Id AS 'CityId'," +
                "D.Id AS 'DistrictId'," +
                "C.Code AS 'Kod'," +
                "C.Name AS 'İl'," +
                "D.Name AS 'İlçe' " +
                "FROM City AS C " +
                "INNER JOIN District AS D ON D.CityId = C.Id " +
                "ORDER BY C.Code, D.Name";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
            };

            DataTable dataTable = new DataTable();
            connection.Open();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            dataGrid.DataSource = dataTable;
            dataGrid.Columns["CityId"].Visible = false;
            dataGrid.Columns["DistrictId"].Visible = false;

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
                txtCityCode.Text = row.Cells["Kod"].Value.ToString();
                txtCity.Text = row.Cells["İl"].Value.ToString();
                txtDistrict.Text = row.Cells["İlçe"].Value.ToString();
                cityId = (int)row.Cells["CityId"].Value;
                districtId = (int)row.Cells["DistrictId"].Value;
            }

            if (e.ColumnIndex == dataGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = (int)dataGrid.Rows[e.RowIndex].Cells["DistrictId"].Value;

                using (SqlConnection connection = new SqlConnection(connectionUrl))
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM District WHERE Id = @Id", connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", id);
                        sqlCommand.ExecuteNonQuery();

                        sqlCommand.CommandText = "IF EXISTS (SELECT * FROM District WHERE CityId = (SELECT TOP 1 Id FROM City WHERE Name = @CityName)) SELECT 1 ELSE SELECT 0";
                        sqlCommand.Parameters.AddWithValue("@CityName", txtCity.Text.ToString().Trim());
                        int result = (int)sqlCommand.ExecuteScalar();

                        if (result == 0)
                        {
                            sqlCommand.CommandText = "DELETE FROM City WHERE Id = @CityId";
                            sqlCommand.Parameters.AddWithValue("@CityId", cityId);
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
                dataGrid.Columns.Remove(buttonColumn);
                AddressList();
            }
        }

        // sehiri ekle
        private void AddList()
        {
            string cityName = txtCity.Text.Trim().ToUpper();
            string cityCode = txtCityCode.Text.Trim().ToUpper();
            string districtName = txtDistrict.Text.Trim().ToUpper();
            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO City (Name, Code) SELECT @CityName, @CityCode WHERE NOT EXISTS (SELECT * FROM City WHERE Name = @CityName);INSERT INTO District (Name, CityId) SELECT @DistrictName, Id FROM City WHERE Name = @CityName AND NOT EXISTS (SELECT * FROM District WHERE Name = @DistrictName AND CityId = (SELECT TOP 1 Id FROM City WHERE Name = @CityName))", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@CityName", cityName);
                    sqlCommand.Parameters.AddWithValue("@CityCode", cityCode);
                    sqlCommand.Parameters.AddWithValue("@DistrictName", districtName);
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // listeye ekle
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCityCode.Text))
            {
                errCityCode.SetError(lblCityCode, "Boş bırakılamaz");
                return;
            }

            if (string.IsNullOrEmpty(txtCity.Text))
            {
                errCity.SetError(lblCity, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtCity.Text, name) == false)
            {
                errCity.SetError(lblCity, "Doğru formatta giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(txtDistrict.Text))
            {
                errDistrict.SetError(lblDistrict, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtDistrict.Text, name) == false)
            {
                errDistrict.SetError(lblDistrict, "Doğru formatta giriniz.");
                return;
            }

            AddList();
            dataGrid.Columns.Remove(buttonColumn);
            AddressList();
        }

        // tabloyu guncelle
        private void UpdateList()
        {
            string cityName = txtCity.Text.Trim().ToUpper();
            string cityCode = txtCityCode.Text.Trim().ToUpper();
            string districtName = txtDistrict.Text.Trim().ToUpper();
            using (SqlConnection connection = new SqlConnection(connectionUrl))
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = connection;

                    sqlCommand.CommandText = "UPDATE City SET  Code = @Code, Name = @CityName WHERE Id = @CityId";
                    sqlCommand.Parameters.AddWithValue("@CityName", cityName);
                    sqlCommand.Parameters.AddWithValue("@Code", cityCode);
                    sqlCommand.Parameters.AddWithValue("@CityId", cityId);
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.CommandText = "UPDATE District SET Name = @DistrictName WHERE Id = @DistrictId";
                    sqlCommand.Parameters.AddWithValue("@DistrictName", districtName);
                    sqlCommand.Parameters.AddWithValue("@DistrictId", districtId);
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        // listeyi guncelle
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCityCode.Text))
            {
                errCityCode.SetError(lblCityCode, "Boş bırakılamaz");
                return;
            }

            if (string.IsNullOrEmpty(txtCity.Text))
            {
                errCity.SetError(lblCity, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtCity.Text, name) == false)
            {
                errCity.SetError(lblCity, "Doğru formatta giriniz.");
                return;
            }

            if (string.IsNullOrEmpty(txtDistrict.Text))
            {
                errDistrict.SetError(lblDistrict, "Boş bırakılamaz");
                return;
            }

            if (Regex.IsMatch(txtDistrict.Text, name) == false)
            {
                errDistrict.SetError(lblDistrict, "Doğru formatta giriniz.");
                return;
            }

            UpdateList();
            dataGrid.Columns.Remove(buttonColumn);
            AddressList();
        }

        // buton kolonu olustur
        private void CreateButtomColumn()
        {
            buttonColumn.HeaderText = "Şehir Sil";
            buttonColumn.Name = "Delete";
            buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            buttonColumn.Text = "Sil";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(buttonColumn);
        }

        // arama yap
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "C.Id AS 'CityId'," +
                "D.Id AS 'DistrictId'," +
                "C.Code AS 'Kod'," +
                "C.Name AS 'İl'," +
                "D.Name AS 'İlçe' " +
                "FROM City AS C " +
                "INNER JOIN District AS D ON D.CityId = C.Id " +
                "WHERE " +
                "C.Code LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "C.Name LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "%' " +
                "ORDER BY C.Code, D.Name";

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
