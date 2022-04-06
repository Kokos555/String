using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
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
            string cele_veta = textBox1.Text;
            slovo = textBox1.Text;//Ahoj  jak se mas
            slovo = slovo.Trim();
            int i = 0;
            while (i < slovo.Length-1)
            {
                if (slovo[i] == ' '&&slovo[i+1]==' ')
                {
                    slovo = slovo.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            MessageBox.Show(string.Format("({0})=({1}) ", cele_veta, slovo));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cele_veta = textBox1.Text;
            slovo = textBox1.Text;//Ahoj  jak se mas
            slovo = slovo.Trim();
            //slovo = slovo.Replace(" ", "");
            MessageBox.Show(string.Format("({0})=({1}) ", cele_veta, slovo));
        }
    }
}
