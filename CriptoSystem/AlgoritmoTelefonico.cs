using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class AlgoritmoTelefonico
    {
        Dictionary<char, string> abecedario;
        private String tiraInicial;
        private String tiraFinal = null;
        private StringBuilder sb = new StringBuilder();

        public AlgoritmoTelefonico()
        {
            abecedario = new Dictionary<char, string>();
        }
        public void codificar(Dto dto)
        {
            iniciarDiccionario();


            int y = 0;
            tiraInicial = dto.TiraInicial;  //Variables.Se les da los valores del dto



            String[] oraciones = tiraInicial.Split(' ');// la oracion se convierte en un array de palabras


            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];


                for (int i = 0; i < oracionActual.Length; i++)
                {
                    if (abecedario.ContainsKey(oracionActual[i]))
                    {
                        tiraFinal += " " + abecedario[oracionActual[i]] + " ";




                    }

                }
                tiraFinal += "*";
                y++;


            }

            tiraFinal = tiraFinal.TrimEnd('*');
            dto.TiraFinal.Add(tiraFinal);
        }

        public void decodificar(Dto dto)
        {
            iniciarDiccionario();


            int y = 0;
            tiraInicial = dto.TiraInicial;  //Variables.Se les da los valores del dto



            String[] oraciones = tiraInicial.Split(' ');// la oracion se convierte en un array de palabras


            while (y < oraciones.Length)
            {
                String oracionActual = oraciones[y];

                
                foreach (KeyValuePair<char, string> par in abecedario)
                {
                    if (par.Value == oracionActual)
                    {
                        sb.Append(par.Key);
                        tiraFinal = sb.ToString();
                      
                    }
                }
                y++;
                
            }
            sb.Append(" ");
            sb.ToString();
            dto.TiraFinal.Add(tiraFinal);
        }

        
       

        public void iniciarDiccionario()
        {
            abecedario.Add('a', "21");
            abecedario.Add('b', "22");
            abecedario.Add('c', "23");
            abecedario.Add('d', "31");
            abecedario.Add('e', "32");
            abecedario.Add('f', "33");
            abecedario.Add('g', "41");
            abecedario.Add('h', "42");
            abecedario.Add('i', "43");
            abecedario.Add('j', "51");
            abecedario.Add('k', "52");
            abecedario.Add('l', "53");
            abecedario.Add('m', "61");
            abecedario.Add('n', "62");
            abecedario.Add('o', "63");
            abecedario.Add('p', "71");
            abecedario.Add('q', "72");
            abecedario.Add('r', "73");
            abecedario.Add('s', "74");
            abecedario.Add('t', "81");
            abecedario.Add('u', "82");
            abecedario.Add('v', "83");
            abecedario.Add('w', "91");
            abecedario.Add('x', "92");
            abecedario.Add('y', "93");
            abecedario.Add('z', "94");
            abecedario.Add(' ',"*");

        }

    }

}