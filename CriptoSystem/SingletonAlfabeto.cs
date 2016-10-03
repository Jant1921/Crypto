namespace CriptoSystem {
    class SingletonAlfabeto
    {
        private static Alfabeto alfabeto;
        
        private static Alfabeto crearAlfabeto()
        {
            return new Alfabeto();
        }

        public static Alfabeto getInstance()
        {
            if(alfabeto == null)
            {
                alfabeto=crearAlfabeto();
            }
            return alfabeto;
        }

    }
}
