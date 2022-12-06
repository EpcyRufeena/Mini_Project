using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;


namespace project
{
    public partial class reset : Form
    {
        //string Dno;
        //string Pwd;
        string email;
        int OTP=0;
        public reset()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void reset_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Dno = textBox1.Text;
            string Pwd = textBox3.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.\\SQLEXPRESS;database=registration; integrated security=true;";

            try
            {
                con.Open();
                this.Text = "Connected Successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }


            if (con.State == ConnectionState.Open)
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = con;

                comm.CommandText = "select Gmail from student_details where Dno='" + textBox1.Text + "'";
                email = comm.ExecuteScalar().ToString();
                comm.CommandText = "update student_details set Pwd ='" + textBox3.Text + "' where Dno = '" + textBox1.Text + "'";
                comm.ExecuteNonQuery();

                MessageBox.Show("Password Reseted");
            }

            Random r = new Random();
            OTP = r.Next(100000, 1000000);
            
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(email);
            msg.To.Add(email);
            msg.Subject = "OTP Code";
            msg.Body = OTP.ToString();
            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntcd = new NetworkCredential();
            ntcd.UserName = "epcyrufeena268@gmail.com";
            ntcd.Password = "niodyxybpkfqkxrp";
            smt.Credentials = ntcd;
            smt.EnableSsl = true;
            smt.Port = 587;
            smt.Send(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
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
                sqlcom.CommandText = "select otp from student_details where Dno='" + textBox1.Text + "'";
                str = sqlcom.ExecuteScalar().ToString();
            }

            if (str == textBox2.Text)
            {
                MessageBox.Show("Password Reseted");
            }

        }

    }
}
