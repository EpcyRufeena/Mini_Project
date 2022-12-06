using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminlog admin = new adminlog();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset reset = new reset();
            reset.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            activation act = new activation();
            act.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
