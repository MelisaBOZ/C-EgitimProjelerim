using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_CharacterLimit
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void text_TextChanged(object sender, EventArgs e)
        {
            count=450;
            int HowManyCharacters = textnumber.Text.Length;
            int minus = count - HowManyCharacters;
            Characters_Number_lbl.Text = minus.ToString();
        }
    }
}
