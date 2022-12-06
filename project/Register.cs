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
    public partial class Register : Form
    {             
        public static string name;
        public static string dno;
        public static string password;
        public static string confirmpassword;
        public static string gender;
        public static long phone;
        public static string gmail;
        public static string dob;
        public static string datetime;

       
        
        public Register()
        {
            InitializeComponent();
           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please fill in the blanks");
            }
            
            //name = textBox1.Text;
            //dno = textBox2.Text;
            //password = textBox3.Text;
            //confirmpassword = textBox4.Text;
            if (radioButton1.Checked == true)
            {
                gender = "MALE";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "FEMALE";
            }
            dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");;
            phone = long.Parse(textBox5.Text);
            gmail = textBox6.Text;
            

           
            //if (password != confirmpassword)
            //{
                  
            //    label9.Enabled = true;
            //}
            //else if(password== confirmpassword)
            //{
            //    label9.Enabled = false;
            //}
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
                string query = "INSERT INTO student_details(Name,Dno,Pwd,Confirmpwd,Gender,Dob,Phone,Gmail,adds)VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+gender
+"','"+dob+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')";
                SqlCommand sqlcomm = new SqlCommand(query,con);
                try
                {
                    
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


           
            //regdet reg = new regdet();
            //reg.Show();

            activation act = new activation();
            act.Show();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            gender = "";
            dob = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //Environment.Exit(1);
        }
    
        }
    }

