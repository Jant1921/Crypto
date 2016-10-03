using System;

namespace CriptoSystem {
    class SingletonAlfabeto
    {
        private static Alfabeto alfabeto;
        
        private static Alfabeto crearAlfabeto()
        {
            try {
                string[] lines = System.IO.File.ReadAllLines(@"alfabeto.config");
                string[] campos = lines[0].Split(' ');
                return new Alfabeto(campos[1], campos[0]);
            }
            catch(Exception e) {
                Console.WriteLine(e);
                return new Alfabeto();
            }

        }

        public static Alfabeto getInstance()
        {
            if(alfabeto == null)
            {
                alfabeto = crearAlfabeto();
            }
            return alfabeto;
        }

    }
}
