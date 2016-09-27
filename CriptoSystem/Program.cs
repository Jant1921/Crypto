using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace CriptoSystem
{
    class Program
    {
        //string[] listaAlfabeto = {new Alfabeto("abcdefghijklmnopqrstuvwxyz","predetermindo"};

        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo :)");
            string prueba = "tarea programada criptografia de datos zygalski henryk";
            /*Console.WriteLine(prueba);
            Vigenere vi = new Vigenere();
            Console.WriteLine(vi.cod(prueba, 23));
            Console.WriteLine(vi.decod(vi.cod(prueba, 23), 23));*/

            /*Transposicion tra = new Transposicion();
            Console.WriteLine(tra.codificar("esto es un secreto no lo puedo decir aserpros"));
            Console.WriteLine(tra.decodificar(tra.codificar("esto es un secreto no lo puedo decir aserpros")));
            */

            /*CBinaria bin = new CBinaria();
            Console.WriteLine(bin.codificar("tarea programada"));
            Console.WriteLine(bin.decodificar(bin.codificar("tarea programada como estas")));
            */
            /*
            PalabraClave pal = new PalabraClave();
            Console.WriteLine(pal.codi("tarea programada de codificacion", "tango"));
            Console.WriteLine(pal.decodi(pal.codi("tarea programada de codificacion", "tango"), "tango"));
            */
            
            GUI ventana = new GUI();
            //ventana.ShowDialog();
            ventana.ShowDialog();
            Console.ReadKey();
            //ventana.Visible = true;
            //ventana.Show = true;
            //GUI ventana = new GUI();
        }

    }
}
