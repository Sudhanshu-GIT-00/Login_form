namespace Login_form
{
    partial class SetPassword
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
            btn_Submit = new Button();
            label1 = new Label();
            label2 = new Label();
            new_password = new TextBox();
            Confirm_password = new TextBox();
            btn_back_login = new Button();
            SuspendLayout();
            // 
            // btn_Submit
            // 
            btn_Submit.Font = new Font("Baloo", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Submit.Location = new Point(293, 196);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(110, 39);
            btn_Submit.TabIndex = 0;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(174, 54);
            label1.Name = "label1";
            label1.Size = new Size(121, 24);
            label1.TabIndex = 1;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(174, 124);
            label2.Name = "label2";
            label2.Size = new Size(145, 24);
            label2.TabIndex = 2;
            label2.Text = "Confirm Password";
            // 
            // new_password
            // 
            new_password.BorderStyle = BorderStyle.FixedSingle;
            new_password.Location = new Point(339, 54);
            new_password.Name = "new_password";
            new_password.PasswordChar = '*';
            new_password.Size = new Size(327, 27);
            new_password.TabIndex = 3;
            // 
            // Confirm_password
            // 
            Confirm_password.BorderStyle = BorderStyle.FixedSingle;
            Confirm_password.Location = new Point(339, 117);
            Confirm_password.Name = "Confirm_password";
            Confirm_password.PasswordChar = '*';
            Confirm_password.Size = new Size(327, 27);
            Confirm_password.TabIndex = 4;
            // 
            // btn_back_login
            // 
            btn_back_login.Location = new Point(425, 203);
            btn_back_login.Name = "btn_back_login";
            btn_back_login.Size = new Size(241, 32);
            btn_back_login.TabIndex = 27;
            btn_back_login.Text = "Go Back To Login";
            btn_back_login.UseVisualStyleBackColor = true;
            btn_back_login.Click += btn_back_login_Click;
            // 
            // SetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back_login);
            Controls.Add(Confirm_password);
            Controls.Add(new_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Submit);
            Name = "SetPassword";
            Text = "SetPassword";
            Load += SetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Submit;
        private Label label1;
        private Label label2;
        private TextBox new_password;
        private TextBox Confirm_password;
        private Button btn_back_login;
    }
}