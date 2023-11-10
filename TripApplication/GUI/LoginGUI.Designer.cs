namespace TripApplication
{
    partial class LoginGUI
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
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 92);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 158);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(188, 90);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(169, 23);
            textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(188, 155);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(169, 23);
            textPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(109, 213);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(246, 213);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(95, 19);
            label3.Name = "label3";
            label3.Size = new Size(236, 42);
            label3.TabIndex = 6;
            label3.Text = "G3 SUNRISE";
            // 
            // LoginGUI
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(447, 288);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btnLogin;
        private Button btnCancel;
        private Label label3;
    }
}