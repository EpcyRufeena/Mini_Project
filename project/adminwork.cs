using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace project
{
    public partial class adminwork : Form
    {
        public adminwork()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"connection Failed");
            }
            if (con.State == ConnectionState.Open)
            {
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = con;
                sqlcom.CommandText = "";

            }
            registerdet log= new registerdet();
            log.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"connection Failed");
            }
            if (con.State == ConnectionState.Open)
            {
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = con;
            }
            Logindet log = new Logindet();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentdet studdet = new studentdet();
            studdet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
