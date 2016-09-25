﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class CBinaria : Traductor
    {
        public string alfabeto = "abcdefghijklmnopqrstuvwxyz";

        string ceros(string texto)
        {
            string res = "";

            for (int i = 0; i < 5; i++){

                if (i < texto.Length)
                {
                    res = res + texto.ElementAt(i);
                }else
                {
                    res = "0" + res;
                }
            }
            return res;
        }
        string convertirNumABinario(string letra)
        {
            string res = "";
            int numAsociado = alfabeto.IndexOf(letra.ElementAt(0));

                while (numAsociado > 0)
                {
                    if (numAsociado % 2 == 0)
                    {
                        res = "0" + res;
                    }
                    else
                    {
                        res = "1" + res;
                    }
                    numAsociado = (int)(numAsociado / 2);
                }
                return ceros(res);
        }
        public override string codificar(string pTexto)
        {
            string res = "";
            for(int i = 0; i < pTexto.Length; i++)
            {
                if(pTexto.ElementAt(i)==' ')
                {
                    res = res + "* ";
                }else
                {
                    res = res + convertirNumABinario("" + pTexto.ElementAt(i)) + " ";
                }

            }
            return res;
            
        }

        public int BinADec(string binario)
        {
            int exponente = binario.Length - 1;
            int numero = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (int.Parse(binario.Substring(i, 1)) == 1)
                {
                    numero = numero + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return numero;
        }

        public override string decodificar(string pTexto)
        {
            string[] numeros = pTexto.Split(' ');
            string res = "";
            for(int i = 0; i < numeros.Length-1; i++)
            {
                if (numeros[i] == "*")
                {
                    res = res + " ";
                }else
                {
                    res = res + alfabeto.ElementAt(BinADec(numeros[i]));
                }
            }
            return res;
        }
    }
}
