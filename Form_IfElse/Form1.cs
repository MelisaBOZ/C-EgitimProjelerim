using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pasword_Txb_TextChanged(object sender, EventArgs e)
        {
            Pasword_Txb.PasswordChar = '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserName_Txb.Text;
                string password = Pasword_Txb.Text;
                if (username=="admin")
                {
                    MessageBox.Show("Login succcesful");
                }
                else
                {
                    MessageBox.Show("Incorrect entry");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorret entry");

            }
        }
    }
}
