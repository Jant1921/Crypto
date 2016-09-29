using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem {
    class Fabrica {

        private IEnumerable<Traductor> traductores;
        private IEnumerable<Persistencia> persistencia;

        Fabrica() {
            traductores = buscarAlgoritmos<Traductor>();
            persistencia = buscarAlgoritmos<Persistencia>();
        }

        protected IEnumerable<T> buscarAlgoritmos<T>(params object[] constructorArgs) where T : class {
            List<T> algoritmos = new List<T>();
            foreach(Type type in
            Assembly.GetAssembly(typeof(T)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)))) {
                algoritmos.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            return algoritmos;
        }

        IEnumerable<Traductor> getTraductores() {
            return traductores;
        }

        IEnumerable<Persistencia> getAlgoritmosPersistencia() {
            return persistencia;
        }
    }
}
