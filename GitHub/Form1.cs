using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub
{
    public partial class Form1 : Form
    {
       
            public Form1()
            {
                InitializeComponent();
            }

           

        private char funcionDNI(int dni)
            {
                char letter = 'A';
                return letter;
            }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int dni = Convert.ToInt32(textBox1.Text);
            char letter = funcionDNI(dni);
            textBox2.Text = letter.ToString();
            Console.Write("Hola");
        }
    }
    }

