using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string slova = textBox1.Text;
            int cifra = 0;
            int delka = slova.Length;
            for (int i = 0; i< slova.Length; i++)
            {
                if (slova[i] >= '0' && slova[i]<= '9')
                {
                    cifra = slova[i]-48;
                    break;
                }
            }
            if (delka < cifra)
            {
                MessageBox.Show(" ");
            }else if (cifra == 0)
            {
                MessageBox.Show(string.Format("{0}", slova));
            }else
            {
                delka -= cifra;
                slova = slova.Remove(delka, cifra);
                MessageBox.Show(string.Format("{0}",slova));
            }

        }//ahoj3petr
        //delka =9
        //6
    }
}
