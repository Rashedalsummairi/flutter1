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
    public partial class Multipliction : Form
    {
        public Multipliction()
        {
            InitializeComponent();
        }

        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        private void button1_Click(object sender, EventArgs e)
        {
            if (key_textbox.SelectedItem == "")
            {
                MessageBox.Show("Please Enter the key");
                return;
            }
            char[] plain = plain_textbox.Text.ToUpper().ToCharArray();
            int key = Convert.ToInt32(key_textbox.SelectedItem);
            for (int i = 0; i < plain.Length; i++)
            {
                if (alpha.Contains(plain[i]))
                {
                    int cipher = (alpha.IndexOf(plain[i]) * key) % 26;
                    char c = alpha[cipher];
                    ciphertextbox.Text += c;
                }
                else
                {
                    ciphertextbox.Text += plain[i];
                }
            }
        }
        int dkey;

        private void button2_Click(object sender, EventArgs e)
        {

            if (key_textbox.SelectedItem == "")
            {
                MessageBox.Show("Please Enter the key");
                return;
            }
            char[] ciphertext = ciphertextbox.Text.ToUpper().ToCharArray();
            int key = Convert.ToInt32(key_textbox.SelectedItem);
            for (int i = 0; i <= 26; i++)
            {
                if ((key * i) % 26 == 1)
                {
                    dkey = i;
                }
            }
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (alpha.Contains(ciphertext[i]))
                {

                    int cipher = (alpha.IndexOf(ciphertext[i]) * dkey) % 26;
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
    }
    
}
