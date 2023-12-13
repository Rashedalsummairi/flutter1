using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Super : Form
    {
        public Super()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multipliction M = new Multipliction();
            M.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DES d = new DES();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vigner v = new Vigner();
            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RSA R = new RSA();
            R.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Alqeiser q = new Alqeiser();
            q.Show();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            RS4 s = new RS4();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decoding d = new decoding();
            d.Show();
        }
    }
}