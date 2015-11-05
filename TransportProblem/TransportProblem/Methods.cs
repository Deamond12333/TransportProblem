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

        private static bool Existance(List<Potencial> list, int index)
        {
            int res = 0;
            foreach (Potencial p in list)
                if (p.getIndex() == index)
                    res++;
            if (res == 0)
                return true;
            else
                return false;
        }

        private static int indexValue(List<Potencial> list, int index)
        {
            foreach (Potencial p in list)
                if (p.getIndex() == index) return p.getValue();
            return -1;
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
            int prod = 0, magaz = minInStr(tariffs, prod);
            List<int> iskl = new List<int>();

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

        public static List<List<Potencial>> Potencials(int[,] result, int [,] tariffs)
        {
            Potencial qurPv;
            Potencial qurPu;

            List<Potencial> u = new List<Potencial>();
            List<Potencial> v = new List<Potencial>( );
            int basis = 0;
            List<Point> points = new List<Point>();
            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                {
                    if (result[i, j] > 0)
                    {
                        Point point = new Point(i, j);
                        basis++;
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
            qurPu = new Potencial(0, qurPoint.X());
            u.Add(qurPu);
            qurPv = new Potencial(tariffs[qurPoint.X(), qurPoint.Y()], qurPoint.Y());
            v.Add(qurPv);
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
                    else if ((basis < result.GetUpperBound(1) + 1 + result.GetUpperBound(1))&&(qurPoint.Y() < result.GetUpperBound(1)))
                    {
                        qurPoint.setY(qurPoint.Y() + 1);
                        points.Add(qurPoint);
                        break;
                    }
                }
                if (Existance(v, qurPoint.Y()) == false)
                {
                    qurPv = new Potencial(tariffs[qurPoint.X(), qurPoint.Y()] - indexValue(u, qurPoint.X()), qurPoint.Y());
                    v.Add(qurPv);
                }
                else if (Existance(u, qurPoint.X()) == false)
                {
                    qurPu = new Potencial(tariffs[qurPoint.X(), qurPoint.Y()] - indexValue(v, qurPoint.Y()), qurPoint.X());
                    u.Add(qurPu);
                }
                points.Remove(qurPoint);
            }
            List<List<Potencial>> res = new List<List<Potencial>>(){u, v};
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

    public class Point
    {
        private int x { get; set; }
        private int y { get; set; }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public int X()
        {
            return x;
        }

        public void setX(int value)
        {
            x = value;
        }
        public void setY(int value)
        {
            y = value;
        }
        public int Y()
        {
            return y;
        }
    }

    public class Potencial
    {
        private int value { get; set; }
        private int index { get; set; }
        public Potencial(int _value, int _index)
        {
            value = _value;
            index = _index;
        }
        public int getValue()
        {
            return value;
        }

        public int getIndex()
        {
            return index;
        }
    }
}
