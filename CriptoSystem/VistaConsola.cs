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


        public VistaConsola()
        {
            Console.WriteLine("entro");
            menu();
            Console.ReadKey();
        }


        CryptoSystem controller = new ControladorConsola();
        bool[] algoritmos;
        IEnumerable<Traductor> listaAlgoritmos;
        string[] clavesAlgoritmos;
        bool[] persistencia;

        bool[] listarAlgoritmos(string pTexto, int tamanoListaAlgoritmos)
        {
            try
            {
            bool[] res = new bool[tamanoListaAlgoritmos];
            string[] listTemp = pTexto.Split(' ');
            for(int i = 0; i < listTemp.Length; i++)
            {
                res[Int32.Parse(listTemp[i]) - 1] = true;
            }
            return res;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        bool[] listarPersistencia(string pTexto, int tamanoListaAlgoritmos)
        {
            try
            {
                bool[] res = new bool[tamanoListaAlgoritmos];
                string[] listTemp = pTexto.Split(' ');
                for (int i = 0; i < listTemp.Length; i++)
                {
                    res[Int32.Parse(listTemp[i]) - 1] = true;
                }
                return res;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        void obtenerListaPersistencia()
        {
            Console.WriteLine("Lista de Persistencia: ");
            IEnumerable<Persistencia> listaPersistencia = controller.GetEnumerableOfType<Persistencia>();
            for (int i = 0; i < listaPersistencia.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + listaPersistencia.ElementAt(i).ToString().Split('.')[1]);
            }
            Console.WriteLine();
            Console.WriteLine("Digite el o los numeros de metodos de persistencia que desea utilizar(1 / 1 2 3)");
            bool flag = false;
            while (!flag)
            {
                string lista = Console.ReadLine();
                persistencia = listarPersistencia(lista, listaPersistencia.Count());
                if (persistencia == null)
                {
                    Console.WriteLine("Ha ocurrido un error, ingrese los valores nuevamente");
                }
                else
                {
                    flag = true;
                }

            }
            Console.WriteLine("-------");
            for (int i = 0; i < persistencia.Length; i++)
            {
                Console.WriteLine(persistencia[i]);
            }
        }
        void obtenerListaAlgoritmos()
        {
            Console.WriteLine("Lista de algoritmos: ");
            listaAlgoritmos = controller.GetEnumerableOfType<Traductor>();
            for (int i = 0; i < listaAlgoritmos.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + listaAlgoritmos.ElementAt(i).ToString().Split('.')[1]);
            }
            Console.WriteLine();
            Console.WriteLine("Digite el o los numeros de los algoritmos que desea utilizar(1 / 1 2)");
            bool flag = false;
            while (!flag)
            {
                string lista = Console.ReadLine();
                algoritmos = listarAlgoritmos(lista, listaAlgoritmos.Count());
                clavesAlgoritmos = new string[listaAlgoritmos.Count()];

                if (algoritmos == null)
                {
                    Console.WriteLine("Ha ocurrido un error, ingrese los valores nuevamente");
                }else
                {
                    flag = true;
                }
                
            }
            Console.WriteLine("-------");
            for (int i = 0; i < algoritmos.Length; i++)
            {
                Console.WriteLine(algoritmos[i]);
            }
        }

        void modificarClave(int pos, string pValor)
        {
            clavesAlgoritmos[pos] = pValor;
        }



        void modificarAlgoritmosClave()
        {
            bool[] listTemp = new bool[listaAlgoritmos.Count()];
            int contador = 1;
            object classInstance;
            object result;
            MethodInfo methodInfo;
            for (int i = 0; i < listaAlgoritmos.Count(); i++)
            {
                if (algoritmos[i])
                {
                    //Console.WriteLine(listaAlgoritmos.GetType().ToString());
                    classInstance = Activator.CreateInstance(listaAlgoritmos.ElementAt(i).GetType(), null);
                    methodInfo = listaAlgoritmos.ElementAt(i).GetType().GetMethod("tipoValor");
                    result = methodInfo.Invoke(classInstance, null);
                    if(result != null)
                    {
                        Console.WriteLine(contador.ToString() + ". " + listaAlgoritmos.ElementAt(i).GetType().ToString().Split('.').ElementAt(listaAlgoritmos.ElementAt(i).GetType().ToString().Split('.').Length - 1));
                        contador++;
                        listTemp[i] = true;
                    }
                }
            }
            Console.WriteLine("Indique los numeros de los algoritmos a modificar: --Falta por implementar");
            string numerosLn = Console.ReadLine();
            string[] listaNumeros = numerosLn.Split(' ');
            

            for(int i = 0; i < listaAlgoritmos.Count(); i++)
            {
                if (listTemp[i])
                {
                    Console.WriteLine(listaAlgoritmos.ElementAt(i).GetType().ToString().Split('.')[listaAlgoritmos.ElementAt(i).GetType().ToString().Split('.').Count()-1]);
                    Console.Write("Indique la clave: ");
                    string temp = Console.ReadLine();
                    modificarClave(i, temp);
                }else
                {
                    modificarClave(i, "");
                }
                
            }
            Console.ReadKey();
        }

        void codificar()
        {
            string texto = Console.ReadLine();
            object classInstance;
            object result;
            MethodInfo methodInfo;
            for (int i = 0; i < algoritmos.Length; i++)
            {
                classInstance = Activator.CreateInstance(listaAlgoritmos.ElementAt(i).GetType(), null);
                methodInfo = listaAlgoritmos.ElementAt(i).GetType().GetMethod("codificar");
                object[] parametersArray = new object[] { texto, clavesAlgoritmos[i] };
                Console.WriteLine(listaAlgoritmos.ElementAt(i).GetType().ToString().Split(' ')[listaAlgoritmos.ElementAt(i).GetType().ToString().Split(' ').Count()-1] +" --- "+ (string)methodInfo.Invoke(classInstance, parametersArray));
            }
        }

        void decodificar()
        {
            string texto = Console.ReadLine();
            object classInstance;
            object result;
            MethodInfo methodInfo;
            for (int i = 0; i < algoritmos.Length; i++)
            {
                classInstance = Activator.CreateInstance(listaAlgoritmos.ElementAt(i).GetType(), null);
                methodInfo = listaAlgoritmos.ElementAt(i).GetType().GetMethod("decodificar");
                object[] parametersArray = new object[] { texto, clavesAlgoritmos[i] };
                Console.WriteLine(listaAlgoritmos.ElementAt(i).GetType().ToString().Split('.')[listaAlgoritmos.ElementAt(i).GetType().ToString().Split(' ').Count()-1] + " --- " + (string)methodInfo.Invoke(classInstance, parametersArray));
            }
        }

        void traducir()
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
                        modificarAlgoritmosClave();
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


        void menu()
        {
            Console.WriteLine("---------Configuracion inicial------");
            Console.WriteLine();
            obtenerListaAlgoritmos();
            obtenerListaPersistencia();
            Console.WriteLine();
            Console.WriteLine("---------CryptoSystem------");
            Console.WriteLine();
            traducir();
        }

        

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
            MethodInfo methodInfo = p.ElementAt(3).GetType().GetMethod("codificar");
            for(int i = 0; i< methodInfo.GetParameters().Count();i++)
            {
                Console.WriteLine(methodInfo.GetParameters().ElementAt(i));
            }
            //Console.WriteLine(methodInfo.GetParameters());
            result = methodInfo.Invoke(classInstance, parametersArray);
            return (string)result;
        }
        
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


        /*

        [STAThread]
        static void Main(string[] args)
        {
            VistaEscritorio ventana = new VistaEscritorio();
            ventana.ShowDialog();
            Console.ReadKey();
            VistaConsola vista = new VistaConsola();
            //vista.pru();
            //Console.ReadKey();
            vista.menu();

            


            // MethodInfo m = t.GetMethod("imprimir");
            //m.Invoke(t,null);

            //Console.WriteLine(new Program().pru());


            
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
    }
}
