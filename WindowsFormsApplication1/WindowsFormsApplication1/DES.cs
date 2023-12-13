using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class DES : Form
    {
        public DES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key.Text.Length == inv.Text.Length)
                ciphertext.Text = Encryption();
            else
                MessageBox.Show("The Key length and the Inv length must be the same ");

            
        }
        public String Encryption()
        {
            DESCryptoServiceProvider dES = new DESCryptoServiceProvider();
            byte[] KEY = ASCIIEncoding.ASCII.GetBytes(key.Text);
            byte[] INV = ASCIIEncoding.ASCII.GetBytes(inv.Text);
            MemoryStream ms = new MemoryStream();
            ICryptoTransform transform = dES.CreateEncryptor(KEY, INV);
            CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(plaintext.Text);
            sw.Flush();
            cs.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            plainafter.Text = Decryption();
        }
        public String Decryption()
        {
            DESCryptoServiceProvider dES = new DESCryptoServiceProvider();
            byte[] KEY = ASCIIEncoding.ASCII.GetBytes(key.Text);
            byte[] INV = ASCIIEncoding.ASCII.GetBytes(inv.Text);
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(ciphertext.Text));
            ICryptoTransform transform = dES.CreateDecryptor(KEY, INV);
            CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Read);
            StreamReader sd = new StreamReader(cs);
            return sd.ReadToEnd();
        }

        private void DES_Load(object sender, EventArgs e)
        {

        }
    }
}
