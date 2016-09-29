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
        static void Main(string[] args)
        {
            App.seleccionarVista();



            /*
            VistaEscritorio ventana = new VistaEscritorio();
            ventana.ShowDialog();
            Console.ReadKey();
            VistaConsola vista = new VistaConsola();
            //vista.pru();
            //Console.ReadKey();
            vista.menu();
            */
        }
    }
}
