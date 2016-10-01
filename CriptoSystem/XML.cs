using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace CriptoSystem
{
    class XML : Persistencia
    {
        String nombreArchivo = "ArchivoXml.xml";
        

        public override bool guardarArchivo()
        {
            if (!File.Exists(nombreArchivo) )
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(nombreArchivo, xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Ejecuciones");

                    xmlWriter.WriteElementString("Ejecucion", Dto.getDatos());
                    
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(nombreArchivo);
                XElement root = xDocument.Element("Ejecuciones");
                IEnumerable<XElement> rows = root.Descendants("Ejecucion");
                XElement LastRow = rows.Last();
                LastRow.AddAfterSelf(
                  
                   new XElement("Ejecucion", Dto.getDatos())
                   );
                 
                xDocument.Save(nombreArchivo);
            }
            return false;

        }






    }
}
