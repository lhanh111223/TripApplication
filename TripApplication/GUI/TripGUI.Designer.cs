namespace TripApplication.GUI
{
    partial class TripGUI
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
            tripDataView = new DataGridView();
            label1 = new Label();
            cboFrom = new ComboBox();
            cboTo = new ComboBox();
            label2 = new Label();
            labelNum = new Label();
            groupBox1 = new GroupBox();
            radioVip = new RadioButton();
            radioNormal = new RadioButton();
            radioAll = new RadioButton();
            checkSeat = new CheckBox();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            cboSlot = new ComboBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)tripDataView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tripDataView
            // 
            tripDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tripDataView.Location = new Point(12, 272);
            tripDataView.Name = "tripDataView";
            tripDataView.RowTemplate.Height = 25;
            tripDataView.Size = new Size(1240, 398);
            tripDataView.TabIndex = 0;
            tripDataView.CellClick += tripDataView_CellClick;
            tripDataView.DataBindingComplete += tripDataView_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Route From:";
            // 
            // cboFrom
            // 
            cboFrom.FormattingEnabled = true;
            cboFrom.Location = new Point(95, 27);
            cboFrom.Name = "cboFrom";
            cboFrom.Size = new Size(121, 23);
            cboFrom.TabIndex = 3;
            // 
            // cboTo
            // 
            cboTo.FormattingEnabled = true;
            cboTo.Location = new Point(305, 27);
            cboTo.Name = "cboTo";
            cboTo.Size = new Size(121, 23);
            cboTo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Route To:";
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Location = new Point(12, 254);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(112, 15);
            labelNum.TabIndex = 6;
            labelNum.Text = "The number of trip: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioVip);
            groupBox1.Controls.Add(radioNormal);
            groupBox1.Controls.Add(radioAll);
            groupBox1.Location = new Point(457, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 108);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Limousine type";
            // 
            // radioVip
            // 
            radioVip.AutoSize = true;
            radioVip.Location = new Point(23, 78);
            radioVip.Name = "radioVip";
            radioVip.Size = new Size(42, 19);
            radioVip.TabIndex = 2;
            radioVip.TabStop = true;
            radioVip.Text = "VIP";
            radioVip.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            radioNormal.AutoSize = true;
            radioNormal.Location = new Point(23, 51);
            radioNormal.Name = "radioNormal";
            radioNormal.Size = new Size(75, 19);
            radioNormal.TabIndex = 1;
            radioNormal.TabStop = true;
            radioNormal.Text = "NORMAL";
            radioNormal.UseVisualStyleBackColor = true;
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Location = new Point(23, 26);
            radioAll.Name = "radioAll";
            radioAll.Size = new Size(45, 19);
            radioAll.TabIndex = 0;
            radioAll.TabStop = true;
            radioAll.Text = "ALL";
            radioAll.UseVisualStyleBackColor = true;
            // 
            // checkSeat
            // 
            checkSeat.AutoSize = true;
            checkSeat.Location = new Point(305, 164);
            checkSeat.Name = "checkSeat";
            checkSeat.Size = new Size(225, 19);
            checkSeat.TabIndex = 8;
            checkSeat.Text = "Only shows trips with available tickets";
            checkSeat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 116);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "Date: ";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(95, 112);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(121, 23);
            dtpDate.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 118);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "Slot:";
            // 
            // cboSlot
            // 
            cboSlot.FormattingEnabled = true;
            cboSlot.Location = new Point(305, 112);
            cboSlot.Name = "cboSlot";
            cboSlot.Size = new Size(121, 23);
            cboSlot.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(208, 161);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(12, 228);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(112, 23);
            btnShowAll.TabIndex = 14;
            btnShowAll.Text = "SHOW ALL TRIPS";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // TripGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 703);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(cboSlot);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(checkSeat);
            Controls.Add(groupBox1);
            Controls.Add(labelNum);
            Controls.Add(label2);
            Controls.Add(cboTo);
            Controls.Add(cboFrom);
            Controls.Add(label1);
            Controls.Add(tripDataView);
            Name = "TripGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TripGUI";
            ((System.ComponentModel.ISupportInitialize)tripDataView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tripDataView;
        private Label label1;
        private ComboBox cboFrom;
        private ComboBox cboTo;
        private Label label2;
        private Label labelNum;
        private GroupBox groupBox1;
        private RadioButton radioVip;
        private RadioButton radioNormal;
        private RadioButton radioAll;
        private CheckBox checkSeat;
        private Label label3;
        private DateTimePicker dtpDate;
        private Label label4;
        private ComboBox cboSlot;
        private Button btnSearch;
        private Button btnShowAll;
    }
}