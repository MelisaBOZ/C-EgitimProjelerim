using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            add();
            add(6, 9);
        }
        void add()
        {
            int firstnumber = 10;
            int lastnumber = 15;
            int conclusioun = firstnumber + lastnumber;
            MessageBox.Show("Method 1 : " + conclusioun.ToString());
        }

        // Geriye değer döndürmeyen ve parametre alan metot ; 

        int x, y;
        void add(int x, int y)
        {

            
            int add = x + y;

            MessageBox.Show("Metot 2 : " + add.ToString());
        }
        string UserLogin(string name, string lastname, string year)
        {

            int age = DateTime.Now.Year - Convert.ToInt32(year);

            return string.Format("Dear {0} {1} your age {2}", name, lastname.ToUpper(), age);

        }

        string informations()
        {

            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string year = textBox3.Text;

            int age = DateTime.Now.Year - Convert.ToInt32(year);
            return "Dear " + name + " " + lastname.ToUpper() + " your age : " + age;

           
        }
        void UserLogin()
        {
            MessageBox.Show("is null");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(informations());
    
            MessageBox.Show(UserLogin(textBox1.Text, textBox2.Text, textBox3.Text));
            UserLogin();
        }
    }
}
