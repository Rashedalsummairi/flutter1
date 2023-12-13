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
    public partial class Vigner : Form
    {
        public Vigner()
        {
            InitializeComponent();
        }
        String Arabic = "ابتثجحخدذرزسشصضطظعغفقكلمنهوي";
        String Cap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String Small = "abcdefghijklmnopqrstuvwxyz";


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] plain = plaintext.Text.ToCharArray();
            String Skey = key.Text;
            while (key.Text.Length < plaintext.Text.Length)
            {
                key.Text += Skey;
            }
            char[] ckey = key.Text.ToCharArray();
            if (Lang.SelectedItem == "أ ب ت")
            {

                for (int i = 0; i < plain.Length; i++)
                {
                    if (Arabic.Contains(plain[i]))
                    {
                        int c = (Arabic.IndexOf(plain[i]) + Arabic.IndexOf(ckey[i])) % Arabic.Length;
                        ciphertext.Text += Arabic[c];
                    }
                    else
                    {
                        ciphertext.Text += plain[i];
                    }
                }

            }
            else if (Lang.SelectedItem == "ABC")
            {

                for (int i = 0; i < plain.Length; i++)
                {
                    if (Cap.Contains(plain[i]))
                    {
                        int c = (Cap.IndexOf(plain[i]) + Cap.IndexOf(ckey[i])) % Cap.Length;
                        ciphertext.Text += Cap[c];
                    }
                    else
                    {
                        ciphertext.Text += plain[i];
                    }
                }
            }
            else if (Lang.SelectedItem == "abc")
            {

                for (int i = 0; i < plain.Length; i++)
                {
                    if (Small.Contains(plain[i]))
                    {
                        int c = (Small.IndexOf(plain[i]) + Small.IndexOf(ckey[i])) % Small.Length;
                        ciphertext.Text += Small[c];
                    }
                    else
                    {
                        ciphertext.Text += plain[i];
                    }
                }
            }

        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            char[] cipher = ciphertext.Text.ToCharArray();
            char[] plain = plaintext.Text.ToCharArray();
            String Skey = key.Text;
            while (key.Text.Length < plaintext.Text.Length)
            {
                key.Text += Skey;
            }
            char[] ckey = key.Text.ToCharArray();
            if (Lang.SelectedItem == "أ ب ت")
            {
                for (int i = 0; i < cipher.Length; i++)
                {
                    if (Arabic.Contains(cipher[i]))
                    {
                        int p = (Arabic.IndexOf(cipher[i]) - Arabic.IndexOf(ckey[i])) % Arabic.Length;
                        if (p < 0)
                            p += Arabic.Length;
                        plainafter.Text += Arabic[p];
                    }
                    else
                    {
                        plainafter.Text += cipher[i];
                    }
                }
            }
            else if (Lang.SelectedItem == "ABC")
            {
                for (int i = 0; i < cipher.Length; i++)
                {
                    if (Cap.Contains(cipher[i]))
                    {
                        int p = (Cap.IndexOf(cipher[i]) - Cap.IndexOf(ckey[i])) % Cap.Length;
                        if (p < 0)
                            p += Cap.Length;
                        plainafter.Text += Cap[p];
                    }
                    else
                    {
                        plainafter.Text += cipher[i];
                    }
                }
            }
            else if (Lang.SelectedItem == "abc")
            {
                for (int i = 0; i < cipher.Length; i++)
                {
                    if (Small.Contains(cipher[i]))
                    {
                        int p = (Small.IndexOf(cipher[i]) - Small.IndexOf(ckey[i])) % Small.Length;
                        if (p < 0)
                            p += Small.Length;
                        plainafter.Text += Small[p];
                    }
                    else
                    {
                        plainafter.Text += cipher[i];
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plaintext.Clear();
            ciphertext.Clear();
            key.Clear();
            plainafter.Clear();
            
        }
    }
}
