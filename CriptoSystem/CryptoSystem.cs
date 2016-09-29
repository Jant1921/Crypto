using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;

namespace CriptoSystem
{
    abstract class CryptoSystem
    {
        //string[] listaAlfabeto = {new Alfabeto("abcdefghijklmnopqrstuvwxyz","predetermindo"};


        public string pru()
        {
            IEnumerable<Traductor> p = GetEnumerableOfType<Traductor>();
            for (int i = 0; i < p.Count(); i++)
            {
                Console.WriteLine(p.ElementAt(i).GetType());
            }

            object classInstance = Activator.CreateInstance(p.ElementAt(3).GetType(), null);
            object[] parametersArray = new object[] { "hola como estas", "22" };
            object result;
            MethodInfo methodInfo = p.ElementAt(3).GetType().GetMethod("cod");
            result = methodInfo.Invoke(classInstance, parametersArray);
            return (string)result;
        }


        /*
        [STAThread]
        static void Main(string[] args)
        {

            //Type t = Assembly.GetExecutingAssembly().GetType(p.ElementAt(0).GetType().ToString());


             //MethodInfo m = t.GetMethod("imprimir");
             //m.Invoke(t,null);
            

            Console.WriteLine(new CryptoSystem().pru());
            /*
            Console.WriteLine("Hola mundo :)");
            string prueba = "tarea programada criptografia de datos zygalski henryk";
            Console.WriteLine(prueba);
            Vigenere vi = new Vigenere();
            Console.WriteLine(vi.cod(prueba, "23"));
            Console.WriteLine(vi.decod(vi.cod(prueba, "23"), "23"));

            Console.WriteLine(vi.GetType());

            /*Transposicion tra = new Transposicion();
            Console.WriteLine(tra.codificar("esto es un secreto no lo puedo decir aserpros"));
            Console.WriteLine(tra.decodificar(tra.codificar("esto es un secreto no lo puedo decir aserpros")));
            
             

            /*CBinaria bin = new CBinaria();
            Console.WriteLine(bin.codificar("tarea programada"));
            Console.WriteLine(bin.decodificar(bin.codificar("tarea programada como estas")));
            
            /*
            PalabraClave pal = new PalabraClave();
            Console.WriteLine(pal.codi("tarea programada de codificacion", "tango"));
            Console.WriteLine(pal.decodi(pal.codi("tarea programada de codificacion", "tango"), "tango"));
            
            GUI ventana = new GUI();
            //ventana.ShowDialog();
            ventana.ShowDialog();
            Console.ReadKey();

            //ventana.Visible = true;
            //ventana.Show = true;
            //GUI ventana = new GUI();
    
        }
        */
        public IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<T> objects = new List<T>();
            foreach (Type type in
            Assembly.GetAssembly(typeof(T)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            return objects;
        }

    }
}
