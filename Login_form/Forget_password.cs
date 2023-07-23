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
    public partial class Forget_password : Form
    {
        public Forget_password()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            new SetPassword().Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Forget_password_Load(object sender, EventArgs e)
        {
            myconnect.connect();
        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logFrom = new login();
            logFrom.ShowDialog();
        }
    }
}
