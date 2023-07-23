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
    public partial class GetUserName : Form
    {
        public GetUserName()
        {
            InitializeComponent();
        }

        private void GetUserName_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logFrom = new login();
            logFrom.ShowDialog();
        }
    }
}
