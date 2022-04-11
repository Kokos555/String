using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tecka = "";
            string zalozni = "";
            string prvni_radek = "";
            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                string veta = textBox1.Lines[i];
                veta = veta.Trim();
                if (veta != "") { 
                    prvni_radek = veta;
                    if (checkBox1.Checked)
                    {
                        char pismeno = veta[0];
                        prvni_radek = char.ToUpper(pismeno) + veta.Substring(1);
                    }
                    if (checkBox2.Checked) {
                        if (veta[veta.Length - 1] != '.') {
                            tecka = ".";
                        }
                    }
                    zalozni += prvni_radek + tecka + Environment.NewLine;
                }
            }
            textBox1.Text = zalozni;
        }
    }
}
