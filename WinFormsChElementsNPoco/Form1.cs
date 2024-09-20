using MySqlConnector;
using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace WinFormsChElementsNPoco
{
    public partial class Form1 : Form
    {
        string ConnectionString { get; init; } = ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateDataGridView(List<ChElement> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private List<ChElement> KontakteLaden()
        {
            List<ChElement> lst = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                connection.Open();
                string sql = "order by nachname, vorname";
                lst = db.Fetch<ChElement>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ChElement> list = DBHelper.LoadElements();
            UpdateDataGridView(list);
        }
    }
}
