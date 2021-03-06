﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringWriterOutPutXmlWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Gera o XML*/
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();

            /*Lê o XML e transforma em  dados*/
            var stringReader = new StringReader(xml);

            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(),
                new CultureInfo("en-US")); // Make sure that you read the decimal part correctly
            }

            string value = "My Sample Value";
            string subString = value.Substring(3, 6);
        }

    }
}
