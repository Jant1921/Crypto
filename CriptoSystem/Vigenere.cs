using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class Vigenere : Traductor
    {
        public string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        private Datos dto;

        public Datos Dto {
            get { return dto; }
            set { dto = value; }
        }
        
        public override void codificar(){
            string pTexto = Dto.FraseOriginal;
            string pValor = Dto.ValorCodificacion;
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
                        res = res + alfabeto.ElementAt((alfabeto.IndexOf(pTexto.ElementAt(i)) + primero) % alfabeto.Length);
                        flag = false;
                    }
                    else
                    {
                        res = res + alfabeto.ElementAt((alfabeto.IndexOf(pTexto.ElementAt(i)) + segundo) % alfabeto.Length);
                        flag = true;
                    }
                }
            }
            Dto.FraseResultado = res;
        }

        public override void decodificar(){
            string pTexto = Dto.FraseOriginal;
            string pValor = Dto.ValorCodificacion;
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
                        if ((alfabeto.IndexOf(pTexto.ElementAt(i)) - primero < 0))
                        {
                            res = res + alfabeto.ElementAt((alfabeto.IndexOf(pTexto.ElementAt(i)) - primero + alfabeto.Length));
                        }
                        else
                        {
                            res = res + alfabeto.ElementAt((alfabeto.IndexOf(pTexto.ElementAt(i)) - primero));
                        }
                        flag = false;
                    }
                    else
                    {
                        if ((alfabeto.IndexOf(pTexto.ElementAt(i)) - segundo < 0))
                        {
                            res = res + alfabeto.ElementAt((alfabeto.IndexOf(pTexto.ElementAt(i)) - segundo + alfabeto.Length));
                        }
                        else
                        {
                            res = res + alfabeto.ElementAt((alfabeto.IndexOf(pTexto.ElementAt(i)) - segundo));
                        }
                        flag = true;
                    }
                }
            }
            Dto.FraseResultado = res;
        }
    }
}
