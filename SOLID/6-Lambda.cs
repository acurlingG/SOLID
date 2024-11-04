using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class _6_Lambda
    {
        /*
         *
          Claro, una función lambda es una función anónima que puedes usar para definir 
        lógica de manera concisa y en línea. En C#, las funciones lambda son muy útiles, 
        especialmente cuando se trata de trabajar con expresiones LINQ, eventos, delegados y más.
        Aquí tienes algunos ejemplos de funciones lambda en C#:
    */
        public void suma()
        {
            Func<int, int, int> suma = (a, b) => a + b;
            Console.WriteLine(suma(3, 5)); // Imprime 8
        }

        public void Lista()
        {

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var pares = numeros.Where(x => x % 2 == 0);

            foreach (var numero in pares)
            {
                Console.WriteLine(numero);
            }


        }
    }
}