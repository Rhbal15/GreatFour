using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPR2.Action
{
    interface Action
    {
        void Working(DataGridView data,object[] parameters);
        void Canceling();
    }
}
