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
            List<float> elems = new List<float>();
            List<int> index = new List<int>();
            for (int i = 0; i < matrix.GetUpperBound(1) + 1; ++i)
            {
                if (!iskl.Contains(i))
                {
                    if (matrix[str, i] == 0) return i;
                    elems.Add(matrix[str, i]);
                    index.Add(i);
                }
            }
            if (index.Count == 0) return -1;
            else return index[elems.IndexOf(elems.Min())];
        }

        private static int minInStr(int[,] matrix, int str)
        {
            List<float> elems = new List<float>();
            for (int i = 0; i < matrix.GetUpperBound(1) + 1; ++i)
            {
                if (matrix[str, i] == 0) return i;
                elems.Add(matrix[str, i]);
            }
            return elems.IndexOf(elems.Min());
        }

        private static bool Existance(List<Potencial> list, int index)
        {
            int res = 0;
            foreach (Potencial p in list)
                if (p.index == index)
                    res++;
            if (res == 0)
                return false;
            else
                return true;
        }

        private static float indexValue(List<Potencial> list, int index)
        {
            foreach (Potencial p in list)
                if (p.index == index) return p.value;
            return -1;
        }

        public static float[,] NSMethod(int[] products, int[] magazines)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            float[,] result = new float[prodCount, magazCount];

            for (int i = 0; i < prodCount; ++i)
                for (int j = 0; j < magazCount; ++j)
                    result[i, j] = float.NaN;

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

        public static float[,] SmallMethod(int[] products, int[] magazines, int[,] tariffs)
        {
            int prodCount = products.Length;
            int magazCount = magazines.Length;
            float[,] result = new float[prodCount, magazCount];

            for (int i = 0; i < prodCount; ++i)
                for (int j = 0; j < magazCount; ++j)
                    result[i, j] = float.NaN;

            int prod = 0;
            int magaz = minInStr(tariffs, prod);
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

        public static int GetCost(int[,] tariffs, float[,] result)
        {
            int res = 0;
            for (int i = 0; i < tariffs.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < tariffs.GetUpperBound(1) + 1; ++j)
                {
                    if (!float.IsNaN(result[i, j]))
                    {
                        res += (int)result[i, j] * tariffs[i, j];
                    }
                }
            }
            return res;
        }

        public static List<List<Potencial>> Potencials(float[,] result, int[,] tariffs)
        {
            List<Potencial> u = new List<Potencial>();
            u.Add(new Potencial(0, 0));
            List<Potencial> v = new List<Potencial>();
            List<BasisPoint> points = new List<BasisPoint>();
            int basisCount = 0;
            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                {
                    if (!float.IsNaN(result[i, j]))
                    {
                        BasisPoint point = new BasisPoint(i, j);
                        points.Add(point);
                        basisCount++;
                    }
                }
            }

            if (points.Count < (result.GetUpperBound(0) + 1 + result.GetUpperBound(1)))
            {
                int x = 0, y = 0;
                foreach (BasisPoint p in points)
                {
                    foreach (BasisPoint q in points)
                    {
                        if (p == q) continue;
                        if (p.x == q.x) x++;
                        if (p.y == q.y) y++;
                    }

                    if ((x == 0) && (y == 0))
                    {
                        points.Add(new BasisPoint(p.x, p.y + 1));
                        result[p.x, p.y + 1] = 0;
                        break;
                    }
                }
            }

            int t = 0;
            while (points.Count > 0)
            {
                int basis = points.Count;
                if (t < basis - 1) t++;
                else t = 0;
                if (Existance(u, points[t].x)) v.Add(new Potencial(tariffs[points[t].x, points[t].y] - indexValue(u, points[t].x), points[t].y));
                else if (Existance(v, points[t].y)) u.Add(new Potencial(tariffs[points[t].x, points[t].y] - indexValue(v, points[t].y), points[t].x));
                if ((Existance(v, points[t].y)) && (Existance(u, points[t].x))) points.Remove(points[t]);
                
            }
            List<List<Potencial>> res = new List<List<Potencial>>() { u, v };
            return res;
        }

        public static float[,] Optimization(float[,] result, int[,] tariffs, List<List<Potencial>> potencials)
        {
            List<Delta> delts = new List<Delta>();
            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                {
                    if (float.IsNaN(result[i, j]))
                    {
                        Delta delta = new Delta(i, j, tariffs[i, j] - (indexValue(potencials[0], i) + indexValue(potencials[1], j)));
                        delts.Add(delta);
                    }
                    else continue;
                }
            }
            a:
            Delta min = delts[0];
            int minCount = 0;
            foreach (Delta d in delts)
            {
                if (d.value < min.value) min = d;
            }
            foreach (Delta d in delts)
            {
                if (d.value == min.value) minCount++;
            }
            if (min.value >= 0) return null;
            min.zn = "+";
            List<BasisPoint> points = new List<BasisPoint>();
            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                {
                    if (!float.IsNaN(result[i, j]))
                    {
                        BasisPoint point = new BasisPoint(i, j, result[i, j]);
                        points.Add(point);
                    }
                }
            }
            BasisPoint qurPoint = min;
            List<BasisPoint> cycle = new List<BasisPoint>();
            cycle.Add(min);
            bool turn = false;
            bool complete = false;
            bool error = false;
            while (complete != true)
            {
                if (error)
                {
                    delts.Remove(min);
                    goto a;
                }
                List<BasisPoint> qurStr = new List<BasisPoint>();
                if (turn == false)
                {
                    foreach (BasisPoint p in points)
                    {
                        if (p.x == qurPoint.x) qurStr.Add(p);
                    }

                    foreach (BasisPoint q in qurStr)
                    {
                        points.Remove(q);
                        if (q.y == min.y)
                        {
                            q.zn = "-";
                            cycle.Add(q);
                            complete = true;
                        }
                    }

                    foreach (BasisPoint q in qurStr)
                    {
                        foreach (BasisPoint p in points)
                        {
                            if (q.y == p.y)
                            {
                                if (q.value > 0.0)
                                {
                                    if (turnUp(points, min, q))
                                    {
                                        qurPoint = q;
                                        qurPoint.zn = "-";
                                        cycle.Add(qurPoint);
                                        turn = !turn;
                                        break;
                                    }
                                }
                                else error = true;
                            }
                        }
                    }
                }
                else
                {
                    foreach (BasisPoint p in points)
                    {
                        if (p.y == qurPoint.y) qurStr.Add(p);
                    }

                    foreach (BasisPoint q in qurStr)
                    {
                        points.Remove(q);
                    }

                    foreach (BasisPoint q in qurStr)
                    {
                        foreach (BasisPoint p in points)
                        {
                            if (q.x == p.x)
                            {
                                if (turnDown(points, min, q))
                                {
                                    qurPoint = q;
                                    qurPoint.zn = "+";
                                    cycle.Add(qurPoint);
                                    turn = !turn;
                                    break;
                                }
                            }
                        } 
                    }
                }
            }

            List<float> end = new List<float>();
            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                    foreach (BasisPoint p in cycle)
                        if ((p.x == i) && (p.y == j) && (p.zn == "-")) end.Add(result[i, j]);

            for (int i = 0; i < result.GetUpperBound(0) + 1; ++i)
                for (int j = 0; j < result.GetUpperBound(1) + 1; ++j)
                    foreach (BasisPoint p in cycle)
                        if ((p.x == i) && (p.y == j))
                        {
                            if (float.IsNaN(result[i, j])) result[i, j] = 0;
                            if (p.zn == "+") result[i, j] += end.Min();
                            else result[i, j] -= end.Min();
                            if (result[i, j] == 0) result[i, j] = float.NaN;
                        }
            return result;
        }

        private static bool turnUp (List<BasisPoint> points, BasisPoint min, BasisPoint qurPoint)
        {
            List<BasisPoint> qurPoints = napoln(points);
            List<BasisPoint> qurStr = new List<BasisPoint>();

            foreach (BasisPoint p in qurPoints)
            {
                if (p.y == qurPoint.y) qurStr.Add(p);
            }

            if (qurStr.Count == 0) return false;

            foreach (BasisPoint q in qurStr)
            {
                qurPoints.Remove(q);
            }

            foreach (BasisPoint q in qurStr)
            {
                foreach (BasisPoint p in qurPoints)
                {
                    if (turnDown(qurPoints, min, q)) return true;
                    else continue;
                }
            }
            return false;
        }

        private static bool turnDown(List<BasisPoint> points, BasisPoint min, BasisPoint qurPoint)
        {
            List<BasisPoint> qurPoints = napoln(points);
            List<BasisPoint> qurStr = new List<BasisPoint>();

            foreach (BasisPoint p in qurPoints)
            {
                if (p.x == qurPoint.x) qurStr.Add(p);
            }

            if (qurStr.Count == 0) return false;

            foreach (BasisPoint q in qurStr)
            {
                qurPoints.Remove(q);
                if (q.y == min.y) return true;
            }

            foreach (BasisPoint q in qurStr)
            {
                foreach (BasisPoint p in qurPoints)
                {
                    if (turnUp(qurPoints, min, q)) return true;
                    else continue;
                }
            }
            return false;
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

        private static List<BasisPoint> napoln (List<BasisPoint> input)
        {
            List<BasisPoint> output = new List<BasisPoint>();
            foreach (BasisPoint b in input)
                output.Add(b);
            return output;
        }
    }

    public class BasisPoint
    {
        public int x { get; set; }
        public int y { get; set; }
        public float value { get; set; }
        public string zn { get; set; }

        public BasisPoint()
        {}
        public BasisPoint(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public BasisPoint(int X, int Y, float Value)
        {
            x = X;
            y = Y;
            value = Value;
        }
    }

    public class Delta : BasisPoint
    {
        public Delta(int X, int Y, float Value)
        {
            x = X;
            y = Y;
            value = Value;
        }
    }

    public class Potencial
    {
        public float value { get; set; }
        public int index { get; set; }

        public Potencial(float Value, int Index)
        {
            value = Value;
            index = Index;
        }
    }
}
