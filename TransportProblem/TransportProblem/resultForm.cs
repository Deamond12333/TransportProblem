using System;
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
        public resultForm(int[,] result, int _cost)
        {
            InitializeComponent();

            data.ColumnCount = result.GetUpperBound(1) + 1;
            data.RowCount = result.GetUpperBound(0) + 1;

            foreach (DataGridViewColumn column in data.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < data.RowCount; i++)
            {
                data.Rows[i].HeaderCell.Value = "A" + (i+1);
            }

            for (int i = 0; i < data.ColumnCount; i++)
            {
                data.Columns[i].HeaderCell.Value = "B" + (i+1);
                data.Columns[i].Width = 30;
            }

            for (int i = 0; i < data.RowCount; ++i)
            {
                for (int j = 0; j < data.ColumnCount; ++j)
                {
                    data[j, i].Value = result[i, j].ToString();
                }
            }

            cost.Text = "Общая стоимость: " + _cost;
        }
    }
}
