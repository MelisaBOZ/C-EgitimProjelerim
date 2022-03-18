using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Struct
{
    class BaseClass
    {
        protected virtual void GetUser()
        {
            MessageBox.Show("Get User ANA Metodu.....");
        }

        protected virtual void GetUser2()
        {
            MessageBox.Show("Get User 2 ANA Metodu.....");
        }
    }
}
