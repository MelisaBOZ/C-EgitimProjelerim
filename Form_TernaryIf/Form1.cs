using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_TernaryIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abaolute_Value_btn_Click(object sender, EventArgs e)
        {
            try
            {
            int number = Convert.ToInt32(numbertextbox.Text);
            int absolutevalue;      

            absolutevalue = (number < 0) ? number *-1 : number;
            MessageBox.Show(" Absolute value of the entered number: " + absolutevalue);
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message);
            }
            catch (DivideByZeroException d)
            {
                MessageBox.Show(d.Message);
            }

            catch (Exception)
            {

                MessageBox.Show("Unknown error");
            }


        }
    }
}
