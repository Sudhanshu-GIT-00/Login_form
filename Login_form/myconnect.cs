using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login_form
{
    internal class myconnect
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader rs;
        public static void connect()
        {
            try
            {
                con = new SqlConnection("Data Source=RAJA-AMAN-420\\SQLEXPRESS;Initial Catalog=main;Integrated Security=True");
                con.Open();
                MessageBox.Show("connection ok");
            }

            catch (Exception exp)
            {

                MessageBox.Show("connection field"+exp.Message);
                
            }

            
        }
    }
}
