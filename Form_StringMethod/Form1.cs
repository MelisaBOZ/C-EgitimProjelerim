using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_StringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Trim_Btn_Click(object sender, EventArgs e)
        {
            firstvalue_txb.Text = firstvalue_txb.Text.Trim();
            // firstvalue_txb.Text = firstvalue_txb.Text.Trim(' ', '+', '*', '\'');
            //firstvalue_txb.Text = firstvalue_txt.Text.TrimStart(); 
            //firstvalue_txb.Text = firstvalue_txb.Text.TrimEnd();

        }

        private void Eqals_Btn_Click(object sender, EventArgs e)
        {
            bool isthattrue = firstvalue_txb.Text.Equals(lastvalue_txb.Text, StringComparison.OrdinalIgnoreCase);
            string trueorfalse = isthattrue ? "true" : "false!";
            MessageBox.Show(trueorfalse);
        }

        private void Substring_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                firstvalue_txb.Text = firstvalue_txb.Text.Substring(2);
                lastvalue_txb.Text = lastvalue_txb.Text.Substring(1, 4);
            }
            catch (ArgumentOutOfRangeException a)
            {
                MessageBox.Show(a.ToString());

            }
        }

        private void Reverse_Btn_Click(object sender, EventArgs e)
        {
            string text = firstvalue_txb.Text.Reverse().ToString();
          
            MessageBox.Show(text);

            foreach (var index in text)
            {
                MessageBox.Show(index.ToString());
            }
        }

        private void IndexOf_Btn_Click(object sender, EventArgs e)
        {
            firstvalue_txb.Text = firstvalue_txb.Text.IndexOf('a').ToString(); 
           
            lastvalue_txb.Text = lastvalue_txb.Text.IndexOf('a', 3).ToString();
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            firstvalue_txb.Text = firstvalue_txb.Text.Remove(5);
            lastvalue_txb.Text = lastvalue_txb.Text.Remove(0,2);
        }

        private void Contains_Btn_Click(object sender, EventArgs e)
        {
            bool isthathere = firstvalue_txb.Text.Contains('a');
            MessageBox.Show(isthathere.ToString());
        }

        private void Replace_Btn_Click(object sender, EventArgs e)
        {
            firstvalue_txb.Text = firstvalue_txb.Text.Replace('a','i');
        }

        private void Split_Btn_Click(object sender, EventArgs e)
        {

            string[] text = firstvalue_txb.Text.Split();

            foreach (var textindex in text)
            {
                MessageBox.Show(textindex.ToString());
            }
        }

        private void ToUpper_Btn_Click(object sender, EventArgs e)
        {
            firstvalue_txb.Text = firstvalue_txb.Text.ToUpper();
            lastvalue_txb.Text = lastvalue_txb.Text.ToLower();
        }
    }
}
