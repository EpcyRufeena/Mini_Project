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
    public partial class studentdet : Form
    {
        login lg = new login();
        public studentdet()
        {
            InitializeComponent();
            
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
                MessageBox.Show(ex.Message, "connection Failed");
            }
            if (con.State == ConnectionState.Open)
            {
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = con;

            }
        }
              
        private void studentdet_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";
            //con.Open();
            //DataTable dt = new DataTable();                   
            //SqlDataAdapter adapt = new SqlDataAdapter("select*from stud_mark ", con);
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Environment.Exit(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";
            //try
            //{
            //    con.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message,"connection Failed");
            //}
            //if (con.State == ConnectionState.Open)
            //{
            //    SqlCommand sqlcom = new SqlCommand();
            //    sqlcom.Connection = con;
            //    sqlcom.CommandText = "select*from stud_mark";
            //}
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select*from student_details", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select*from stud_mark", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
    }
} 