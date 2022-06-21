using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab5
{
    internal class Complex : INorm
    {
        public double Aba { get; set; }
        public double Ba { get; set; }

        public Complex(double aba, double ba)
        {
            Aba = aba;
            Ba = ba;
        }

        public  double Module()
        {
            return Math.Sqrt(Aba * Aba + Ba * Ba);
        }

        public double Norma()
        {
            return Math.Abs(Math.Pow(Aba, 2));
        }

        public string Print()
        {
            return $"Модуль комплекса: {Module():F2}," +
                $"Норма комплекса: {Norma():F2}";
        }

    }
}