using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class O
    {
        /*
       Principio de Abierto/Cerrado (OCP):
       El principio OCP establece que las clases deben ser abiertas 
        para la extensión pero cerradas para la modificación, 
        lo que significa que debemos poder extender el comportamiento de una clase
        sin cambiar su código fuente.

        El principio OCP se aplica aquí al definir una clase abstracta Forma que tiene un método
        abstracto Area(). Las clases Cuadrado y Circulo extienden la clase Forma
        y proporcionan su propia implementación del método Area(), 
        sin necesidad de modificar la clase Forma.
         */
    }

    // herencia
    public abstract class Forma
    {
        public abstract double Area();
    }

    public class Cuadrado : Forma
    {
        public double Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }
    }

    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
