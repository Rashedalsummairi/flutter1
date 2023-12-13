using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class RS4 : Form
    {
        public RS4()
        {
            InitializeComponent();
        }

        private void RS4_Load(object sender, EventArgs e)
        {

        }
        string rs4_encrypt()
        {
            StringBuilder plain = new StringBuilder(textBox1.Text);
            StringBuilder k = new StringBuilder(keytxt.Text);
            char[] key = new char[plain.Length];
            var s = new byte[256];
            for (int i = 0; i < s.Length; i++)
            {

                s[i] = (byte)i;
            }
            int j = 0;
            byte swap_tmp;
            for (int i = 0; i < 256; i++)
            {

                j = (j + s[i] + k[i % k.Length]) % 256;

                swap_tmp = s[i];
                s[i] = s[j];
                s[j] = swap_tmp;

            }
            j = 0;
            for (int i = 0; i < plain.Length; )
            {
                i++;
                j = (j + s[i]) % 256;
                swap_tmp = s[i];
                s[i] = s[j];
                s[j] = swap_tmp;
                key[i - 1] = (char)(s[(int)(s[i] + s[j]) % 256]);
                plain[i - 1] = (char)((byte)plain[i - 1] ^ (byte)key[i - 1]);

            }

            string result = plain.ToString();
            return result;
        }
        string rs4_decrypt()
        {
            StringBuilder cipher = new StringBuilder(textBox2.Text);
            StringBuilder k = new StringBuilder(keytxt.Text);
            char[] key = new char[cipher.Length];
            var s = new byte[256];
            for (int i = 0; i < s.Length; i++)
            {

                s[i] = (byte)i;
            }
            int j = 0;
            byte swap_tmp;
            for (int i = 0; i < 256; i++)
            {

                j = (j + s[i] + k[i % k.Length]) % 256;

                swap_tmp = s[i];
                s[i] = s[j];
                s[j] = swap_tmp;

            }
            j = 0;
            for (int i = 0; i < cipher.Length; )
            {
                i++;
                j = (j + s[i]) % 256;
                swap_tmp = s[i]; 
                s[i] = s[j];
                s[j] = swap_tmp;
                key[i - 1] = (char)(s[(int)(s[i] + s[j]) % 256]);
                cipher[i - 1] = (char)((byte)cipher[i - 1] ^ (byte)key[i - 1]);

            }
            string result = cipher.ToString();
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2 .Text= rs4_encrypt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = rs4_decrypt();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void keytxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
