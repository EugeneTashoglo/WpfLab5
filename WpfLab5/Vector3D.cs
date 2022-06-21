using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab5
{
    internal class Vector3D : INorm
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector3D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Module()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public  double Norma()
        {
            return Math.Max(Math.Abs(X), Math.Abs(Y));

        }
        public  string Print()
        {
            return $"Модуль вектора: {Module():F2}," +
                $"Норма вектора: {Norma():F2}";
        }

    }
}