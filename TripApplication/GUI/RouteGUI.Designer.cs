namespace TripApplication.GUI
{
    partial class RouteGUI
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
            routeDataView = new DataGridView();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            textId = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            cboTo = new ComboBox();
            cboFrom = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            labelAll = new Label();
            ((System.ComponentModel.ISupportInitialize)routeDataView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // routeDataView
            // 
            routeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            routeDataView.Location = new Point(12, 202);
            routeDataView.Name = "routeDataView";
            routeDataView.RowHeadersWidth = 70;
            routeDataView.RowTemplate.Height = 25;
            routeDataView.Size = new Size(770, 211);
            routeDataView.TabIndex = 0;
            routeDataView.CellClick += routeDataView_CellClick;
            routeDataView.CellContentClick += routeDataView_CellContentClick;
            routeDataView.DataBindingComplete += routeDataView_DataBindingComplete;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cboTo);
            groupBox1.Controls.Add(cboFrom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Route Info";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(349, 130);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(67, 23);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textId
            // 
            textId.Location = new Point(107, 25);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(43, 23);
            textId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 28);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Route ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(241, 130);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(140, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Save Route";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboTo
            // 
            cboTo.FormattingEnabled = true;
            cboTo.Location = new Point(358, 70);
            cboTo.Name = "cboTo";
            cboTo.Size = new Size(135, 23);
            cboTo.TabIndex = 3;
            // 
            // cboFrom
            // 
            cboFrom.FormattingEnabled = true;
            cboFrom.Location = new Point(107, 70);
            cboFrom.Name = "cboFrom";
            cboFrom.Size = new Size(135, 23);
            cboFrom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 73);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Route To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 73);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Route From:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(707, 419);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // labelAll
            // 
            labelAll.AutoSize = true;
            labelAll.Location = new Point(12, 184);
            labelAll.Name = "labelAll";
            labelAll.Size = new Size(79, 15);
            labelAll.TabIndex = 3;
            labelAll.Text = "All our route: ";
            // 
            // RouteGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAll);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(routeDataView);
            Name = "RouteGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RouteGUI";
            ((System.ComponentModel.ISupportInitialize)routeDataView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView routeDataView;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnAdd;
        private ComboBox cboTo;
        private ComboBox cboFrom;
        private Label label2;
        private Label label1;
        private Button btnBack;
        private Label labelAll;
        private TextBox textId;
        private Label label3;
        private Button btnRefresh;
    }
}