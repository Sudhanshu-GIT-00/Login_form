using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Forget_user : Form
    {
        public Forget_user()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            new GetUserName().Show();
            this.Hide();
        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logFrom = new login();
            logFrom.ShowDialog();
        }
    }
}
