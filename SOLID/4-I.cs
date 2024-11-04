using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class I
    {
        /*    Principio de Segregación de Interfaces(ISP) :
          El principio ISP establece que ningún cliente debería verse obligado
        a depender de métodos que no utiliza.En otras palabras, las interfaces más grandes 
        deben dividirse en interfaces más pequeñas y específicas.

            El principio ISP se aplica aquí al dividir la interfaz Empleado en dos interfaces más pequeñas
          y cohesivas: ITrabajo y IComer. Esto permite que las clases implementen solo las interfaces que necesitan
          y no se vean obligadas a implementar métodos que no utilizan.


        */
    }

    public interface ITrabajo
    {
        void Trabajar();
    }

    public interface IComer
    {
        void Comer();
    }

    public class Empleado : ITrabajo, IComer
    {
        public void Trabajar()
        {
            Console.WriteLine("El empleado está trabajando");
        }
        public void Comer()
        {
            Console.WriteLine("El empleado está comiendo");
        }

        public void Vacaciones() { }

    }
}
