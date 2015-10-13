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
        public string method = null;
        public problemForm()
        {
            InitializeComponent();
        }

        private void createData_Click(object sender, EventArgs e)
        {
            int sizex = 0, sizey = 0;
            if (Regex.IsMatch(sizeX.Text, "[0-9]{1,2}") == true)
                sizex = 1 + Convert.ToInt32(sizeX.Text);
            else throw new Exception("В поле Магазинов введено не число!");
            if (Regex.IsMatch(sizeY.Text, "[0-9]{1,2}") == true)
                sizey = 1 + Convert.ToInt32(sizeY.Text);
            else throw new Exception("В поле Складов введено не число!");
            data.ColumnCount = sizex;
            data.RowCount = sizey;
            for (int i = 0; i < sizex; ++i)
            {
                data.Columns[i].Width = data.Size.Width/sizex;
            }
            for (int i = 0; i < sizey; ++i)
            {
                data.Rows[i].Height = data.Size.Height / sizey;
            }
            data.Rows[0].Cells[0].ReadOnly = true;
            for (int i = 1; i < sizey; ++i)
            {
                for (int j = 1; j < sizex; ++j)
                {
                    data.Rows[0].Cells[j].Value = "B" + j;
                    data.Rows[i].Cells[j].Value = "C" + i + ":" + j;
                }
                data.Rows[i].Cells[0].Value = "A" + i;
            }
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

        private void clear_Click(object sender, EventArgs e)
        {
            data.ColumnCount = 0;
            smallMethod.Checked = false;
            nsMethod.Checked = false;
            sizeX.Text = null;
            sizeY.Text = null;
        }

        private void doMethod_Click(object sender, EventArgs e)
        {

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
                        throw new Exception("Выберите метод решения");
                    }
            }
        }
    }
}
