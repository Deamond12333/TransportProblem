﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportProblem
{
    public partial class resultForm : Form
    {
        public resultForm(int[,] result, int _cost, List<List<Potencial>> potencials)
        {
            InitializeComponent();

            data.ColumnCount = result.GetUpperBound(1) + 2;
            data.RowCount = result.GetUpperBound(0) + 2;

            foreach (DataGridViewColumn column in data.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < data.RowCount-1; i++)
            {
                data.Rows[i].HeaderCell.Value = "A" + (i + 1);
                data.Rows[i].Height = data.Height/(data.RowCount+1);

            }
            data.Rows[data.RowCount - 1].HeaderCell.Value = "V";
            data.Rows[data.RowCount - 1].Height = data.Height / (data.RowCount+1);

            for (int i = 0; i < data.ColumnCount-1; i++)
            {
                data.Columns[i].HeaderCell.Value = "B" + (i+1);
                data.Columns[i].Width = data.Width / (data.ColumnCount+1);
            }
            data.Columns[data.ColumnCount - 1].HeaderCell.Value = "U";
            data.Columns[data.ColumnCount - 1].Width = data.Width/(data.ColumnCount+1);

            for (int i = 0; i < data.RowCount-1; ++i)
            {
                for (int j = 0; j < data.ColumnCount-1; ++j)
                {
                    data[j, i].Value = result[i, j].ToString();
                }
            }
            
            for (int i = 0; i < data.RowCount - 1; ++i)
            {
                foreach (Potencial p in potencials[0])
                    if (p.getIndex() == i) data[data.ColumnCount - 1, i].Value = potencials[0][i].getValue().ToString();
            }

            for (int i = 0; i < data.ColumnCount - 1; ++i)
            {
                foreach (Potencial p in potencials[1])
                    if (p.getIndex() == i) data[i, data.RowCount - 1].Value = potencials[1][i].getValue().ToString();
            }
            
            cost.Text = "Общая стоимость: " + _cost;
        }
    }
}
