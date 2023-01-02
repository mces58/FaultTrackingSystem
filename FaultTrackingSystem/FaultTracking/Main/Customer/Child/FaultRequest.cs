using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    public partial class FaultRequest : Form
    {
        private static string imageLocation;

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
        public FaultRequest()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void FaultRequest_Load(object sender, EventArgs e)
        {
            LoadTheme();
            AddItemDevice();
            AddItemCity();
            btnFaultRequest.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFaultRequest.Width, btnFaultRequest.Height, 50, 50));
            btnUploadImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUploadImage.Width, btnUploadImage.Height, 50, 50));
            btnRemoveImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRemoveImage.Width, btnRemoveImage.Height, 50, 50));
        }

        // btnUploadImage animasyon
        private void BtnUploadImage_MouseEnter(object sender, EventArgs e)
        {
            btnUploadImage.Font = new Font("Segoe UI Black", 14.5F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUploadImage.TextAlign = ContentAlignment.TopCenter;
        }

        // btnUploadImage animasyon
        private void BtnUploadImage_MouseLeave(object sender, EventArgs e)
        {
            btnUploadImage.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnUploadImage.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnRemoveImage animasyon
        private void BtnRemoveImage_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveImage.Font = new Font("Segoe UI Black", 14.5F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnRemoveImage.TextAlign = ContentAlignment.TopCenter;
        }

        // btnRemoveImage animasyon
        private void BtnRemoveImage_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveImage.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnRemoveImage.TextAlign = ContentAlignment.MiddleCenter;
        }

        // btnFaultRequest animasyon
        private void BtnFaultRequest_MouseEnter(object sender, EventArgs e)
        {
            btnFaultRequest.Font = new Font("Segoe UI Black", 14F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnFaultRequest.TextAlign = ContentAlignment.TopCenter;
        }

        // btnFaultRequest animasyon
        private void BtnFaultRequest_MouseLeave(object sender, EventArgs e)
        {
            btnFaultRequest.Font = new Font("Segoe UI Black", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(0)));
            btnFaultRequest.TextAlign = ContentAlignment.MiddleCenter;
        }

        // errorProdiver temizle
        private void TxtSubject_TextChanged(object sender, EventArgs e)
        {
            errSubject.Clear();
        }

        // errorProvider temizle
        private void RtxtDescription_TextChanged(object sender, EventArgs e)
        {
            errDescription.Clear();
        }

        // errorProvider temizle
        private void RtxtOpenAddress_TextChanged(object sender, EventArgs e)
        {
            errOpenAddress.Clear();
        }

        // errorProvider temizle
        private void TxtSubject_Leave(object sender, EventArgs e)
        {
            errSubject.Clear();
        }

        // errorProvider temizle
        private void RtxtDescription_Leave(object sender, EventArgs e)
        {
            errDescription.Clear();
        }

        // errorProvider temizle
        private void RtxtOpenAddress_Leave(object sender, EventArgs e)
        {
            errOpenAddress.Clear();
        }

        // resim yukleme
        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            errDeviceImage.Clear();
            try
            {
                openFileDialog.Title = "Resim Seç";
                openFileDialog.Filter = "All Files(*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picDeviceImage.Image = Image.FromFile(openFileDialog.FileName);
                    imageLocation = openFileDialog.FileName;
                    picDeviceImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Hata");
            }
        }

        // resim kaldirma
        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            picDeviceImage.Image = null;
            errDeviceImage.Clear();
        }

        // cihazlari veri tabanindan cekip combobox yazma
        private void AddItemDevice()
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM Device ORDER BY Name";
                sqlCommand = new SqlCommand(query, connection);
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                cboDevice.ValueMember = "Id";
                cboDevice.DataSource = dataTable;
                cboDevice.DisplayMember = "Name";
                cboDeviceType.Enabled = false;
                cboBrand.Enabled = false;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // device degisirse diger comboboxlara veri ekle
        private void CboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                if (cboDevice.SelectedValue.ToString() != null)
                {
                    string query = "SELECT * FROM DeviceType WHERE DeviceId = @DeviceId ORDER BY Name";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@DeviceId", cboDevice.SelectedValue.ToString());
                    connection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    cboDeviceType.ValueMember = "Id";
                    cboDeviceType.DataSource = dataTable;
                    cboDeviceType.DisplayMember = "Name";
                    cboDeviceType.Enabled = true;
                    cboBrand.Enabled = false;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // deviceType degisirse markalari ekle
        private void CboDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                if (cboDevice.SelectedValue.ToString() != null)
                {
                    string query = "SELECT * FROM Brand WHERE DeviceTypeId = @DeviceTypeId ORDER BY Name";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@DeviceTypeId", cboDeviceType.SelectedValue.ToString());
                    connection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    cboBrand.ValueMember = "Id";
                    cboBrand.DataSource = dataTable;
                    cboBrand.DisplayMember = "Name";
                    cboBrand.Enabled = true;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // combobox sehir ekle
        private void AddItemCity()
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                string query = "SELECT * FROM City ORDER BY Name";
                sqlCommand = new SqlCommand(query, connection);
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                cboCity.ValueMember = "Id";
                cboCity.DataSource = dataTable;
                cboCity.DisplayMember = "Name";
                cboDistrict.Enabled = false;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // ilceleri ekle 
        private void CboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionUrl);
                if (cboCity.SelectedValue.ToString() != null)
                {
                    string query = "SELECT * FROM District WHERE CityId = @CityId ORDER BY Name";
                    sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.AddWithValue("@CityId", cboCity.SelectedValue.ToString());
                    connection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    cboDistrict.ValueMember = "Id";
                    cboDistrict.DataSource = dataTable;
                    cboDistrict.DisplayMember = "Name";
                    cboDistrict.Enabled = true;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // her seyi temizle
        private void Reset()
        {
            txtSubject.ResetText();
            rtxtDescription.ResetText();
            rtxtOpenAddress.ResetText();
            picDeviceImage.Image = null;
            cboDevice.SelectedIndex = 0;
            cboBrand.SelectedIndex = 0;
            cboCity.SelectedIndex = 0;
            cboDistrict.SelectedIndex = 0;
            cboDeviceType.Enabled = false;
            cboBrand.Enabled = false;
            cboDistrict.Enabled = false;
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

        // marka id degerini yakala
        private int BrandId()
        {
            int brandId;

            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM Brand WHERE Name = @Name";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Name", cboBrand.Text);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            brandId = Convert.ToInt32(dataReader["Id"].ToString());

            connection.Close();

            return brandId;
        }

        // ilce id degerini yakala
        private int DistrictId()
        {
            int districtId;

            connection = new SqlConnection(connectionUrl);
            string query = "SELECT * FROM District WHERE Name = @Name";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Name", cboDistrict.Text);
            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            districtId = Convert.ToInt32(dataReader["Id"].ToString());

            connection.Close();

            return districtId;
        }

        // Fault tablosuna arizali cihazi ekle
        private void InsertFault()
        {
            string serialNumber = Guid.NewGuid().ToString().Substring(0, 13);
            int customerId = CustomerId();
            int brandId = BrandId();
            string title = txtSubject.Text.Trim();
            string description = rtxtDescription.Text.Trim();
            // resim ekle
            FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] image = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            int districtId = DistrictId();
            string openAddress = rtxtOpenAddress.Text.Trim();

            string insertFaultTable = "INSERT INTO Fault(SerialNumber, CustomerId, BrandId, Title, Description, ReportedAt, DeviceImage, DistrictId, OpenAddress, IsPay, IsGrouped)";
            string valuesFaultTable = "VALUES(@SerialNumber, @CustomerId, @BrandId, @Title, @Description, GETDATE(), @DeviceImage, @DistrictId, @OpenAddress, 'H', 'H')";

            try
            {
                connection = new SqlConnection(connectionUrl);
                sqlCommand = new SqlCommand(insertFaultTable + valuesFaultTable, connection);
                sqlCommand.Parameters.AddWithValue("@SerialNumber", serialNumber);
                sqlCommand.Parameters.AddWithValue("@CustomerId", customerId);
                sqlCommand.Parameters.AddWithValue("@BrandId", brandId);
                sqlCommand.Parameters.AddWithValue("@Title", title);
                sqlCommand.Parameters.AddWithValue("@Description", description);
                sqlCommand.Parameters.Add("@DeviceImage", SqlDbType.Image, image.Length).Value = image;
                sqlCommand.Parameters.AddWithValue("@DistrictId", districtId);
                sqlCommand.Parameters.AddWithValue("@OpenAddress", openAddress);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // btnFaultRequest tiklanirsa
        private void BtnFaultRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text))
            {
                txtSubject.Focus();
                errSubject.SetError(lblSubject, "Boş bırakılamaz");
                return;
            }

            else if (string.IsNullOrEmpty(rtxtDescription.Text))
            {
                rtxtDescription.Focus();
                errDescription.SetError(lblDeviceStatus, "Boş bırakılamaz");
                return;
            }

            else if (string.IsNullOrEmpty(rtxtOpenAddress.Text))
            {
                rtxtOpenAddress.Focus();
                errOpenAddress.SetError(lblOpenAddress, "Boş bırakılamaz");
                return;
            }

            else if (picDeviceImage.Image == null)
            {
                errDeviceImage.SetError(lblImage, "Resim yükleyin");
                return;
            }

            InsertFault();
            new MessageBoxes.SuccessFaultRequestMessageBox().ShowDialog();
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
