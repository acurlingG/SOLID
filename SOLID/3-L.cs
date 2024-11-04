using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class L
    {
        /*Principio de Sustitución de Liskov (LSP):
        El principio LSP establece que los objetos de un programa deben ser sustituibles 
        por instancias de sus subtipos sin afectar la corrección del programa.
      
        Aquí, la clase Ave define un comportamiento Volar(). 
        La clase Gorrion implementa este método correctamente, 
        mientras que AveNoVoladora indica que no puede volar lanzando una excepción.
        Esto respeta el principio LSP ya que las instancias de Ave pueden ser reemplazadas 
        por instancias de sus subclases (Gorrion) sin problemas.
        */
    }

    // polimorfismo
    public abstract class Ave
    {
        public abstract void Volar();
    }

    public class AveNoVoladora : Ave
    {
        public override void Volar()
        {
            throw new NotImplementedException("Esta ave no puede volar");
        }
    }

    public class Gorrion : Ave
    {
        public override void Volar()
        {
            Console.WriteLine("El gorrión está volando");
        }
    }
}
