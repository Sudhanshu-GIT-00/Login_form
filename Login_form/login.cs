using System.Data.SqlClient;

namespace Login_form
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myconnect.connect();
        }

        private void link_singup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Singup().Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string unm, pnm, sql;
            unm = txt_username.Text;
            pnm = txt_password.Text;
            sql = "select * from user_profile where username= '" + unm + "' and password='" + pnm + "'";
            try
            {
                myconnect.cmd = new SqlCommand(sql, myconnect.con);
                myconnect.rs = myconnect.cmd.ExecuteReader();
                if (myconnect.rs.Read())
                {
                    if (myconnect.rs.GetString(1).Equals(pnm))
                    // MessageBox.Show("login success");
                    {
                        new login_success().Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("invalid password");
                }
                else
                    MessageBox.Show("user name not exit");
                myconnect.con.Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show("error " + exp.Message);
            }
        }


        private void link_forget_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Forget_user().Show();
            this.Hide();
        }

        private void link_forget_password_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Forget_password().Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}