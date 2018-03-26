using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPR2.Action
{
    class CreateMatrix : Action
    {
        private DataGridViewRow _history;
        public void Working(DataGridView data,object[] parameters)
        {
            int rowCounter, cellCounter;
            if (!Int32.TryParse(((TextBox)parameters[0]).Text, out rowCounter)) return;
            if (!Int32.TryParse(((TextBox)parameters[1]).Text, out cellCounter)) return;
            data.Columns.Clear();
            data.Rows.Clear();
            for (int i = 0; i < cellCounter; i++)
            {
                DataGridViewTextBoxColumn col =
                    new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Среда №" + (data.Columns.Count + 1),
                        Resizable = DataGridViewTriState.True,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    };
                data.Columns.Add(col);
            }
            for (int j = 0; j < rowCounter; j++)
            {
                data.Rows.Add();
            }
        }


        public void Canceling()
        {
            throw new NotImplementedException();
        }

        public void SaveHistory(DataGridView data)
        {
        }
    }
}
