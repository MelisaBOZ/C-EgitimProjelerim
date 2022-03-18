using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_tryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstnumber = Convert.ToDouble(firstnumbertb.Text);
                double lastnumber = Convert.ToDouble(lastnumbertb.Text);
                double conclusion = firstnumber / lastnumber;
                conclusion_lbl.Text = conclusion.ToString();

            }
            catch (FormatException f )
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
           
            catch (Exception )
            {

                MessageBox.Show("Unknown error");
            }
        }
    }
}
