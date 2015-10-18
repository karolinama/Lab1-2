using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Kula : IBryły
     {
        private double _r;
   
   

        public Kula(double r )
        {
            _r = r;
            
           
        }

        public double ObliczObjętość()
        {


            return (4*3.14 * _r * _r*_r)/3;
        }
        public double ObliczPolePowierzchni()
    {
        return 4*3.14*_r*_r; 
    }
    }
}