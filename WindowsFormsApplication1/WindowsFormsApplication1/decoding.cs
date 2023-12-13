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
    public partial class decoding : Form
    {
        public decoding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plan = plaintxt.Text;
            string capher = null;
            for (int i = 0; i < plan.Length; i++)
            {
                if (plan.Substring(i, 1) == "a")
                    capher += "asw";
                else if (plan.Substring(i, 1) == "b")
                    capher += "gdi";
                else if (plan.Substring(i, 1) == "c")
                    capher += "bmb";
                else if (plan.Substring(i, 1) == "d")
                    capher += "jhk";
                else if (plan.Substring(i, 1) == "e")
                    capher += "bmf";
                else if (plan.Substring(i, 1) == "f")
                    capher += "ddg";
                else if (plan.Substring(i, 1) == "g")
                    capher += "mvh";
                else if (plan.Substring(i, 1) == "h")
                    capher += "hfj";

                else if (plan.Substring(i, 1) == "i")
                    capher += "fjj";
                else if (plan.Substring(i, 1) == "j")
                    capher += "kkk";
                else if (plan.Substring(i, 1) == "k")
                    capher += "gkv";
                else if (plan.Substring(i, 1) == "l")
                    capher += "hvk";
                else if (plan.Substring(i, 1) == "m")
                    capher += "fyj";
                else if (plan.Substring(i, 1) == "n")
                    capher += "fhjn";
                else if (plan.Substring(i, 1) == "o")
                    capher += "fho";
                else if (plan.Substring(i, 1) == "p")
                    capher += "fhp";
                else if (plan.Substring(i, 1) == "q")
                    capher += "fhq";
                else if (plan.Substring(i, 1) == "r")
                    capher += "fhr";
                else if (plan.Substring(i, 1) == "s")
                    capher += "fhj";
                else if (plan.Substring(i, 1) == "t")
                    capher += "fht";
                else if (plan.Substring(i, 1) == "u")
                    capher += "fhu";
                else if (plan.Substring(i, 1) == "v")
                    capher += "fhv";
                else if (plan.Substring(i, 1) == "w")
                    capher += "fhw";
                else if (plan.Substring(i, 1) == "x")
                    capher += "fhx";
                else if (plan.Substring(i, 1) == "y")
                    capher += "fhy";
                else if (plan.Substring(i, 1) == "z")
                    capher += "fhz";
                else {
                    capher += plan[i];
                }

            }
            ciphertxt.Text = capher;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string plan = ciphertxt.Text;
            string capher = null;
            for (int i = 0; i < plan.Length; i += 3)
            {
                if (plan.Substring(i, 3) == "asw")
                    capher += "a";
                else if (plan.Substring(i, 3) == "gdi")
                    capher += "b";
                else if (plan.Substring(i, 3) == "bmb")
                    capher += "c";
                else if (plan.Substring(i, 3) == "jhk")
                    capher += "d";
                else if (plan.Substring(i, 3) == "bmf")
                    capher += "e";
                else if (plan.Substring(i, 3) == "ddg")
                    capher += "f";
                else if (plan.Substring(i, 3) == "mvh")
                    capher += "g";
                else if (plan.Substring(i, 3) == "hfj")
                    capher += "h";
                else if (plan.Substring(i, 3) == "fjj")
                    capher += "i";
                else if (plan.Substring(i, 3) == "kkk")
                    capher += "j";
                else if (plan.Substring(i, 3) == "gkv")
                    capher += "k";
                else if (plan.Substring(i, 3) == "hvk")
                    capher += "l";
                else if (plan.Substring(i, 3) == "fyj")
                    capher += "m";
                else if (plan.Substring(i, 3) == "fhn")
                    capher += "n";
                else if (plan.Substring(i, 3) == "fho")
                    capher += "o";
                else if (plan.Substring(i, 3) == "fhp")
                    capher += "p";
                else if (plan.Substring(i, 3) == "fhq")
                    capher += "q";
                else if (plan.Substring(i, 3) == "fhr")
                    capher += "r";
                else if (plan.Substring(i, 3) == "fhj")
                    capher += "s";
                else if (plan.Substring(i, 3) == "fht")
                    capher += "t";
                else if (plan.Substring(i, 3) == "fhu")
                    capher += "u";
                else if (plan.Substring(i, 3) == "fhv")
                    capher += "v";
                else if (plan.Substring(i, 3) == "fhw")
                    capher += "w";
                else if (plan.Substring(i, 3) == "fhx")
                    capher += "x";
                else if (plan.Substring(i, 3) == "fhy")
                    capher += "y";
                else if (plan.Substring(i, 3) == "fhz")
                    capher += "z";
                else
                {
                    capher += plan[i];
                }
            }
            afterplaintxt.Text = capher;
        }
    }
}
