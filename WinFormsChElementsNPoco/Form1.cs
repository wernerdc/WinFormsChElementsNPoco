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


        private void Form1_Load(object sender, EventArgs e)
        {
            List<ChElement> list = DBHelper.LoadElements();
            UpdateDataGridView(list);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChElement? element = dataGridView1.CurrentRow.DataBoundItem as ChElement;
            if (element == null) return;

            FillInputTextBoxes(element);
        }

        private void FillInputTextBoxes(ChElement element)
        {
            try
            {   
                int oZahl = int.Parse(textBoxOZahl.Text);
                string name = textBoxName.Text;
                string symbol = textBoxSymbol.Text;
                int zustsnd = comboBoxZustand.SelectedIndex;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
