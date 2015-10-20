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
        private static int summ(int[,] matrix, int stolb)
        {
            int result = 0;
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; ++i)
            {
                result += matrix[i, stolb];
            }
            return result;
        }
        public static int[,] NSMethod(int[] products, int[] magazines)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            int[,] result = new int[prodCount, magazCount];

            int prod = 0, magaz = 0;
            while ((prod < prodCount - 1) && (magaz < magazCount - 1))
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
                    prod++;
                }
                if (summ(result, magaz) < magazines[magaz])
                {
                    if ((magazines[magaz] - result[prod - 1, magaz]) <= products[prod])
                    {
                        result[prod, magaz] = magazines[magaz] - result[prod - 1, magaz];
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
    }
}
