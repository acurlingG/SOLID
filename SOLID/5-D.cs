using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class D
    {
        /*
         Principio de Inversión de Dependencia (DIP):
      El principio DIP establece que los módulos de alto nivel 
        no deben depender de los módulos de bajo nivel, sino de abstracciones. 
        Además, las abstracciones no deben depender de los detalles, 
        sino que los detalles deben depender de las abstracciones.

        Aquí, el Servicio de alto nivel depende de una abstracción (IRepositorio) 
        en lugar de depender directamente de la implementación concreta (Repositorio). 
        Esto permite cambiar fácilmente la implementación del repositorio sin modificar el servicio.
        Además, la clase Repositorio depende de una abstracción (IRepositorio) 
        en lugar de depender de los detalles específicos de la base de datos, 
        lo que cumple con el principio DIP.


         */
    }

    public interface IRepositorio
    {
        void GuardarDatos(string datos);
    }

    public class Repositorio : IRepositorio
    {
        public void GuardarDatos(string datos)
        {
            // Lógica para guardar datos en una base de datos
        }
    }

    public class Servicio
    {
        private readonly IRepositorio _repositorio;

        public Servicio(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void ProcesarDatos(string datos)
        {
            // Procesamiento de datos
            _repositorio.GuardarDatos(datos);
        }
    }
}
