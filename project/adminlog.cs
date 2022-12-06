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

namespace project
{
    public partial class adminlog : Form
    {
        public static string Adminid;
        public static string Pwd;
        public adminlog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin123" && textBox2.Text == "123456")
            {
                MessageBox.Show("Login successfull");

                adminwork log = new adminwork();
                log.Show();

            }
            else
            {
            MessageBox.Show("Invalid details");
            }



           
        }
    }
}
