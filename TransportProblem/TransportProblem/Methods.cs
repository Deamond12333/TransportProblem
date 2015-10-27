using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportProblem
{
    public static class Methods
    {
        private static int equals(int[] mas)
        {
            for (int i = 0; i < mas.Length; ++i)
            {
                if (mas[i] != 0)
                {
                    return i;
                }
                else continue;
            }
            return -1;
        }
        private static int minInStr(int[,] matrix, int str, List<int> iskl)
        {
            List<int> elems = new List<int>();
            List<int> index = new List<int>();
            for (int i = 0; i < matrix.GetUpperBound(1) + 1; ++i)
            {
                if (!iskl.Contains(i))
                {
                    elems.Add(matrix[str, i]);
                    index.Add(i);
                }
                else continue;
            }
            if (index.Count == 0) return -1;
            else return index[elems.IndexOf(elems.Min())];
        }

        private static int minInStr(int[,] matrix, int str)
        {
            List<int> elems = new List<int>();
            for (int i = 0; i < matrix.GetUpperBound(1) + 1; ++i)
            {
                elems.Add(matrix[str, i]);
            }
            return elems.IndexOf(elems.Min());
        }
        public static int[,] NSMethod(int[] products, int[] magazines)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            int[,] result = new int[prodCount, magazCount];

            int prod = 0, magaz = 0;
            while ((prod < prodCount) && (magaz < magazCount))
            {
                if (products[prod] >= magazines[magaz])
                {
                    result[prod, magaz] = magazines[magaz];
                    products[prod] -= magazines[magaz];
                    magazines[magaz] = 0;
                    magaz++;
                }
                else
                {
                    result[prod, magaz] = products[prod];
                    magazines[magaz] -= products[prod];
                    products[prod] = 0;
                    prod++;
                }
            }
            return result;
        }
        public static int[,] SmallMethod(int[] products, int[] magazines, int[,] tariffs)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            int[,] result = new int[prodCount, magazCount];

            int prod = 0, magaz = minInStr(tariffs, prod); List<int> iskl = new List<int>();

            while (magaz != -1)
            {
                if (products[prod] >= magazines[magaz])
                {
                    result[prod, magaz] = magazines[magaz];
                    products[prod] -= magazines[magaz];
                    magazines[magaz] = 0;
                    iskl.Add(magaz);
                    magaz = minInStr(tariffs, prod, iskl);
                }
                else
                {
                    result[prod, magaz] = products[prod];
                    magazines[magaz] -= products[prod];
                    products[prod] = 0;
                    prod++;
                }
            }
            return result;
        }
        public static int GetCost(int[,] tariffs, int[,] result)
        {
            int res = 0;
            for (int i = 0; i < tariffs.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < tariffs.GetUpperBound(1) + 1; ++j)
                {
                    if (result[i, j] != 0)
                    {
                        res += result[i, j] * tariffs[i, j];
                    }
                }
            }
            return res;
        }
    }
}
