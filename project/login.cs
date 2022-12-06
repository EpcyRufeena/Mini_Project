using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class login : Form
    {
        public static string Dno;
        public static string password;
        public static string msg;
        string email = string.Empty;
        public login()
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
                string query = "INSERT INTO login_details(Dno,Pwd)VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = con;
                sqlcom.CommandText = "select Gmail from student_details where Dno='" + textBox1.Text + "'";
                email = sqlcom.ExecuteScalar().ToString();
                sqlcom.CommandText = "select Dno from student_details where Dno='" + textBox1.Text + "'";
                
                Dno = sqlcom.ExecuteScalar().ToString();
               
                sqlcom.CommandText = "select Pwd from student_details where Dno='" + Dno+ "'";
                password =sqlcom.ExecuteScalar().ToString();

                sqlcom.ExecuteNonQuery();
                if (textBox1.Text == Dno&&textBox2.Text==password)
                {
                    MessageBox.Show("Login Successfull");

                    studentdet stud = new studentdet();
                    stud.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Details");
                }
               
                string message= getIPaddress();
                Alertmsg(message);

                studentdet studdet = new studentdet();
                studdet.Show();
            }
        }
        public string getIPaddress()
        {
            string hostname = Dns.GetHostName();
            string IP=Dns.GetHostByName(hostname).AddressList[0].ToString();
            msg="Date time="+DateTime.Now.ToString()+"\n+"+"IP Address="+IP;
            return msg;       
        }
        public void Alertmsg(string str)
        {
            MailMessage mesg = new MailMessage();
            mesg.From = new MailAddress(email);
            mesg.To.Add(email);
            mesg.Subject = "Alert Message";
            mesg.Body = msg;
            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntcd = new NetworkCredential();
            ntcd.UserName = "epcyrufeena268@gmail.com";
            ntcd.Password = "niodyxybpkfqkxrp";
            smt.Credentials = ntcd;
            smt.EnableSsl = true;
            smt.Port = 587;
            smt.Send(mesg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 home = new Form1();
            //home.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
