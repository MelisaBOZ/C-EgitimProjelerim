using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Struct
{
    class SelectedClassMiras : BaseClass
    {
        sealed protected override void GetUser()
        {
            MessageBox.Show("User'i getiriyorum...");
        }

        protected override void GetUser2()
        {
            MessageBox.Show("User2'yi getiriyorum...");
        }
    }
}
