using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            int samo = 0;
            int souh = 0;
            int nepismen = 0;
            text = text.ToLower();
            foreach(char s in text)
            {
                if (samohlasky.Contains(s))
                {
                    samo++;
                }
                if (souhlasky.Contains(s))
                {
                    souh++;
                }
            }
            int delka_vety = text.Length;
            nepismen = delka_vety - (souh + samo);
            MessageBox.Show(string.Format("Věta: ({0}) obsahuje {1} samohlásek {2} souhlásek a {3} nepárových znaků",text,samo,souh,nepismen));
        }
    }
}
