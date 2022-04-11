using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font smallfont = new Font(textBox1.Font.Name, 12);
            Font mediumfont = new Font(textBox1.Font.Name, 20);
            string veta = textBox1.Text;
            int pocet = 0;
            string[] pocet_slov = veta.Split(' ');
            int max = 0;
            string slovo = "";
            if (radioButton1.Checked)
            {
                label1.Font = smallfont;
                label1.Text = veta;
            }
            else if (radioButton2.Checked)
            {
                label1.Font = mediumfont;
                label1.Text = veta;
            }
            else if (radioButton3.Checked)
            {
                label1.ForeColor = Color.Red;
            }else
            {
                label1.ForeColor = Color.Black;
            }
            if (checkBox1.Checked) {
                for (int i = 0; i < pocet_slov.Length; i++)
                {
                    if (pocet_slov[i] != "")
                    {
                        pocet++;
                    }
                }
                MessageBox.Show(string.Format("{0} = {1} slov", veta, pocet));
            }
            if (checkBox2.Checked) {
                for (int i = 0; i < pocet_slov.Length-1; i++) {
                    int pocet1 = pocet_slov[i].Length;
                    if (max < pocet1) {
                        max = pocet1;
                        slovo = pocet_slov[i];
                    }
                }
                MessageBox.Show(string.Format("Nejdelsi slovo je ({0}) a ma {1} pismen", slovo, max));
            }
        }
    }
}
