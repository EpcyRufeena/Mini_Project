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
    public partial class activation : Form
    {
        string email = string.Empty;
        int OTP = 0;
        public activation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Random r = new Random();
             OTP = r.Next(100000, 1000000);
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
                sqlcom.CommandText = "select Gmail from student_details where Dno='"+textBox1.Text+"'";
                email= sqlcom.ExecuteScalar().ToString();

                sqlcom.CommandText="update student_details set otp ='"+OTP.ToString()+"' where Dno = '"+textBox1.Text+"'";
                sqlcom.ExecuteNonQuery();
            }
           
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
            string str=string.Empty;
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
                sqlcom.CommandText = "select otp from student_details where Dno='" + textBox1.Text + "'";
                str = sqlcom.ExecuteScalar().ToString();
            }

            if (str == textBox2.Text)
            {
                MessageBox.Show("Activation Successfully");
            }

        }

        private void activation_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
