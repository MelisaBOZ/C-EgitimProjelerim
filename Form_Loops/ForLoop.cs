using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Loops
{
    public partial class ForLoop : Form
    {
        public ForLoop()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int value = 1; value <= 1000; value++)
            {
                listBox1.Items.Add(value);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int value = 1000; value >= 1; value--)
            {
                listBox1.Items.Add(value);
            }
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int value = 2; value <= 1000; value+=2)
            {
                listBox1.Items.Add(value);
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c + " - " + Convert.ToInt32(c));
     
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            int add=0;
            listBox1.Items.Clear();
            for (int i = 1; i < 101; i++)
            {
                add += i;
            }
            listBox1.Items.Add(add);
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            int EvenNumbers = 0;
            int SingleNumbers = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    EvenNumbers += i;
                }
                else
                {
                    SingleNumbers += i;
                }
            }

            int conclusion = (EvenNumbers - SingleNumbers) * (EvenNumbers - SingleNumbers);
            MessageBox.Show(conclusion.ToString());
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i >= 1950 && i <= 1970)
                {
                }
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }

            }
        }
    }
}
