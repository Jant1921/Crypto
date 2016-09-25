using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace CriptoSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            String[] esc = { "Angela", "Andrey" };
            pro.crearPDF("prueba2.pdf",esc);
            Console.WriteLine("Hola mundo :)");
            Console.ReadKey();
        }

        String compose(String[] arrayString)
        {
            String temp = "";
            for(int i = 0; i < arrayString.Length; i++)
            {
                temp = temp + arrayString[i] + "\n";
            }
            return temp;
        }

        bool crearPDF(String nombreArchivo, String[] texto)
        {
            if (!File.Exists(nombreArchivo))
            {
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();

                Paragraph paragraph = new Paragraph(compose(texto));

                doc.Add(paragraph);
                doc.Close();
                return true;
            }
            return false;
            
        }

        bool crearTxt(String nombreArchivo, String[] texto)
        {
            if (!File.Exists(nombreArchivo))
            {
                System.IO.File.WriteAllLines(nombreArchivo, texto);
                return true;
            }
            return false;
            
        }
    }
}
