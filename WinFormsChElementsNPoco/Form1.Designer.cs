namespace WinFormsChElementsNPoco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            numUpDownOZahl = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonExit = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            comboBoxZustand = new ComboBox();
            textBoxName = new TextBox();
            textBoxSymbol = new TextBox();
            buttonAdd = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownOZahl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numUpDownOZahl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(comboBoxZustand);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxSymbol);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 138);
            panel1.TabIndex = 1;
            // 
            // numUpDownOZahl
            // 
            numUpDownOZahl.Location = new Point(12, 28);
            numUpDownOZahl.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numUpDownOZahl.Name = "numUpDownOZahl";
            numUpDownOZahl.Size = new Size(81, 23);
            numUpDownOZahl.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 11;
            label4.Text = "Zustand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 10;
            label3.Text = "Element";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Symbol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 8;
            label1.Text = "Ordnungszahl";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(390, 99);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(97, 23);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Beenden";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(390, 70);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(97, 23);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(390, 41);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(97, 23);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Ändern";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // comboBoxZustand
            // 
            comboBoxZustand.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZustand.FormattingEnabled = true;
            comboBoxZustand.Items.AddRange(new object[] { "Unbekannt", "Gas", "Feststoff", "Flüssigkeit" });
            comboBoxZustand.Location = new Point(280, 27);
            comboBoxZustand.Name = "comboBoxZustand";
            comboBoxZustand.Size = new Size(87, 23);
            comboBoxZustand.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(160, 27);
            textBoxName.MaxLength = 30;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(114, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(99, 27);
            textBoxSymbol.MaxLength = 2;
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.Size = new Size(55, 23);
            textBoxSymbol.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(390, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(499, 304);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 442);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "ChElementsNPoco";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownOZahl).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private ComboBox comboBoxZustand;
        private TextBox textBoxName;
        private TextBox textBoxSymbol;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonEdit;
        private NumericUpDown numUpDownOZahl;
    }
}
