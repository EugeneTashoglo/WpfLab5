using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab5
{
    public interface INorm
    {
        public abstract double Norma();

        public abstract double Module();

        public abstract string Print();
    }
}