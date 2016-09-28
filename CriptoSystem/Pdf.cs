using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CriptoSystem
{
    class Pdf : Persistencia
    {


        public override bool guardarArchivo(string nombreArchivo, string[] pTexto)
        {
            if (!File.Exists(nombreArchivo))
            {
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();
                Paragraph paragraph = new Paragraph(componerString(pTexto));
        
                doc.Add(paragraph);
                doc.Close();
                return true;
            }
            return false;
        }


    }
}
