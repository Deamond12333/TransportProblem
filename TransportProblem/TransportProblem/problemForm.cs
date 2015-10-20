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
            int stocks = (int)stocksValue.Value;
            int shops = (int)shopsValue.Value;
            int[,] tariffs = new int[stocks, shops];
            int[] products = new int[stocks];
            int[] magazines = new int[shops];
            try
            {
                for (int i = 0; i < stocks-1; ++i)
                {
                    Int32.TryParse(data[0, i+1].Value.ToString(), out products[i]);
                    for (int j = 0; j < shops-1; ++j)
                    {
                        Int32.TryParse(data[j + 1, 0].Value.ToString(), out magazines[j]);
                        Int32.TryParse(data[j+1, i+1].Value.ToString(), out tariffs[j, i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            switch (method)
            {
                case "ns":
                    {

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
