using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_TimerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

      
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Button move = new Button();
            move.Width = 70;
            move.Height = 30;
            move.Text = "Move Button";
            Random rnd = new Random();
            move.Location = new Point(rnd.Next(350), rnd.Next(350));
            move.Parent = this;
        }
    }
}
