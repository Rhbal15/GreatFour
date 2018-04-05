using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPPR2.Entity;

namespace SPPR2
{
    class CriterionSolver
    {
        Dictionary<string, MethodInfo> _results = new Dictionary<string, MethodInfo>();
        Boolean _isProfit = false;
        Double _optimisticKoef;

        public Dictionary<string, MethodInfo> solveTask(DataGridView data, Boolean isProfit, double optimisticKoef)
        {
            _isProfit = isProfit;
            _optimisticKoef = optimisticKoef;
            solveMaximax(data);
            solveValda(data);
            solveLaplas(data);
            solveGurvitz(data);
            solveSavidg(data);

            return _results;
        }

        public void solveMaximax(DataGridView data)
        {
            Double temp;
            string rowName = "Нет результата";
            if (_isProfit) temp = Double.MinValue; else temp = Double.MaxValue;

            for (int i = 0; i < data.Columns.Count; i++ )
            {
                for (int j = 0; j < data.Rows.Count; j++)
                {
                    Double doubleValueCell;
                    if (data[i, j].Value == null) continue;
                    if (!Double.TryParse(data[i, j].Value.ToString(), out doubleValueCell)) continue;
                    
                    if (_isProfit && doubleValueCell > temp)
                    {
                        temp = doubleValueCell;
                        rowName = data.Rows[j].HeaderCell.Value.ToString();
                    }
                    if (!_isProfit && doubleValueCell < temp)
                    {
                        temp = doubleValueCell;
                        rowName = data.Rows[j].HeaderCell.Value.ToString();
                    }
                }
            }

            if (_results.ContainsKey("Максимакса"))
            {
                _results["Максимакса"].Option = rowName;
                _results["Максимакса"].Value = temp;
            }
            else
            {
                _results.Add("Максимакса", new MethodInfo {Option = rowName, Value = temp});
            }      
        }

        public void solveValda(DataGridView data)
        {
            Dictionary<string, Double> listOfNumbers = new Dictionary<string, Double> { };

            Double temp = 0;
            String rowName = "Нет результата";
            

            for (int j = 0; j < data.Rows.Count - 1; j++)
            {
                if (_isProfit) temp = Double.MaxValue; else temp = Double.MinValue;
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    Double doubleValueCell;
                    if (data[i, j].Value == null) continue;
                    if (!Double.TryParse(data[i, j].Value.ToString(), out doubleValueCell)) continue;

                    if (_isProfit && doubleValueCell < temp)
                    {
                        temp = doubleValueCell;
                        rowName = data.Rows[j].HeaderCell.Value.ToString();
                    }
                    if (!_isProfit && doubleValueCell > temp)
                    {
                        temp = doubleValueCell;
                        rowName = data.Rows[j].HeaderCell.Value.ToString();
                    }

                }
                
                if (listOfNumbers.ContainsKey(rowName))
                {
                    listOfNumbers[rowName] = temp;
                }
                else
                {
                    listOfNumbers.Add(rowName, temp);
                }
            }

            Double perem = 0;
            if (_isProfit) perem = Double.MinValue; else perem = Double.MaxValue;
            foreach (KeyValuePair<string, Double> keyValue in listOfNumbers)
            {
                if (_isProfit)
                {
                    
                    if (keyValue.Value > perem)
                    {
                        perem = keyValue.Value;
                        rowName = keyValue.Key;
                    }
                }
                if (!_isProfit)
                {
                    
                    if (keyValue.Value < perem)
                    {
                        perem = keyValue.Value;
                        rowName = keyValue.Key;
                    }
                }
            }

            if (_results.ContainsKey("Вальда"))
            {
                _results["Вальда"].Option = rowName;
                _results["Вальда"].Value = perem;
            }
            else
            {
                _results.Add("Вальда", new MethodInfo{Option = rowName,Value = perem});
            }
        }

        public void solveLaplas(DataGridView data)
        {
            Dictionary<string, double> listOfSredneeArifm = new Dictionary<string, double> { };
            var rowName = "Нет результата";
            for (int i = 0; i < data.Rows.Count; i++)
            {
                double sum = 0;
                int countCells = 0;
                for (int j = 0; j < data.Columns.Count - 1; j++)
                {

                    Double doubleValueCell;
                    if (data[j, i].Value == null) continue;
                    if (!Double.TryParse(data[j, i].Value.ToString(), out doubleValueCell)) continue;

                    sum += doubleValueCell;
                    countCells++;

                    rowName = data.Rows[i].HeaderCell.Value.ToString();
                }
                if (countCells == 0) continue;
                if (listOfSredneeArifm.ContainsKey(rowName))
                {
                    listOfSredneeArifm[rowName] = sum / countCells;
                }
                else
                {
                    listOfSredneeArifm.Add(rowName, sum / countCells);
                }

                
            }

            double perem = 0;
            if (_isProfit) perem = Double.MinValue; else perem = Double.MaxValue;
            foreach (KeyValuePair<string, double> keyValue in listOfSredneeArifm)
            {
                if (_isProfit)
                {

                    if (keyValue.Value > perem)
                    {
                        perem = keyValue.Value;
                        rowName = keyValue.Key;
                    }
                }
                if (!_isProfit)
                {

                    if (keyValue.Value < perem)
                    {
                        perem = keyValue.Value;
                        rowName = keyValue.Key;
                    }
                }
            }

            if (_results.ContainsKey("Лапласа"))
            {
                _results["Лапласа"].Option = rowName;
                _results["Лапласа"].Value = perem;
            }
            else
            {
                _results.Add("Лапласа", new MethodInfo { Option = rowName, Value = perem });
            }

        }

