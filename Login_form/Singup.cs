using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_form
{
    public partial class Singup : Form
    {
        public Singup()
        {
            InitializeComponent();
        }

        private void Singup_Load(object sender, EventArgs e)
        {

        }

        private void btn_singup_Click(object sender, EventArgs e)
        {
            string unm, pnm, sql, EmailId, gender;
            unm = txt_singup_user.Text;
            pnm = txt_singup_password.Text;
            //int DOB = Convert.ToInt32(Date_Of_Birth.Text);
            EmailId = txt_email_id.Text;
            gender = cmbo_gender.Text;

            sql = "insert into user_profile values('" + unm + "','" + pnm + "','" + EmailId + "','" + gender + "')";
            try
            {
                myconnect.cmd = new SqlCommand(sql, myconnect.con);
                myconnect.cmd.ExecuteNonQuery();
                // MessageBox.Show("sing up successfully");
                new login().Show();
                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show("error " + exp.Message);
            }
        }

        private void date_of_birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logFrom = new login();
            logFrom.ShowDialog();
        }

        private void txt_email_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
