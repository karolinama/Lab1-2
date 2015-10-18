using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Walec : IBryły
     {
        private double _r;
        private double _h;
   

        public Walec(double r, double h)
        {
            _r = r;
            _h = h;
           
        }

        public double ObliczObjętość()
        {


            return 3.14 * _r * _h;
        }
        public double ObliczPolePowierzchni()
    {
        return (2*3.14*_r*_r)+(2*3.14*_r*_h); 
    }
    }
}