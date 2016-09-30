using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class App
    {
        static void seleccionarVista()
        {
                  
            Console.WriteLine("----CryptoSystem----");
            Console.WriteLine("1. Modo consola\n2. Modo grafico");
            Console.Write("Indique en que modo desea utilizar el sistema: ");
            string eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "1":
                    Console.Clear();
                    new VistaConsola();
                    break;
                case "2":
                    new VistaEscritorio();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    seleccionarVista();
                    break;

            }



        }
        static void Main(string[] args) {
            /*
            Fabrica fab = new Fabrica();
            string[] dsa = { "sd", "sda"};
            Console.WriteLine(fab.getTraductores().ElementAt(0).codificar("jose", ""));
            fab.getAlgoritmosPersistencia().ElementAt(0).guardarArchivo("file1",dsa);
            Console.WriteLine(fab.getTraductores().ElementAt(0).GetType().ToString().Split('.').ElementAt(1));

            */

            
            //List<string> myCollection = new List<string>();
            //myCollection.Add("puto");
            //Pdf escribe = new CriptoSystem.Pdf();
            //escribe.guardarArchivo();
            App.seleccionarVista();
                



           
        }
    }
}
