using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = Convert.ToInt32(textBox2.Text);
            cislo = cislo % 26;
            string text = textBox1.Text;
            string test = "";
            int znak;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    znak = text[i] + cislo;
                    if (znak > 'z')
                    {
                        znak -= 26;
                    }
                    test += Convert.ToChar(znak);
                }
                else if (text[i] >= 'A' && text[i] <= 'Z') 
                {
                    znak = text[i] + cislo;
                    if (znak > 'Z' )
                    {
                        znak -= 26;
                    }
                    test += Convert.ToChar(znak);
                }else
                {
                    test += text[i];
                }


            }
            textBox3.Text = test;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cislo = Convert.ToInt32(textBox2.Text);
            string text = textBox3.Text;
            string test = "";
            int znak;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    znak = text[i] - cislo;
                    if (znak < 'a')
                    {
                        znak += 26;
                    }
                    test += Convert.ToChar(znak);
                }
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    znak = text[i] - cislo;
                    if (znak < 'A')
                    {
                        znak += 26;
                    }
                    test += Convert.ToChar(znak);
                }
                else
                {
                    test += text[i];
                }


            }
            textBox1.Text = test;
        }
    }
}
