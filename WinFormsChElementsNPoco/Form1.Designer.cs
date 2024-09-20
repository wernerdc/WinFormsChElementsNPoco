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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
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
            textBoxOZahl = new TextBox();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 304);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
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
            panel1.Controls.Add(textBoxOZahl);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 146);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 11;
            label4.Text = "Zustand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 9);
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
            buttonExit.Location = new Point(525, 112);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(97, 23);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Beenden";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(525, 83);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(97, 23);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(525, 54);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(97, 23);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Ändern";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // comboBoxZustand
            // 
            comboBoxZustand.FormattingEnabled = true;
            comboBoxZustand.Items.AddRange(new object[] { "Gas", "Feststoff", "Flüssigkeit", "Unbekannt" });
            comboBoxZustand.Location = new Point(311, 27);
            comboBoxZustand.Name = "comboBoxZustand";
            comboBoxZustand.Size = new Size(121, 23);
            comboBoxZustand.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(205, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(99, 27);
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.Size = new Size(100, 23);
            textBoxSymbol.TabIndex = 2;
            // 
            // textBoxOZahl
            // 
            textBoxOZahl.Location = new Point(12, 27);
            textBoxOZahl.Name = "textBoxOZahl";
            textBoxOZahl.Size = new Size(81, 23);
            textBoxOZahl.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(525, 25);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "ChElementsNPoco";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button buttonAdd;
        private ComboBox comboBoxZustand;
        private TextBox textBoxName;
        private TextBox textBoxSymbol;
        private TextBox textBoxOZahl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}
