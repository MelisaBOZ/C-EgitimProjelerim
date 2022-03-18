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
    public partial class WhileLoop : Form
    {
        public WhileLoop()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            int i = 1;

            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            int index = 0;

            while (index < this.Controls.Count)
            {
                if (this.Controls[index] is Button)
                {
                    this.Controls[index].Width += 100;
                    this.Controls[index].Top += 20;
                }

                index++;
            }

        }
    }
}
