using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string slovo = textBox1.Text;
            string[] cele_slovo = slovo.Split(' ');
            for (int i = 0; i< cele_slovo.Length; i++) {
                if (cele_slovo[i].Any(char.IsDigit)) {
                    listBox1.Items.Add(cele_slovo[i]);
                }
            }
        }
    }
}
