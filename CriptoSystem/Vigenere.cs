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
        public override string tipoValor()
        {
            int p=1;
            return p.GetType().ToString().Split('.')[p.GetType().ToString().Split('.').Length - 1].ToString();
        }

        public override string codificar(string pTexto, string pValor)
        {
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
            return res;
        }

        public override string decodificar(string pTexto, string pValor)
        {
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
            return res;
        }
    }
}