        public void solveGurvitz(DataGridView data)
        {
            string headerRow = "Нет результата";
            Dictionary<string, double> ress = new Dictionary<string, double> { };
            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.Index == data.Rows.Count - 1) continue;
                Double minInRow = Double.MaxValue;
                Double maxInRow = Double.MinValue;
                foreach (DataGridViewCell cell in row.Cells)
                {

                    Double doubleValueCell;
                    if (cell.Value == null) continue;
                    if (!Double.TryParse(cell.Value.ToString(), out doubleValueCell)) continue;

                    if (doubleValueCell > maxInRow) maxInRow = doubleValueCell;
                    if (doubleValueCell < minInRow) minInRow = doubleValueCell;

                    
                }

                headerRow = row.HeaderCell.Value.ToString();
                Double resultKoef = 0;
                if (_isProfit)
                {
                    resultKoef = _optimisticKoef * maxInRow + (1 - _optimisticKoef) * minInRow;
                }
                if (!_isProfit)
                {
                    resultKoef = _optimisticKoef * minInRow + (1 - _optimisticKoef) * maxInRow;
                }
                
                if (ress.ContainsKey(headerRow))
                {
                    ress[headerRow] = resultKoef;
                }
                else
                {
                    ress.Add(headerRow, resultKoef);
                }
            }

            Double tempMaxValue = Double.MinValue;
            Double tempMinValue = Double.MaxValue;
            foreach (KeyValuePair<string, double> keyValue in ress)
            {
                if (_isProfit)
                {
                    if (keyValue.Value > tempMaxValue)
                    {
                        tempMaxValue = keyValue.Value;
                        headerRow = keyValue.Key;
                    }
                }
                if (!_isProfit)
                {
                    if (keyValue.Value < tempMinValue)
                    {
                        tempMinValue = keyValue.Value;
                        headerRow = keyValue.Key;
                    }
                }
            }

            if (_results.ContainsKey("Гурвица"))
            {
                _results["Гурвица"].Option = headerRow;
            }
            else
            {
                _results.Add("Гурвица", new MethodInfo { Option = headerRow, Value = tempMinValue });
            }

        }

        public void solveSavidg(DataGridView data)
        {
            Dictionary<string, double> ress = new Dictionary<string, double> { };
            DataGridView tempTable = new DataGridView();
            string headerRow = "Нет результата";

            foreach (DataGridViewColumn col in data.Columns)
            {
                DataGridViewTextBoxColumn colTemp = new DataGridViewTextBoxColumn
                {
                    HeaderText = col.HeaderText,
                    Name = col.Name,
                    Resizable = col.Resizable
                };

                tempTable.Columns.Add(colTemp);
            }
            foreach (var row in data.Rows)
            {
                tempTable.Rows.Add();

                for (int i = 0; i < tempTable.Rows.Count; i++)
                {
                    tempTable.Rows[i].HeaderCell.Value = "Вариант " + (i);
                }
            }

            for (int i = 0; i < data.Columns.Count; i++)
            {
                
                Double maxInCol = Double.MinValue;
                Double minInCol = Double.MaxValue;
                Double doubleValueCell = 0;
                for (int j = 0; j < data.Rows.Count; j++)
                {

                    
                    if (data[i, j].Value == null) continue;
                    if (!Double.TryParse(data[i, j].Value.ToString(), out doubleValueCell)) continue;

                    if (doubleValueCell > maxInCol && _isProfit) maxInCol = doubleValueCell;
                    if (doubleValueCell < minInCol && !_isProfit) minInCol = doubleValueCell;



                }
                for (int j = 0; j < data.Rows.Count; j++)
                {
                    if (data[i, j].Value == null) continue;

                    if (_isProfit)
                    {
                        tempTable[i, j].Value = Double.Parse(data[i, j].Value.ToString()) - maxInCol;
                    }
                    else
                    {
                        tempTable[i, j].Value = minInCol - Double.Parse(data[i, j].Value.ToString());
                    }
                    
                }
                
            }


            foreach (DataGridViewRow row in tempTable.Rows)
            {
                if (row.Index == data.Rows.Count - 1) continue;
                Double minInRow = Double.MaxValue;
                Double maxInRow = Double.MinValue;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Double doubleValueCell;
                    if (cell.Value == null) continue;
                    if (!Double.TryParse(cell.Value.ToString(), out doubleValueCell)) continue;

                    if (doubleValueCell > maxInRow) maxInRow = doubleValueCell;
                    if (doubleValueCell < minInRow) minInRow = doubleValueCell;
                }

                headerRow = row.HeaderCell.Value.ToString();
                

                
                if (_isProfit)
                {
                    if (ress.ContainsKey(headerRow))
                    {
                        ress[headerRow] = maxInRow;
                    }
                    else
                    {
                        ress.Add(headerRow, maxInRow);
                    }
                }

                if (!_isProfit)
                {
                    if (ress.ContainsKey(headerRow))
                    {
                        ress[headerRow] = minInRow;
                    }
                    else
                    {
                        ress.Add(headerRow, minInRow);
                    }
                }

            }


            Double tempMin = Double.MaxValue;
            Double tempMax = Double.MinValue;
            foreach (KeyValuePair<string, double> keyValue in ress)
            {
                if (_isProfit)
                {
                    if (keyValue.Value < tempMin)
                    {
                        tempMin = keyValue.Value;
                        headerRow = keyValue.Key;
                    }
                }
                if (!_isProfit)
                {
                    if (keyValue.Value > tempMax)
                    {
                        tempMax = keyValue.Value;
                        headerRow = keyValue.Key;
                    }
                }
            }


            if (_results.ContainsKey("Сэвиджа"))
            {
                _results["Сэвиджа"].Option = headerRow;
            }
            else
            {
                _results.Add("Сэвиджа", new MethodInfo { Option = headerRow, Value = tempMax });
            }


        }
    }
}
