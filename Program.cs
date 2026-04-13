using System;
using System.Collections.Generic;
internal class Program
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
        private static void Main(string[] args)
        {
            Queue<Cliente> cola = new Queue<Cliente>();
            int opcion;

            do
            {
                Console.WriteLine("\n~~~~~~ SERVICIO AL CLIENTE ~~~~~~");
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Atender cliente");
                Console.WriteLine("3. Ver cola");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        string respuesta;
                        do
                        {
                            Console.WriteLine("Ingrese el nombre del cliente:");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("Ingrese el número de teléfono del cliente:");
                            string telefono = Console.ReadLine();

                            Cliente nuevoCliente = new Cliente(nombre, telefono);
                            cola.Enqueue(nuevoCliente);

                            Console.WriteLine("Cliente agregado a la cola.");

                            Console.WriteLine("¿Desea agregar otro cliente? (true/false)");
                            respuesta = Console.ReadLine();

                        } while (respuesta == "true");
                        break;

                    case 2:
                        if (cola.Count == 0)
                        {
                            Console.WriteLine("No hay clientes en la cola.");
                        }
                        else
                        {
                            Cliente atendido = cola.Dequeue();
                            Console.WriteLine("Atendiendo a: " + atendido.Nombre);
                        }
                        break;

                    case 3:
                        if (cola.Count == 0)
                        {
                            Console.WriteLine("La cola está vacía.");
                        }
                        else
                        {
                            Console.WriteLine("Clientes en la cola:");
                            foreach (Cliente c in cola)
                            {
                                Console.WriteLine(c.Nombre + " - " + c.Telefono);
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
      
            } while (opcion != 4);
        }
    }
}