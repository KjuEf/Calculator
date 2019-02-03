using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upisi prvi broj ovdje :");
            int n1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Upisi drugi broj ovdje :");
            int n2 = Convert.ToUInt16(Console.ReadLine());
            int r;

            string o = Console.ReadLine();

            switch (o)
            {
                case "+":
                    r = n1 + n2;
                    Console.WriteLine(" Broj 1 + Broj 2 = " + r);
                    break;

                case "-":
                    r = n1 - n2;
                    Console.WriteLine(" Broj 1 - Broj 2 = " + r);
                    break;

                case "*":
                    r = n1 * n2;
                    Console.WriteLine(" Broj 1 * Broj 2 = " + r);
                    break;

                case "/":
                    r=n1/ n2;
                    Console.WriteLine(" Broj 1 / Broj 2 = " + r);
                    break;

                default:
                    Console.WriteLine("Error my friend");
                    break;
            }




            Console.ReadKey();
        }
    }
}
