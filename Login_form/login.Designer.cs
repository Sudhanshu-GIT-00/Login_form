namespace Login_form
{
    partial class login
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
            Label label2;
            btn_login_1 = new Button();
            txt_username = new TextBox();
            btn_login = new Button();
            txt_password = new TextBox();
            link_forget_user = new LinkLabel();
            link_forget_password = new LinkLabel();
            label1 = new Label();
            link_singup = new LinkLabel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(22, 215);
            label2.Name = "label2";
            label2.Size = new Size(91, 33);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.UseCompatibleTextRendering = true;
            // 
            // btn_login_1
            // 
            btn_login_1.Location = new Point(0, 0);
            btn_login_1.Name = "btn_login_1";
            btn_login_1.Size = new Size(75, 23);
            btn_login_1.TabIndex = 0;
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.ControlText;
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Arial Narrow", 10.2F, FontStyle.Strikeout, GraphicsUnit.Point);
            txt_username.ForeColor = Color.White;
            txt_username.Location = new Point(157, 147);
            txt_username.MaxLength = 25;
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(338, 27);
            txt_username.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Red;
            btn_login.Location = new Point(197, 387);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(117, 39);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Black;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = SystemColors.InactiveBorder;
            txt_password.Location = new Point(157, 215);
            txt_password.MaxLength = 30;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(338, 30);
            txt_password.TabIndex = 1;
            // 
            // link_forget_user
            // 
            link_forget_user.AutoSize = true;
            link_forget_user.BackColor = Color.Transparent;
            link_forget_user.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            link_forget_user.Location = new Point(72, 341);
            link_forget_user.Name = "link_forget_user";
            link_forget_user.Size = new Size(122, 17);
            link_forget_user.TabIndex = 5;
            link_forget_user.TabStop = true;
            link_forget_user.Text = "Forget User Name";
            link_forget_user.LinkClicked += link_forget_user_LinkClicked;
            // 
            // link_forget_password
            // 
            link_forget_password.AutoSize = true;
            link_forget_password.BackColor = Color.Transparent;
            link_forget_password.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            link_forget_password.Location = new Point(197, 288);
            link_forget_password.Name = "link_forget_password";
            link_forget_password.Size = new Size(114, 17);
            link_forget_password.TabIndex = 6;
            link_forget_password.TabStop = true;
            link_forget_password.Text = "Forget Password";
            link_forget_password.LinkClicked += link_forget_password_LinkClicked_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(6, 143);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // link_singup
            // 
            link_singup.AutoSize = true;
            link_singup.BackColor = Color.Transparent;
            link_singup.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            link_singup.Location = new Point(316, 339);
            link_singup.Name = "link_singup";
            link_singup.Size = new Size(137, 17);
            link_singup.TabIndex = 1;
            link_singup.TabStop = true;
            link_singup.Text = "Create  an Account";
            link_singup.LinkClicked += link_singup_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pngtree_blue_and_green_shie;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(637, 541);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(link_singup);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(link_forget_password);
            groupBox1.Controls.Add(link_forget_user);
            groupBox1.Font = new Font("Shrikhand", 10.82F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(655, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 532);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1201, 546);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.KatakanaHalf;
            MaximizeBox = false;
            Name = "login";
            RightToLeftLayout = true;
            Text = "Login From";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_login_1;
        private TextBox txt_username;
        private Label label2;
        private Button btn_login;
        private TextBox txt_password;
        private LinkLabel link_forget_user;
        private LinkLabel link_forget_password;
        private Label label1;
        private LinkLabel link_singup;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
    }
}