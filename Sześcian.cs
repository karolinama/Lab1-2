using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Sześcian : IBryły
    {
        private double _a;


        public Sześcian(double a)
        {
            _a = a;
        }
        public double ObliczObjętość()
        {
            return _a * _a * _a;
        }
                public double ObliczPolePowierzchni()
        {
            return 6 * _a * _a;
        }
    }
}