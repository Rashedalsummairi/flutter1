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
    public partial class Alqeiser : Form
    {
        public Alqeiser()
        {
            InitializeComponent();
        }
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void button1_Click(object sender, EventArgs e)
        {

            char[] plain = plain_textbox.Text.ToUpper().ToCharArray();
            int key = Convert.ToInt32(keytxt.Text);
            for (int i = 0; i < plain.Length; i++)
            {
                if (alpha.Contains(plain[i]))
                {
                    int cipher = (alpha.IndexOf(plain[i]) + key) % 26;
                    char c = alpha[cipher];
                    ciphertextbox.Text += c;
                }
                else
                {
                    ciphertextbox.Text += plain[i];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            char[] ciphertext = ciphertextbox.Text.ToUpper().ToCharArray();
            int key = Convert.ToInt32(keytxt.Text);

            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (alpha.Contains(ciphertext[i]))
                {

                    int cipher = (alpha.IndexOf(ciphertext[i]) - key) % 26;
                    if (cipher < 0)
                    {
                        cipher += 26;
                    }
                    char c = alpha[cipher];
                    plainafter_textbox.Text += c;
                }
                else
                {
                    plainafter_textbox.Text += ciphertext[i];
                }
            }
        }

        private void Alqeiser_Load(object sender, EventArgs e)
        {

        }

        private void plain_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ciphertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plainafter_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void keytxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
