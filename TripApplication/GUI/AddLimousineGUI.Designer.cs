namespace TripApplication.GUI
{
    partial class AddLimousineGUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textName = new TextBox();
            textPlate = new TextBox();
            numRow = new NumericUpDown();
            numCol = new NumericUpDown();
            cboType = new ComboBox();
            btnAdd = new Button();
            btnBack = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCol).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 56);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW LIMOUSINE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 149);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 152);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Plate: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 208);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Number Rows:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 213);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Number Cols:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 311);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 5;
            label6.Text = "Type";
            // 
            // textName
            // 
            textName.Location = new Point(233, 146);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 1;
            // 
            // textPlate
            // 
            textPlate.Location = new Point(509, 146);
            textPlate.Name = "textPlate";
            textPlate.Size = new Size(125, 27);
            textPlate.TabIndex = 7;
            // 
            // numRow
            // 
            numRow.Location = new Point(233, 206);
            numRow.Name = "numRow";
            numRow.Size = new Size(65, 27);
            numRow.TabIndex = 8;
            // 
            // numCol
            // 
            numCol.Location = new Point(509, 208);
            numCol.Name = "numCol";
            numCol.Size = new Size(65, 27);
            numCol.TabIndex = 9;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(355, 308);
            cboType.Name = "cboType";
            cboType.Size = new Size(151, 28);
            cboType.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(257, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(467, 422);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(640, 149);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 13;
            label7.Text = "10A-12345";
            // 
            // AddLimousineGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 542);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(cboType);
            Controls.Add(numCol);
            Controls.Add(numRow);
            Controls.Add(textPlate);
            Controls.Add(textName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddLimousineGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddLimousineGUI";
            ((System.ComponentModel.ISupportInitialize)numRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textName;
        private TextBox textPlate;
        private NumericUpDown numRow;
        private NumericUpDown numCol;
        private ComboBox cboType;
        private Button btnAdd;
        private Button btnBack;
        private Label label7;
    }
}