namespace Login_form
{
    partial class Forget_password
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
            groupBox1 = new GroupBox();
            btn_back_login = new Button();
            date_of_birth = new DateTimePicker();
            btn_Next = new Button();
            label4 = new Label();
            label3 = new Label();
            Full_name = new TextBox();
            Rigester_user_name = new TextBox();
            email_id = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(171, 27);
            label1.TabIndex = 0;
            label1.Text = "Rigesterd Email ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 92);
            label2.Name = "label2";
            label2.Size = new Size(196, 27);
            label2.TabIndex = 1;
            label2.Text = "Rigesterd User Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_back_login);
            groupBox1.Controls.Add(date_of_birth);
            groupBox1.Controls.Add(btn_Next);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Full_name);
            groupBox1.Controls.Add(Rigester_user_name);
            groupBox1.Controls.Add(email_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(110, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 326);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forget Password";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_back_login
            // 
            btn_back_login.BackColor = Color.FromArgb(255, 192, 192);
            btn_back_login.Location = new Point(294, 288);
            btn_back_login.Name = "btn_back_login";
            btn_back_login.Size = new Size(196, 32);
            btn_back_login.TabIndex = 26;
            btn_back_login.Text = "Go Back To Login";
            btn_back_login.UseVisualStyleBackColor = false;
            btn_back_login.Click += btn_back_login_Click;
            // 
            // date_of_birth
            // 
            date_of_birth.Location = new Point(294, 217);
            date_of_birth.Name = "date_of_birth";
            date_of_birth.Size = new Size(307, 27);
            date_of_birth.TabIndex = 7;
            // 
            // btn_Next
            // 
            btn_Next.BackColor = Color.FromArgb(192, 255, 192);
            btn_Next.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Next.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Next.ForeColor = Color.Red;
            btn_Next.Location = new Point(152, 277);
            btn_Next.Margin = new Padding(2);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(121, 43);
            btn_Next.TabIndex = 3;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = false;
            btn_Next.Click += Next_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 216);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 6;
            label4.Text = "Date Of Birth ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 150);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 5;
            label3.Text = "Full Name";
            // 
            // Full_name
            // 
            Full_name.BackColor = Color.FromArgb(192, 255, 192);
            Full_name.BorderStyle = BorderStyle.FixedSingle;
            Full_name.Location = new Point(294, 153);
            Full_name.Name = "Full_name";
            Full_name.Size = new Size(307, 27);
            Full_name.TabIndex = 4;
            // 
            // Rigester_user_name
            // 
            Rigester_user_name.BackColor = Color.FromArgb(192, 255, 192);
            Rigester_user_name.BorderStyle = BorderStyle.FixedSingle;
            Rigester_user_name.Location = new Point(294, 95);
            Rigester_user_name.Name = "Rigester_user_name";
            Rigester_user_name.Size = new Size(307, 27);
            Rigester_user_name.TabIndex = 3;
            // 
            // email_id
            // 
            email_id.BackColor = Color.FromArgb(192, 255, 192);
            email_id.BorderStyle = BorderStyle.FixedSingle;
            email_id.Location = new Point(294, 39);
            email_id.Name = "email_id";
            email_id.Size = new Size(307, 27);
            email_id.TabIndex = 2;
            // 
            // Forget_password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Forget_password";
            Text = "Forget_password";
            Load += Forget_password_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DateTimePicker date_of_birth;
        private Label label4;
        private Label label3;
        private TextBox Full_name;
        private TextBox Rigester_user_name;
        private TextBox email_id;
        private Button btn_Next;
        private Button btn_back_login;
    }
}