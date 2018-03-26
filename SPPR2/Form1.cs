using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPR2
{
    public partial class Form1 : Form
    {
        CriterionSolver cSolver = new CriterionSolver();
        Boolean _isProfit = false;

        public Form1()
        {
            InitializeComponent();
            DataGridView1.Rows[0].HeaderCell.Value = "Вариант 1";
            DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            


            DataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridView2.Rows.Add("Максимакса", "");
            DataGridView2.Rows.Add("Вальда", "");
            DataGridView2.Rows.Add("Минимального риска Сэвиджа", "");
            DataGridView2.Rows.Add("Пессемизма-оптимизма Гурвица", "");
            DataGridView2.Rows.Add("Лапласа", "");
            DataGridView2.AllowUserToAddRows = false;
            DataGridView2.AllowUserToDeleteRows = false;
            for (int i = 0; i < this.DataGridView1.Rows.Count; i++)
            {
                DataGridView1.Rows[i].Resizable = DataGridViewTriState.True;
            }

            LabelCell.Visible = true;
            LabelRow.Visible = true;
            RowCounter.Visible = true;
            CellCounter.Visible = true;
            Size.Visible = true;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            CreateMatrix.Visible = true;
            ButtonAddColumn.Visible = false;
            ButtonDeleteColumn.Visible = false;
            ButtonDeleteRow.Visible = false;
            ButtonAddRow.Visible = false;
        }

        private void buttonAddColumn_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col =
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Среда №" + (DataGridView1.Columns.Count + 1),
                    Resizable = DataGridViewTriState.True,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
            DataGridView1.Columns.Add(col);
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add();
            
            for (int i = 0; i < this.DataGridView1.Rows.Count; i++)
            {
                DataGridView1.Rows[i].HeaderCell.Value = "Вариант " + (i+1);
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                _isProfit = true;
            }
            if (radioButton2.Checked)
            {
                _isProfit = false;
            }

            var data = cSolver.solveTask(DataGridView1, _isProfit, Double.Parse(textBox1.Text));
            insertResultsIntoTable(data);



        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < this.DataGridView1.Rows.Count; i++)
            {
                DataGridView1.Rows[i].HeaderCell.Value = "Вариант " + (i + 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double result = 0;
            if (Double.TryParse(textBox1.Text, out result) && result>=0 && result<=1)
            {
                buttonGo.Enabled = true;
            }
            else
            {
                buttonGo.Enabled = false;
            }
        }

        private void insertResultsIntoTable(Dictionary<string, string> data)
        {
            foreach (DataGridViewRow row in DataGridView2.Rows)
            {
                if (row.Index == DataGridView2.Rows.Count - 1) continue;
                if (row.Cells[0].Value.ToString() == "Максимакса") row.Cells[1].Value = data["Максимакса"];
                if (row.Cells[0].Value.ToString() == "Вальда") row.Cells[1].Value = data["Вальда"];
                if (row.Cells[0].Value.ToString() == "Минимального риска Сэвиджа") row.Cells[1].Value = data["Максимакса"];
                if (row.Cells[0].Value.ToString() == "Пессемизма-оптимизма Гурвица") row.Cells[1].Value = data["Гурвица"];
                if (row.Cells[0].Value.ToString() == "Лапласа") row.Cells[1].Value = data["Лапласа"];
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Columns.Count > 1)
            {
                DataGridView1.Columns.Remove(DataGridView1.Columns[DataGridView1.Columns.Count - 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count > 2)
            {
                DataGridView1.Rows.Remove(DataGridView1.Rows[DataGridView1.Rows.Count - 2]);
            }

            for (var i = 0; i < DataGridView1.Rows.Count; i++)
            {
                DataGridView1.Rows[i].HeaderCell.Value = "Вариант " + (i + 1);
            }
        }

        private void Drawing()
        {
            for (var i = 0; i < DataGridView1.Rows.Count; i++)
            {
                DataGridView1.Rows[i].HeaderCell.Value = "Вариант " + (i + 1);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow
                row in DataGridView1.Rows)
            {
                foreach (DataGridViewCell rowCell in row.Cells)
                {
                    rowCell.Value = "";
                }
            }
        }

        private void FreeStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                LabelCell.Visible = false;
                LabelRow.Visible = false;
                RowCounter.Visible = false;
                CellCounter.Visible = false;
                Size.Visible = false;
                DataGridView1.AllowUserToAddRows = true;
                DataGridView1.AllowUserToDeleteRows = true;
                CreateMatrix.Visible = false;
                ButtonAddColumn.Visible = true;
                ButtonDeleteColumn.Visible = true;
                ButtonDeleteRow.Visible = true;
                ButtonAddRow.Visible = true;
            }
            else
            {
                LabelCell.Visible = true;
                LabelRow.Visible = true;
                RowCounter.Visible = true;
                CellCounter.Visible = true;
                Size.Visible = true;
                DataGridView1.AllowUserToAddRows = false;
                DataGridView1.AllowUserToDeleteRows = false;
                CreateMatrix.Visible = true;
                ButtonAddColumn.Visible = false;
                ButtonDeleteColumn.Visible = false;
                ButtonDeleteRow.Visible = false;
                ButtonAddRow.Visible = false;
            }
        }

        private void RowCounter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateMatrix_Click(object sender, EventArgs e)
        {
        }
    }
}
