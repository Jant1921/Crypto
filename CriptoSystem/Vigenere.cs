using System;
using System.Linq;

namespace CriptoSystem
{
    class Vigenere : Traductor
    {
        private string pValor;

        public override void codificar() {
            cargarDatos();
            Dto.TipoTraduccion = "Codificacion";
            int val = Int32.Parse(pValor);
            string res = "";
            int primero = val / 10;
            int segundo = val % 10;
            bool flag = true;
            for (int i = 0; i < pTexto.Length; i++)
            {
                if (pTexto.ElementAt(i) == ' ')
                {
                    res = res + " ";
                    flag = true;
                }
                else
                {
                    if (flag)
                    {
                        res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(pTexto.ElementAt(i)) + primero) % Alfabeto.Length);
                        flag = false;
                    }
                    else
                    {
                        res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(pTexto.ElementAt(i)) + segundo) % Alfabeto.Length);
                        flag = true;
                    }
                }
            }
            Dto.FraseResultado = res;
        }

        public override void decodificar(){
            cargarDatos();
            Dto.TipoTraduccion = "Decodificacion";
            int val = Int32.Parse(pValor);
            string res = "";
            int primero = val / 10;
            int segundo = val % 10;
            bool flag = true;
            for (int i = 0; i < pTexto.Length; i++)
            {
                if (pTexto.ElementAt(i) == ' ')
                {
                    res = res + " ";
                    flag = true;
                }
                else
                {
                    if (flag)
                    {
                        if ((Alfabeto.IndexOf(pTexto.ElementAt(i)) - primero < 0))
                        {
                            res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(pTexto.ElementAt(i)) - primero + Alfabeto.Length));
                        }
                        else
                        {
                            res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(pTexto.ElementAt(i)) - primero));
                        }
                        flag = false;
                    }
                    else
                    {
                        if ((Alfabeto.IndexOf(pTexto.ElementAt(i)) - segundo < 0))
                        {
                            res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(pTexto.ElementAt(i)) - segundo + Alfabeto.Length));
                        }
                        else
                        {
                            res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(pTexto.ElementAt(i)) - segundo));
                        }
                        flag = true;
                    }
                }
            }
            Dto.FraseResultado = res;
        }

        protected override void cargarDatos() {
            Alfabeto = Dto.Alfabeto.Caracteres;
            pTexto = Dto.FraseOriginal;
            pValor = "23";
            Dto.NombreAlgoritmo = "Vigenere";
        }

    }
}
