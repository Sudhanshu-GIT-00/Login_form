namespace Login_form
{
    partial class GetUserName
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
            button1 = new Button();
            btn_back_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 166);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 186);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(172, 209);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_back_login
            // 
            btn_back_login.Location = new Point(302, 209);
            btn_back_login.Name = "btn_back_login";
            btn_back_login.Size = new Size(196, 32);
            btn_back_login.TabIndex = 27;
            btn_back_login.Text = "Go Back To Login";
            btn_back_login.UseVisualStyleBackColor = true;
            btn_back_login.Click += btn_back_login_Click;
            // 
            // GetUserName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back_login);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GetUserName";
            Text = "GetUserName";
            Load += GetUserName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button btn_back_login;
    }
}