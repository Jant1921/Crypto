using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;

namespace CriptoSystem
{
    class Pdf : Persistencia
    {


        public override bool guardarArchivo( )
        {

            String nombreArchivo = "ArchivoPdf.pdf";


            if (!File.Exists(nombreArchivo))
            {
                String[] pTexto = { Dto.getDatos()};
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();
                Paragraph paragraph = new Paragraph(componerString(pTexto));

                doc.Add(paragraph);
                doc.Close();
                return true;
            }
            else {

                PdfReader reader = new PdfReader(nombreArchivo);
                string text = string.Empty;
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    text += PdfTextExtractor.GetTextFromPage(reader, page);
                }
                reader.Close();

               
                String[] pTexto = { text,Dto.getDatos() };
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




