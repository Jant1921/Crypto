using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem {
    class VistaConsola {
        ControladorConsola controlador = new ControladorConsola();
        private int numeroTraductor;
        private string frase = "Hola Mundo";
        public VistaConsola() {
            Console.WriteLine("CryptoSystem\n");
            menu();
        }

        void menu() {
            string opcion;
            bool continuar = true;
            while(continuar) {
                Console.WriteLine("1. Definir Frase a Traducir\n" +
                                  "2. Elegir Algoritmo\n" +
                                  "0. Salir\n\n" +
                                  "Seleccione una opcion: ");
                try {

                    opcion = Console.ReadLine();

                    switch(opcion) {
                        case "1":
                            definirFrase();
                            break;
                        case "2":
                            traductores();
                            break;
                        case "0":
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida\n");
                            break;
                    }
                }
                catch {
                    Console.WriteLine("No ha ingresado un caracter valido");
                }
            }

        }

        void definirFrase() {
            Console.WriteLine("Ingrese la frase a traducir: ");
            frase = Console.ReadLine();
            Console.WriteLine();

        }


        void traductores() {
            bool continuar = true;
            string[] listaNombresTraductores = controlador.getNombresTraductores();
            int cantidadTraductores = listaNombresTraductores.Length;
            string nombresTraductores = "";
            for(int posicion = 0; posicion < cantidadTraductores; posicion++) {
                nombresTraductores += posicion+1 +". "+listaNombresTraductores.ElementAt(posicion) + "\n";
            }
            nombresTraductores += "0. Volver\n";
            while (continuar) {
                Console.Write("Algoritmos de traduccion disponibles: \n\n"+
                              nombresTraductores+"\n\n"+
                              "Seleccione el algoritmo a utilizar: \n");
                try {
                    numeroTraductor = Int16.Parse(Console.ReadLine());
                    if(numeroTraductor == 0) {
                        continuar = false;
                    }
                    else {
                        numeroTraductor--;
                        if(0 <= numeroTraductor && numeroTraductor <= cantidadTraductores) {
                            tipoTraduccion();
                        }
                    }
                }
                catch {

                    Console.WriteLine("No ha ingresado un caracter valido");
                }
            }
        }



        void tipoTraduccion() {
            bool continuar = true;
            while(continuar) {
                Console.WriteLine("Opciones disponibles: ");
                Console.WriteLine();
                Console.WriteLine("1. Codificar");
                Console.WriteLine("2. Decodificar");
                Console.WriteLine("0. Volver");
                Console.WriteLine("Digite una opcion: ");
                string respuesta = Console.ReadLine();
                continuar = false;
                switch(respuesta) {
                    case "1":
                        controlador.codificar(frase, numeroTraductor);
                        Console.WriteLine("\n"+controlador.retornarResultado());
                        break;
                    case "2":
                        controlador.decodificar(frase, numeroTraductor);
                        Console.WriteLine("\n" + controlador.retornarResultado());
                        break;
                    case "0":
                        break;
                    default:
                        continuar = true;
                        Console.WriteLine("Opcion no valida\n");
                        break;
                }

            }
        }
    }
}