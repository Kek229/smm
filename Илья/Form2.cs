using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Илья
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            int a = 150;
            if (checkBox10.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int a = 35;
            if (checkBox9.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int a = 5;
            if (checkBox8.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int a = 50;
            if (checkBox7.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int a = 600;
            if (checkBox6.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int a = 20;
            if (checkBox5.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int a = 45;
            if (checkBox4.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int a = 2500;
            if (checkBox3.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int a = 3500;
            if (checkBox2.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int a = 3;
            if (checkBox1.Checked)
            {
                data.a = data.a + a;
            }
            else
            {
                data.a = data.a - a;
            }
            label2.Text = Convert.ToString(data.a + "Р");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
