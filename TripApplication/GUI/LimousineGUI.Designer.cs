namespace TripApplication.GUI
{
    partial class LimousineGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            numCol = new NumericUpDown();
            numRow = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            btnRefresh = new Button();
            btnSave = new Button();
            textId = new TextBox();
            textName = new TextBox();
            label3 = new Label();
            textPlate = new TextBox();
            label1 = new Label();
            limoDataView = new DataGridView();
            labelNum = new Label();
            btnBack = new Button();
            label4 = new Label();
            textFilter = new TextBox();
            label7 = new Label();
            btnAdd = new Button();
            label2 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)limoDataView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(numCol);
            groupBox1.Controls.Add(numRow);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textPlate);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 41);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(704, 138);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Limousine Info";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 112);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // numCol
            // 
            numCol.Location = new Point(466, 56);
            numCol.Margin = new Padding(3, 2, 3, 2);
            numCol.Name = "numCol";
            numCol.Size = new Size(72, 23);
            numCol.TabIndex = 14;
            numCol.Leave += numCol_Leave;
            // 
            // numRow
            // 
            numRow.Location = new Point(466, 26);
            numRow.Margin = new Padding(3, 2, 3, 2);
            numRow.Name = "numRow";
            numRow.Size = new Size(72, 23);
            numRow.TabIndex = 13;
            numRow.Leave += numRow_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 58);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 12;
            label6.Text = "Number Cols:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 27);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 11;
            label5.Text = "Number Rows:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(302, 112);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 22);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(189, 112);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textId
            // 
            textId.Location = new Point(276, 113);
            textId.Margin = new Padding(3, 2, 3, 2);
            textId.Name = "textId";
            textId.Size = new Size(21, 23);
            textId.TabIndex = 4;
            textId.Visible = false;
            // 
            // textName
            // 
            textName.Location = new Point(158, 56);
            textName.Margin = new Padding(3, 2, 3, 2);
            textName.Name = "textName";
            textName.Size = new Size(131, 23);
            textName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 27);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Plate:";
            // 
            // textPlate
            // 
            textPlate.Location = new Point(158, 22);
            textPlate.Margin = new Padding(3, 2, 3, 2);
            textPlate.Name = "textPlate";
            textPlate.ReadOnly = true;
            textPlate.Size = new Size(131, 23);
            textPlate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 58);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // limoDataView
            // 
            limoDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            limoDataView.Location = new Point(10, 230);
            limoDataView.Margin = new Padding(3, 2, 3, 2);
            limoDataView.Name = "limoDataView";
            limoDataView.ReadOnly = true;
            limoDataView.RowHeadersWidth = 51;
            limoDataView.RowTemplate.Height = 29;
            limoDataView.Size = new Size(704, 141);
            limoDataView.TabIndex = 3;
            limoDataView.CellClick += limoDataView_CellClick;
            limoDataView.DataBindingComplete += limoDataView_DataBindingComplete;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Location = new Point(10, 213);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(176, 15);
            labelNum.TabIndex = 2;
            labelNum.Text = "Total number of our Limousine: ";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(632, 376);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(194, 10);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 4;
            label4.Text = "Search: ";
            // 
            // textFilter
            // 
            textFilter.Location = new Point(312, 16);
            textFilter.Margin = new Padding(3, 2, 3, 2);
            textFilter.Name = "textFilter";
            textFilter.Size = new Size(131, 23);
            textFilter.TabIndex = 1;
            textFilter.TextChanged += textFilter_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 21);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 6;
            label7.Text = "(Name / Plate)";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 184);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(192, 22);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add a new limousine";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(567, 27);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "*( 5 -> 10 )";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(567, 59);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "* ( 2 -> 3 )";
            // 
            // LimousineGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 406);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(textFilter);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(labelNum);
            Controls.Add(limoDataView);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LimousineGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LimousineGUI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)limoDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView limoDataView;
        private TextBox textPlate;
        private Label labelNum;
        private TextBox textId;
        private TextBox textName;
        private Label label3;
        private Button btnSave;
        private Button btnBack;
        private Button btnRefresh;
        private Label label4;
        private TextBox textFilter;
        private TextBox textCol;
        private TextBox textRow;
        private Label label6;
        private Label label5;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numCol;
        private NumericUpDown numRow;
        private Button btnDelete;
        private Button btnAdd;
        private Label label8;
        private Label label2;
    }
}