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
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
            File.WriteAllText(@"D:\information security project\publickey.xml", rsa.ToXmlString(false));
            File.WriteAllText(@"D:\information security project\‏‏privatekey.xml", rsa.ToXmlString(true));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(File.ReadAllText(@"D:\information security project\publickey.xml"));
            byte[] planarray = Encoding.Unicode.GetBytes(plaintxt.Text);
            byte[] cipherarray = rsa.Encrypt(planarray, false);
            ciphertxt.Text = Convert.ToBase64String(cipherarray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(File.ReadAllText(@"D:\information security project\‏‏privatekey.xml"));
            byte[] cipherarray = Convert.FromBase64String(ciphertxt.Text);
            byte[] planarray = rsa.Decrypt(cipherarray, false);
            plaintaftertxt.Text = Encoding.Unicode.GetString(planarray);
        }
    }
}
