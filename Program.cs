using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class Program
    {

        static void Main(string[] args)
        {


            int i=0;
            int b;


            IBryły Prostopadłościan = new Prostopadłościan(2.0, 1.0, 3.0);
            IBryły Sześcian = new Sześcian(2.0);
            IBryły Walec = new Walec(2.0, 1.0);
            IBryły Kula = new Kula(3.0);

            do
            {
                Console.WriteLine("Wybierz bryłę");
                Console.WriteLine("1-Prostopadłościan");
                Console.WriteLine("2-Sześcian");
                Console.WriteLine("3-Walec");
                Console.WriteLine("4-Kula");
                Console.Write("Twój wybór to: ");
                b = Convert.ToInt16(Console.ReadLine());
                if (b == 1)
                {
                    Console.Write("Objętość prostopadłościanu to: ");
                    Console.WriteLine(Prostopadłościan.ObliczObjętość());
                    Console.Write("Pole powierzchni prostopadłościanu to: ");
                    Console.WriteLine(Prostopadłościan.ObliczPolePowierzchni());
                    i++;
                }
                else if (b == 2)
                {
                    Console.Write("Objętość sześcianu to: ");
                    Console.WriteLine(Sześcian.ObliczObjętość());
                    Console.Write("Pole powierzchni sześcianu to: ");
                    Console.WriteLine(Sześcian.ObliczPolePowierzchni());

                    i++;
                }
                else if ( b==3 )
                {
                    Console.Write("Objętość Walca to: ");
                    Console.WriteLine(Walec.ObliczObjętość());
                    Console.Write("Pole powierzchni Walca to: ");
                    Console.WriteLine(Walec.ObliczPolePowierzchni());

                    i++;
                }
                else if ( b==4)
                {
                    Console.Write("Objętość Kuli to: ");
                    Console.WriteLine(Kula.ObliczObjętość());
                    Console.Write("Pole powierzchni Kuli to: ");
                    Console.WriteLine(Kula.ObliczPolePowierzchni());

                    i++;
                }
                else
                {
                    Console.WriteLine("Spróbuj jeszcze raz ");
                   
                }
            } while (i == 0);
            Console.ReadLine();
        }
    }

}
    

