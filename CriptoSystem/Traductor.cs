namespace CriptoSystem {
    abstract class Traductor
    {
        static Datos dto;
        string alfabeto;
        protected string pTexto;
        
        public abstract void codificar();
        public abstract void decodificar();
        protected abstract void cargarDatos();

        public static Datos Dto {
            get { return dto; }
            set { dto = value; }
        }

        public string Alfabeto {
            get { return alfabeto; }
            set { alfabeto = value; }
        }


    }
}
