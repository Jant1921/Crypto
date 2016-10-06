using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem {
    
    class Telefonico : Traductor {
        Dto datos = new Dto();
        AlgoritmoTelefonico telefono;
        public override void codificar() {
            cargarDatos();
            datos.TiraInicial = Dto.FraseOriginal;
            Dto.TipoTraduccion = "Codificacion";
            telefono.codificar(datos);
            Dto.FraseResultado = datos.TiraFinal[0];
            datos.TiraFinal.Clear();
        }

        public override void decodificar() {
            cargarDatos();
            Dto.TipoTraduccion = "Decodificacion";
            datos.TiraInicial = Dto.FraseOriginal;
            telefono.decodificar(datos);
            Dto.FraseResultado = datos.TiraFinal[0];
            datos.TiraFinal.Clear();
        }

        protected override void cargarDatos() {
            telefono = new AlgoritmoTelefonico();
            Alfabeto = Dto.Alfabeto.Caracteres;
            pTexto = Dto.FraseOriginal;
            Dto.NombreAlgoritmo = "Algoritmo Telefonico";
        }
    }
}
