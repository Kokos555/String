using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string slovo;
        private void button1_Click(object sender, EventArgs e)
        {
            slovo = textBox1.Text;
            string cele_slovo = textBox1.Text;
            int delka = slovo.Length;
            int i = 0;
            while (i<slovo.Length)
            {
                if (slovo[i] >= 'A' && slovo[i] <= 'Z')
                {
                    slovo = slovo.Remove(i, 1);
                }else
                {
                    i++;
                }
            }
            MessageBox.Show(string.Format("{0} = {1}", cele_slovo, slovo));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slovo = textBox1.Text;
            slovo = slovo.Replace("*", "");
            string cele_slovo = textBox1.Text;
            MessageBox.Show(string.Format("{0} = {1}", cele_slovo, slovo));
        }
    }
}
