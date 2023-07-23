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
    public partial class login_success : Form
    {
        public login_success()
        {
            InitializeComponent();
        }

        private void login_success_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm1 = new login();   
            frm1.ShowDialog();
        }
    }
}
