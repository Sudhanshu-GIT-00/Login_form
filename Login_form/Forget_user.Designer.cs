namespace Login_form
{
    partial class Forget_user
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
            btn_Next = new Button();
            groupBox1 = new GroupBox();
            btn_back_login = new Button();
            date_of_birth = new DateTimePicker();
            Full_name = new TextBox();
            email_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Next
            // 
            btn_Next.Font = new Font("Baloo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Next.Location = new Point(140, 228);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(94, 32);
            btn_Next.TabIndex = 0;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_back_login);
            groupBox1.Controls.Add(btn_Next);
            groupBox1.Controls.Add(date_of_birth);
            groupBox1.Controls.Add(Full_name);
            groupBox1.Controls.Add(email_id);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(118, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 266);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forget User Name";
            // 
            // btn_back_login
            // 
            btn_back_login.Location = new Point(295, 228);
            btn_back_login.Name = "btn_back_login";
            btn_back_login.Size = new Size(204, 30);
            btn_back_login.TabIndex = 27;
            btn_back_login.Text = "Go Back To Login";
            btn_back_login.UseVisualStyleBackColor = true;
            btn_back_login.Click += btn_back_login_Click;
            // 
            // date_of_birth
            // 
            date_of_birth.Location = new Point(295, 89);
            date_of_birth.Name = "date_of_birth";
            date_of_birth.Size = new Size(288, 27);
            date_of_birth.TabIndex = 15;
            // 
            // Full_name
            // 
            Full_name.BorderStyle = BorderStyle.FixedSingle;
            Full_name.Location = new Point(295, 150);
            Full_name.Name = "Full_name";
            Full_name.Size = new Size(288, 27);
            Full_name.TabIndex = 14;
            Full_name.Text = " ";
            // 
            // email_id
            // 
            email_id.BorderStyle = BorderStyle.FixedSingle;
            email_id.Location = new Point(295, 37);
            email_id.Name = "email_id";
            email_id.Size = new Size(288, 27);
            email_id.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 40);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 8;
            label1.Text = "Rigesterd Email ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 92);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 28;
            label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 140);
            label3.Name = "label3";
            label3.Size = new Size(85, 24);
            label3.TabIndex = 29;
            label3.Text = "Full Name";
            // 
            // Forget_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Forget_user";
            Text = "Forget_user";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Next;
        private GroupBox groupBox1;
        private DateTimePicker date_of_birth;
        private TextBox Full_name;
        private TextBox email_id;
        private Label label1;
        private Button btn_back_login;
        private Label label3;
        private Label label2;
    }
}