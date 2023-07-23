namespace Login_form
{
    partial class Singup
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
            btn_singup = new Button();
            txt_singup_password = new TextBox();
            txt_singup_user = new TextBox();
            Date_Of_Birth = new DateTimePicker();
            txt_email_id = new TextBox();
            label5 = new Label();
            cmbo_gender = new ComboBox();
            txt_confirm_password = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_back_login = new Button();
            SuspendLayout();
            // 
            // btn_singup
            // 
            btn_singup.BackgroundImageLayout = ImageLayout.Center;
            btn_singup.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_singup.Location = new Point(251, 337);
            btn_singup.Name = "btn_singup";
            btn_singup.Size = new Size(132, 52);
            btn_singup.TabIndex = 12;
            btn_singup.Text = "SingUp";
            btn_singup.UseVisualStyleBackColor = true;
            btn_singup.Click += btn_singup_Click;
            // 
            // txt_singup_password
            // 
            txt_singup_password.BackColor = SystemColors.ActiveCaption;
            txt_singup_password.BorderStyle = BorderStyle.FixedSingle;
            txt_singup_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_singup_password.Location = new Point(410, 130);
            txt_singup_password.Name = "txt_singup_password";
            txt_singup_password.PasswordChar = '*';
            txt_singup_password.Size = new Size(272, 30);
            txt_singup_password.TabIndex = 11;
            // 
            // txt_singup_user
            // 
            txt_singup_user.BackColor = SystemColors.ActiveCaption;
            txt_singup_user.BorderStyle = BorderStyle.FixedSingle;
            txt_singup_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_singup_user.Location = new Point(410, 84);
            txt_singup_user.Name = "txt_singup_user";
            txt_singup_user.Size = new Size(272, 30);
            txt_singup_user.TabIndex = 10;
            // 
            // Date_Of_Birth
            // 
            Date_Of_Birth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Date_Of_Birth.Location = new Point(410, 223);
            Date_Of_Birth.Name = "Date_Of_Birth";
            Date_Of_Birth.Size = new Size(272, 34);
            Date_Of_Birth.TabIndex = 16;
            // 
            // txt_email_id
            // 
            txt_email_id.BackColor = SystemColors.ActiveCaption;
            txt_email_id.BorderStyle = BorderStyle.FixedSingle;
            txt_email_id.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email_id.Location = new Point(410, 40);
            txt_email_id.Name = "txt_email_id";
            txt_email_id.Size = new Size(272, 30);
            txt_email_id.TabIndex = 17;
            txt_email_id.TextChanged += txt_email_id_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(198, 276);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 1;
            label5.Text = "Gender";
            // 
            // cmbo_gender
            // 
            cmbo_gender.BackColor = SystemColors.ActiveCaption;
            cmbo_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbo_gender.FormattingEnabled = true;
            cmbo_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbo_gender.Location = new Point(410, 276);
            cmbo_gender.Name = "cmbo_gender";
            cmbo_gender.Size = new Size(272, 28);
            cmbo_gender.TabIndex = 18;
            // 
            // txt_confirm_password
            // 
            txt_confirm_password.BackColor = SystemColors.ActiveCaption;
            txt_confirm_password.BorderStyle = BorderStyle.FixedSingle;
            txt_confirm_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_confirm_password.Location = new Point(410, 175);
            txt_confirm_password.Name = "txt_confirm_password";
            txt_confirm_password.PasswordChar = '*';
            txt_confirm_password.Size = new Size(272, 30);
            txt_confirm_password.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(198, 175);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 20;
            label6.Text = "Confirm Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(198, 227);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 21;
            label7.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(198, 130);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(198, 84);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 23;
            label8.Text = "User Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(198, 40);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 24;
            label9.Text = "Email ID";
            // 
            // btn_back_login
            // 
            btn_back_login.Location = new Point(445, 352);
            btn_back_login.Name = "btn_back_login";
            btn_back_login.Size = new Size(152, 29);
            btn_back_login.TabIndex = 25;
            btn_back_login.Text = "Go Back To Login";
            btn_back_login.UseVisualStyleBackColor = true;
            btn_back_login.Click += btn_back_login_Click;
            // 
            // Singup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back_login);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_confirm_password);
            Controls.Add(cmbo_gender);
            Controls.Add(label5);
            Controls.Add(txt_email_id);
            Controls.Add(Date_Of_Birth);
            Controls.Add(btn_singup);
            Controls.Add(txt_singup_password);
            Controls.Add(txt_singup_user);
            Name = "Singup";
            Text = "Singup";
            Load += Singup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_singup;
        private TextBox txt_singup_password;
        private TextBox txt_singup_user;
        private DateTimePicker Date_Of_Birth;
        private TextBox txt_email_id;
        private Label label5;
        private ComboBox cmbo_gender;
        private TextBox txt_confirm_password;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label8;
        private Label label9;
        private Button btn_back_login;
    }
}