using FaultTrackingSystem.FaultTracking.Main.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FaultTrackingSystem.FaultTracking.Main.Employee.Staff.Child
{
    public partial class TechnicianDetail : Form
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
        public TechnicianDetail()
        {
            InitializeComponent();
        }

        // sayfa yuklenirken
        private void TechnicianDetail_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGrid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGrid.Width, dataGrid.Height, 50, 50));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 30, 30));
            dataGrid.ClearSelection();
            btnSearch.Enabled = false;

            TechnicianDetailList();
        }

        // calisanlarin bilgilerini göster
        private void TechnicianDetailList()
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "T.Id AS 'Id'," +
                "T.Code AS 'Çalışanın Kodu'," +
                "T.FirstName AS 'Çalışanın Adı'," +
                "T.LastName AS 'Çalışanın Soyadı'," +
                "D.Name AS 'Çalışanın Uzmanlığı' " +
                "FROM Technician AS T " +
                "INNER JOIN Device AS D ON T.DeviceId = D.Id";
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

            if (dataGrid.RowCount == 0)
            {
                dataGrid.Enabled = false;
            }

            else
            {
                dataGrid.Enabled = true;
            }
        }

        // data grid de filtre uygula 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionUrl);
            string query =
                "SELECT " +
                "T.Id AS 'Id'," +
                "T.Code AS 'Çalışanın Kodu'," +
                "T.FirstName AS 'Çalışanın Adı'," +
                "T.LastName AS 'Çalışanın Soyadı'," +
                "D.Name AS 'Çalışanın Uzmanlığı' " +
                "FROM Technician AS T " +
                "INNER JOIN Device AS D ON T.DeviceId = D.Id " +
                "WHERE " +
                "T.Code LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.FirstName LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "T.LastName LIKE '" + txtSearch.Text.ToString() + "%' OR " +
                "D.Name LIKE '" + txtSearch.Text.ToString() + "%'";

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
