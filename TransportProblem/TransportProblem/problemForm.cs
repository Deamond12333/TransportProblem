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
                nsMethod.Checked = false;
            method = "small";
        }

        private void doMethod_Click(object sender, EventArgs e)
        {
            int stocks = (Int32)stocksValue.Value;
            int shops = (Int32)shopsValue.Value;
            int[,] tariffs = new int[stocks, shops];
            int[] products = new int[stocks];
            int[] magazines = new int[shops];
            try
            {
                for (int i = 1; i < stocks; i++)
                {
                    products[i - 1] = Int32.Parse(data[i, 0].Value.ToString());
                }
                for (int j = 1; j < shops; j++)
                {
                    magazines[j - 1] = Int32.Parse(data[0, j].Value.ToString());
                }
            }
            catch
            {
                throw new Exception("Не все ячейки содержат числа!");
            }
            switch (method)
            {
                case "ns":
                    {
                        int[,] result = Methods.NSMethod(products, magazines);
                        resultForm resForm = new resultForm(result, stocks, shops);
                        resForm.ShowDialog();
                    } break;

                case "small":
                    {

                    } break;

                default:
                    {
                        throw new Exception("Выберите метод решения!");
                    }
            }
        }

        private void stocksValue_ValueChanged(object sender, EventArgs e)
        {
            data.RowCount = (int)stocksValue.Value + 1;
            for (int i = 0; i < (int)stocksValue.Value + 1; ++i)
            {
                data.Rows[i].HeaderCell.Value = "A" + i;
                data[0, 0].ReadOnly = true;
            }
        }

        private void shopsValue_ValueChanged(object sender, EventArgs e)
        {
            data.ColumnCount = (int)shopsValue.Value + 1;
            for (int i = 0; i < (int)shopsValue.Value + 1; ++i)
            {
                data.Columns[i].HeaderCell.Value = "B" + i;
                data[0, 0].ReadOnly = true;
                data.Columns[i].Width = 30;
            }
        }
    }
}
