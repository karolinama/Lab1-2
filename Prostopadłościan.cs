using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Prostopadłościan : IBryły
    {
        private double _a;
        private double _b;
        private double _c;

        public Prostopadłościan(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double ObliczObjętość()
        {
            

            return _a * _b * _c;
        }
        public double ObliczPolePowierzchni()
    {
        return (2*_a*_b)+ (2*_b*_c)+ (2*_a*_c); 
    }
    }
}