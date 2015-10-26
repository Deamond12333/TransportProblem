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
        private static int summInClm(int[,] matrix, int stolb)
        {
            int result = 0;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; ++i)
            {
                result += matrix[i, stolb];
            }
            return result;
        }

        private static int minInStr(int[,] matrix, int str)
        {
            int result = 0;
            for (int i = 1; i < matrix.GetUpperBound(1) + 1; ++i)
            {
                if (result < matrix[str, i])
                {
                    result = i;
                }
                else continue;
            }
            return result;
        }

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
            int result = 0;
            for (int i = 0; i < matrix.GetUpperBound(1) + 1; ++i)
            {
                if (iskl.Equals(i)) continue;
                else
                {
                    if (result < matrix[str, i])
                    {
                        result = i;
                    }
                    else continue;
                }
            }
            return result;
        }
        public static int[,] NSMethod(int[] products, int[] magazines)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            int[,] result = new int[prodCount, magazCount];

            int prod = 0, magaz = 0;
            while ((prod < prodCount) && (magaz < magazCount))
            {
                while (products[prod] != 0)
                {
                    if (products[prod] >= magazines[magaz])
                    {
                        result[prod, magaz] = magazines[magaz];
                        products[prod] -= magazines[magaz];
                        magaz++;
                    }
                    else
                    {
                        result[prod, magaz] = products[prod];
                        products[prod] = 0;
                    }
                }
                prod++;
                if (summInClm(result, magaz) < magazines[magaz])
                {
                    if ((magazines[magaz] - result[prod-1, magaz]) <= products[prod])
                    {
                        result[prod, magaz] = magazines[magaz] - result[prod-1, magaz];
                        products[prod] -= result[prod, magaz];
                        magaz++;
                    }
                    else
                    {
                        result[prod, magaz] = products[prod];
                        products[prod] = 0;
                        prod++;
                    }
                }
            }
            return result;
        }
        public static int[,] SmallMethod(int[] products, int[] magazines, int[,] tariffs)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            int[,] result = new int[prodCount, magazCount];

            int prod = 0, magaz = 0; List<int> min = new List<int>();

            while (prod < prodCount)
            {
                magaz = minInStr(tariffs, prod);
                if (products[prod] > magazines[magaz])
                {
                    result[prod, magaz] = products[prod] - magazines[magaz];
                    products[prod] -= magazines[magaz];
                    while (products[prod] != 0)
                    {
                        min.Add(magaz);
                        magaz = minInStr(tariffs, prod, min);
                        result[prod, magaz] = products[prod] - magazines[magaz];
                        products[prod] -= magazines[magaz];
                    }
                }
                else
                {
                    result[prod, magaz] = products[prod];
                    products[prod] = 0;
                }
                prod++;
            }
            prod = equals(products);
            while (prod != -1)
            {
                for (int i = 0; i < magazCount; ++i)
                {
                    if (summInClm(result, i) < magazines[i])
                    {
                        result[prod, i] = magazines[i] - products[prod];
                        products[prod] -= result[prod, i];
                    }
                }
            }
            return result;
        }
        public static int GetCost(int[,] tariffs, int[,] result, int shopsCount, int stocksCount)
        {
            int res = 0;
            for (int i = 0; i < stocksCount; i++)
            {
                for (int j = 0; j < shopsCount; j++)
                {
                    if (result[j, i] != 0)
                    {
                        res += result[j, i] * tariffs[j, i];
                    }
                }
            }
            return res;
        }
    }
}
