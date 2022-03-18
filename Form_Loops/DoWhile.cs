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
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {

            value_Lb.Items.Clear();

            int i = 1;

            while (i <= 100)
            {
                value_Lb.Items.Add(i);
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            value_Lb.Items.Clear();
            int counter = 1;

            do
            {
               
                value_Lb.Items.Add(counter);
                counter++;

            } while (counter <= 100);
        }

        private void btnWhileIki_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            int counter = 5;

            while (counter > 0)
            {
                factorial *= counter;
                counter--;
            }

            MessageBox.Show(factorial.ToString());
        }

        private void btnDoWhileIki_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            int counter = 0;

            if (counter == 0)
            {
                MessageBox.Show(factorial.ToString());
            }

            do
            {
               

                factorial *= counter;
                counter--;

            } while (counter > 0);

            MessageBox.Show(factorial.ToString());
        }

        private void NextPage_btn_Click(object sender, EventArgs e)
        {
            ForLoop nextpage = new ForLoop();
            nextpage.Show();
            this.Hide();

        }
    }
}
