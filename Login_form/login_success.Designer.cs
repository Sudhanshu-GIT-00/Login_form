namespace Login_form
{
    partial class login_success
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
            btn_logout = new Button();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.BackgroundImageLayout = ImageLayout.Center;
            btn_logout.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(334, 199);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(132, 52);
            btn_logout.TabIndex = 26;
            btn_logout.Text = "LOG OUT";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // login_success
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_logout);
            Name = "login_success";
            Text = "login_success";
            Load += login_success_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_logout;
    }
}