using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class S
    {
        /*     Principio de Responsabilidad Única(SRP):
           El principio SRP establece que una clase debe tener una única razón para cambiar, 
        es decir, cada clase debe tener responsabilidad sobre una sola parte del software.

       La clase ClienteService tiene la responsabilidad única de manejar las operaciones 
        relacionadas con los clientes, como agregar, actualizar y eliminar. 
        No mezcla estas responsabilidades con otras tareas no relacionadas, 
        como la lógica de presentación o el acceso a la base de datos.
        */
    }

    public class Cliente
    {
        string nombre;
        string cedula;
        string telefono;

    }
    public class ClienteService
    {
        public void AgregarCliente(Cliente cliente)
        {
            // Lógica para agregar un cliente a la base de datos
        }

        public void ActualizarCliente(Cliente cliente)
        {
            // Lógica para actualizar un cliente en la base de datos
        }

        public void EliminarCliente(Cliente cliente)
        {
            // Lógica para eliminar un cliente de la base de datos
        }

        public void ConsultarCliente(Cliente cliente)
        {
            // Lógica para Consultar un cliente de la base de datos
        }
    }
}
