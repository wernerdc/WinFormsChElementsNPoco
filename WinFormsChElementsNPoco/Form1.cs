using MySqlConnector;
using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace WinFormsChElementsNPoco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitDatabase();
            InitDataGridView();
            comboBoxZustand.SelectedIndex = 0;
        }

        private void InitDatabase()
        {
            if (!DBHelper.CheckDatabaseExistence())
            {
                if (!DBHelper.CreateDatabase())
                {
                    MessageBox.Show("Database creation failed!", "ChElements", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InitDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Initialize custom columns, to display needed columns only
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "id";        // property name of ChElement class
            column1.Name = "ID";                    // name of displayed column name
            column1.MinimumWidth = 25;
            column1.FillWeight = 20;                // relative width (used by DataGridViewAutoSizeColumnsMode.Fill)
            column1.DefaultCellStyle = new DataGridViewCellStyle() {            // set column alignment
                    Alignment = DataGridViewContentAlignment.MiddleCenter };
            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "Ordnungszahl";
            column2.Name = "Ordnungshahl";
            column2.FillWeight = 70;
            column2.DefaultCellStyle = new DataGridViewCellStyle() { 
                    Alignment = DataGridViewContentAlignment.MiddleCenter };
            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "Name";
            column3.Name = "Element";
            DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "Symbol";
            column4.Name = "Symbol";
            column4.FillWeight = 50;
            column4.DefaultCellStyle = new DataGridViewCellStyle() { 
                    Alignment = DataGridViewContentAlignment.MiddleCenter };
            DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "ZustandName";
            column5.Name = "Zustand";
            
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
        }

        private void UpdateDataGridView(List<ChElement> list)
        {
            //list.Add(DBHelper.GetOne(3));       // single query test
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGridView(DBHelper.GetAll());
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ChElement? element = dataGridView1.CurrentRow.DataBoundItem as ChElement;
            //if (element == null)
            //  return;
            // is the same as:
            if (dataGridView1.CurrentRow.DataBoundItem is not ChElement element)
                return;

            SetInputValues(element);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DBHelper.AddOne(GetElementFromInput());
            UpdateDataGridView(DBHelper.GetAll());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is not ChElement element)
                return;

            ChElement editedElement = GetElementFromInput();
            editedElement.ID = element.ID;

            DBHelper.UpdateOne(editedElement);
            UpdateDataGridView(DBHelper.GetAll());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is not ChElement element)
                return;

            DBHelper.DeleteOne(element);
            UpdateDataGridView(DBHelper.GetAll());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private ChElement GetElementFromInput()
        {
            //int oZahl = (int.TryParse(textBoxOZahl.Text, out int n)) ? n : 0;
            int oZahl = decimal.ToInt32(numUpDownOZahl.Value);
            ChElement element = new ChElement(
                    oZahl,
                    textBoxName.Text,
                    textBoxSymbol.Text,
                    comboBoxZustand.SelectedIndex);

            return element;
        }
        private void SetInputValues(ChElement element)
        {
            numUpDownOZahl.Value = element.Ordnungszahl;
            textBoxName.Text = element.Name;
            textBoxSymbol.Text = element.Symbol;
            comboBoxZustand.SelectedIndex = element.Zustand;
        }
    }
}
