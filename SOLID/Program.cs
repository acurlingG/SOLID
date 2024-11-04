using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Program
    {
        interface ICalculadora
        {
            
            int suma(int x, int y) ;
            int resta(int x, int y);

        }

        class calculadora : ICalculadora
        {
           
            public int suma(int x, int y)
            {
                int total = x + y;
                return total;
            }

            public int resta(int x, int y)
            {
                int total = x - y;
                return total;
            }


        }

        static void Main(string[] args)
        {


            Console.ReadKey();
        }


    }
}
