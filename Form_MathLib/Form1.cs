using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_MathLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Text = Math.PI.ToString();
        }

        private void abs_Btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Abs(-45).ToString();
        }

        private void Floor_Btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Floor(12.98).ToString();
        }

        private void Ceiling_btn_Click(object sender, EventArgs e)
        {

            this.Text = Math.Ceiling(12.18).ToString();
        }

        private void Round_Btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Round(12.49).ToString();
        }

        private void Truncate_btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Truncate(12.98).ToString();
          
        }

        private void Max_btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Max(45, 65).ToString();
        }

        private void Min_btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Min(45, 65).ToString();
        }

        private void Pow_Btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Pow(2, 3).ToString();
        }

        private void Sqrt_btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Sqrt(9).ToString();
        }

        private void Sign_Btn_Click(object sender, EventArgs e)
        {
            this.Text = Math.Sign(-42).ToString();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToInt32(textBox1.Text) < Convert.ToInt32((Convert.ToInt32(textBox2.Text) < (Convert.ToInt32(textBox3.Text)) ? textBox3.Text : textBox2.Text)) ? textBox1.Text : textBox2.Text;
        }
    }
}
