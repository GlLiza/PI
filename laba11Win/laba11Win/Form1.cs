using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba11Win
{
    public partial class Form1 : Form
    {
        ServiceReference1.XXXServiceSoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new laba11Win.ServiceReference1.XXXServiceSoapClient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);
            textBoxRes.Text = Convert.ToString(client.Mul(x, y));
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);
            textBoxRes.Text = Convert.ToString(client.Sum(x,y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBoxX.Text);
            int y = Convert.ToInt32(textBoxY.Text);
            textBoxRes.Text = Convert.ToString(client.Sub(x, y));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = client.AddI(Convert.ToInt32(textBox4.Text)).ToString();

        }

        private void Set_Click(object sender, EventArgs e)
        {
            client.SetI(Convert.ToInt32(textBox1.Text));
        }

        private void Get_Click(object sender, EventArgs e)
        {
            textBox2.Text = client.GetI().ToString("D");
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            textBox3.Text = client.AddI(Convert.ToInt32(textBox4.Text)).ToString("D");
        }
    }
}
