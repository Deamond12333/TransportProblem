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
        private float[,] result;
        private int[,] tariff;
        private int money;
        private List<List<Potencial>> potencials;
        public resultForm(float[,] _result, int[,] _tariffs, int _cost, List<List<Potencial>> pot)
        {
            InitializeComponent();

            result = _result;
            tariff = _tariffs;
            money = _cost;
            potencials = pot;

            data.ColumnCount = result.GetUpperBound(1) + 2;
            data.RowCount = result.GetUpperBound(0) + 2;

            foreach (DataGridViewColumn column in data.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < data.RowCount - 1; i++)
            {
                data.Rows[i].HeaderCell.Value = "A" + (i + 1);
                data.Rows[i].Height = data.Height / (data.RowCount + 1);

            }
            data.Rows[data.RowCount - 1].HeaderCell.Value = "V";
            data.Rows[data.RowCount - 1].Height = data.Height / (data.RowCount + 1);

            for (int i = 0; i < data.ColumnCount - 1; i++)
            {
                data.Columns[i].HeaderCell.Value = "B" + (i + 1);
                data.Columns[i].Width = data.Width / (data.ColumnCount + 1);
            }
            data.Columns[data.ColumnCount - 1].HeaderCell.Value = "U";
            data.Columns[data.ColumnCount - 1].Width = data.Width / (data.ColumnCount + 1);
            repaint();
        }

        private void repaint()
        {
            for (int i = 0; i < data.RowCount - 1; ++i)
            {
                for (int j = 0; j < data.ColumnCount - 1; ++j)
                {
                    data[j, i].Value = result[i, j];
                }
            }

            for (int i = 0; i < data.RowCount - 1; ++i)
            {
                foreach (Potencial p in potencials[0])
                    if (p.index == i) data[data.ColumnCount - 1, i].Value = p.value;
            }

            for (int i = 0; i < data.ColumnCount - 1; ++i)
            {
                foreach (Potencial p in potencials[1])
                    if (p.index == i) data[i, data.RowCount - 1].Value = p.value;
            }
            data.Update();
            cost.Text = "Общая стоимость: " + money;
            cost.Update();
        }

        private void next_Click(object sender, EventArgs e)
        {
                result = Methods.Optimization(result, tariff, potencials);
            if (result != null)
            {
                money = Methods.GetCost(tariff, result);
                potencials = Methods.Potencials(result, tariff);
                repaint();
            }
            else next.Enabled = false;
        }
    }
}
