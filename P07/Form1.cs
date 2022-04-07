using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string pismena = "abcdefghijklmnopqrstuvwxyz";
            string veta = textBox2.Text; //ahoj | .- .... --- .---
            string[] veta_m = veta.Split(' ');
            string znak;
            string mo = "";
            for (int i = 0; i < veta_m.Length; i++)
            {
                znak = veta_m[i];
                for (int p = 0; p < morse.Length; p++)
                {
                    if (znak == morse[p])
                    {
                        mo += pismena[p];
                        break;
                    }
                }
                if (znak == "/")
                {
                    mo += " ";
                }
            }
            textBox1.Text = mo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string pismena = "abcdefghijklmnopqrstuvwxyz";
            string veta = textBox1.Text; //ahoj | .- .... --- .---
            veta = veta.ToLower();
            char znak;
            string mo = "";
            for (int i = 0; i < veta.Length; i++)
            {
                znak = veta[i];
                for (int p = 0; p < pismena.Length; p++)
                {
                    if (znak == pismena[p])
                    {
                        mo += morse[p];
                        mo += " ";
                        break;
                    }
                }
                if (znak == ' ')
                {
                    mo += " / ";
                }
            }
            textBox2.Text = mo;
        }
    }
}
