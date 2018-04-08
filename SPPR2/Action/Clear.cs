using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPR2.Action
{
    class Clear : Action
    {
        private int?[][] _history;
        private DataGridView _data;
        public void Working(DataGridView data, object[] parameters)
        {
            _data=data;
            _history = new int?[data.RowCount][];

            for (int i = 0; i < data.Rows.Count; i++)
            {
                _history[i] = new int?[data.ColumnCount];
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    if (data.Rows[i].Cells[j].Value != null)
                    {
                        var value = data.Rows[i]?.Cells[j]?.Value?.ToString();
                        try
                        {
                            _history[i][j] = int.Parse(value);
                        }
                        catch (FormatException)
                        {
                            _history[i][j] = null;
                        }
                    }
                }
            }

            foreach (DataGridViewRow
                row in data.Rows)
            {
                foreach (DataGridViewCell rowCell in row.Cells)
                {
                    rowCell.Value = "";
                }
            }
        }

        public void Canceling()
        {
            _data.Columns.Clear();
            _data.Rows.Clear();
            if (_history == null || _history.Length <= 0)
            {
                return;
            }

            for (int i = 0; i < _history[0].Length; i++)
            {
                DataGridViewTextBoxColumn col =
                    new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Среда №" + (_data.Columns.Count + 1),
                        Resizable = DataGridViewTriState.True,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    };
                _data.Columns.Add(col);

            }

            for (int j = 0; j < _history.Length; j++)
            {
                _data.Rows.Add();
            }

            for (int i = 0; i < _history.Length; i++)
            {
                for (int j = 0; j < _history[i].Length; j++)
                {
                    _data.Rows[i].Cells[j].Value = _history[i][j];
                }
            }
        }
    }
}
