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

        public static List<int[]> Potencials(int[,] result, int [,] tariffs)
        {
            int[] u = new int[result.GetUpperBound(0) + 1];
            for (int i = 1; i < result.GetUpperBound(0) + 1; ++i)
            {
                u[i] = 100101;
            }
            int[] v = new int[result.GetUpperBound(1) + 1];
            for (int i = 0; i < result.GetUpperBound(1) + 1; ++i)
            {
                v[i] = 100101;
            }

            List<Point> points = new List<Point>();
            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                {
                    if (result[i, j] > 0)
                    {
                        Point point = new Point(i, j);
                        points.Add(point);
                    }
                    else continue;
                }
            }
            List<int> ygriki = new List<int>();
            foreach(Point p in points)
            {
                if (p.X() == 0)
                {
                    ygriki.Add(p.Y());
                }
            }
            Point qurPoint = new Point(0, ygriki.Min());
            u[qurPoint.X()] = 0;
            v[qurPoint.Y()] = tariffs[qurPoint.X(), qurPoint.Y()] - u[qurPoint.X()];
            points.Remove(qurPoint);
            while (points.Count > 0)
            {
                foreach (Point p in points)
                {
                    if ((p.X() == qurPoint.X()) || (p.Y() == qurPoint.Y()))
                    {
                        qurPoint = p;
                        break;
                    }
                }
                if (v[qurPoint.Y()] == 100101)
                {
                    v[qurPoint.Y()] = tariffs[qurPoint.X(), qurPoint.Y()] - u[qurPoint.X()];
                }
                else if (u[qurPoint.X()] == 100101)
                {
                    u[qurPoint.X()] = tariffs[qurPoint.X(), qurPoint.Y()] - v[qurPoint.Y()];
                }
                points.Remove(qurPoint);
            }
            List<int[]> res = new List<int[]>(){u, v};
            return res;
        }

        public static int sumElemInMas(int[] mas)
        {
            int res = 0;
            for (int i = 0; i < mas.Length; ++i)
            {
                res += mas[i];
            }
            return res;
        }
    }
}
