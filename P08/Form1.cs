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
        Font smallfont = new Font(,textbo1.font.name 12);
        Font mediumfont = new Font("Arial", 20);

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
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
        }
    }
}
