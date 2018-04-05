using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPR2.Action
{
    class PoolOfActions
    {
        private List<Action> pool = new List<Action>();

        public void Add(Action action,DataGridView data,object[] parameters)
        {
            pool.Add(action);
            action.Working(data,parameters);
        }

        public void Backing()
        {
            if (pool.Count - 1 < 0)
            {
                return;
            }
            var lastAction = pool[pool.Count - 1];
            lastAction.Canceling();
            pool.Remove(lastAction);
        }
    }
}
