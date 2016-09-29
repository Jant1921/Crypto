using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class VistaConsola
    {
        ControladorConsola controlador = new ControladorConsola();
        public VistaConsola()
        {
            menu();
            Console.ReadKey();
        }

        void codificar()
        {
            Console.WriteLine("Ingrese el texto a codificar: ");
            string texto = Console.ReadLine();
            //controlador.codificar();
            Console.WriteLine("Resultado: ");
            
        }

        void decodificar()
        {
            Console.WriteLine("Ingrese el texto a decodificar: ");
            string texto = Console.ReadLine();
            //controlador.decodificar();
            Console.WriteLine("Resultado: ");

        }

        void menu()
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Digite una opcion: ");
                Console.WriteLine();
                Console.WriteLine("1. Codificar");
                Console.WriteLine("2. Decodificar");
                Console.WriteLine("3. Modificar claves");
                Console.WriteLine("0. Salir");
                string respuesta = Console.ReadLine();

                switch(respuesta){
                    case "1":
                        Console.WriteLine("Codificando ..");
                        codificar();
                        break;
                    case "2":
                        Console.WriteLine("Decodificando  ..");
                        decodificar();
                        break;
                    case "3":
                        Console.WriteLine("Modificar claves");
                        Console.WriteLine("No implementado");
                        //modificarAlgoritmosClave();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo ..");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.WriteLine();
                        break;
                }
                
            }
        }
    }
}
