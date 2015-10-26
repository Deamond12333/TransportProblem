using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TransportProblem
{
    public partial class problemForm : Form
    {
        private string method = null;
        public problemForm()
        {
            InitializeComponent();
        }

        private void Methods_CheckedChanged(object sender, EventArgs e)
        {
            if (nsMethod.Checked == true)
            {
                smallMethod.Checked = false;
                method = "ns";
            }
            if (smallMethod.Checked == true)
            {
                nsMethod.Checked = false;
                method = "small";
            }
        }

        private void doMethod_Click(object sender, EventArgs e)
        {
            int stocks = (int)stocksValue.Value;
            int shops = (int)shopsValue.Value;
            int[,] tariffs = new int[stocks, shops];
            int[] products = new int[stocks];
            int[] magazines = new int[shops];
            try
            {
                for (int i = 0; i < stocks; i++)
                {
                    int.TryParse(data[0, i + 1].Value.ToString(), out products[i]);
                }
                for (int j = 0; j < shops; j++)
                {
                    int.TryParse(data[j + 1, 0].Value.ToString(), out magazines[j]);
                }
                for (int i = 0; i < stocks; i++)
                {
                    for (int j = 0; j < shops; j++)
                    {
                        int.TryParse(data[j + 1, i + 1].Value.ToString(), out tariffs[j, i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            switch(method)
            {
                case "ns":
                    {
                        int[,] result = Methods.NSMethod(products, magazines);
                        int cost = Methods.GetCost(tariffs, result, shops, stocks);
                        resultForm res = new resultForm(result, stocks, shops, cost);
                        res.Show();
                    } break;
                case "small":
                    {
                        int[,] result = Methods.SmallMethod(products, magazines, tariffs);
                        int cost = Methods.GetCost(tariffs, result, shops, stocks);
                        resultForm res = new resultForm(result, stocks, shops, cost);
                        res.Show();
                    } break;
                default:
                    {
                        MessageBox.Show("Выберите метод решения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } break;
            }
        }

        private void stocksValue_ValueChanged(object sender, EventArgs e)
        {
            data.RowCount = 1 + (int)stocksValue.Value;
            for (int i = 0; i < data.RowCount; i++)
            {
                data.Rows[i].HeaderCell.Value = "A" + i;
                data[0, 0].ReadOnly = true;
            }
        }

        private void shopsValue_ValueChanged(object sender, EventArgs e)
        {
            data.ColumnCount = 1 + (int)shopsValue.Value;
            for (int i = 0; i < data.ColumnCount; i++)
            {
                data.Columns[i].HeaderCell.Value = "B" + i;
                data.Columns[i].Width = 30;
            }
            foreach (DataGridViewColumn column in data.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
