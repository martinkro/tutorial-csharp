using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace TestXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "${InPath}/";
            file += @"c:\data\in";
            Console.WriteLine(file);
            return;
            string xmlPath = GetXmlFile("test.xml");
            GenerateXMLFile(xmlPath);
            TestXmlReader(xmlPath);

            xmlPath = GetXmlFile("obfuscar.xml");
            TestXmlWriter(xmlPath);

        }

        static XmlReaderSettings GetReaderSettings()
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;
            return settings;
        }

        static void TestXmlReader(string xmlPath)
        {
            XmlReader reader = XmlReader.Create(xmlPath);
            while(reader.Read())
            {
                Console.WriteLine(reader.Name);
            }

            Console.WriteLine("\n Reading from a string ...\n");

            string xmldoc = @"<student id='12' status='archived'>
                            <firstname>Mark</firstname>
                            <lastname>Taylor</lastname>
                            </student>";
            XmlReader xmr2 = XmlReader.Create(new System.IO.StringReader(xmldoc));
            while (xmr2.Read())
            {
                Console.WriteLine(xmr2.Name);
            }
        }

        static void TestXmlWriter(string xmlPath)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(xmlPath, settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("Obfuscator");
            writer.WriteStartElement("Module");
            writer.WriteAttributeString("name", "Assembly-CSharp.dll");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        static void GenerateXMLFile(string xmlPath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlElement rootElement = doc.CreateElement("Obfuscator");
                doc.AppendChild(rootElement);

                XmlElement varElement = doc.CreateElement("Var");
                varElement.SetAttribute("name", "InPath");
                varElement.SetAttribute("value", @".\in");
                rootElement.AppendChild(varElement);
                varElement = doc.CreateElement("Var");
                varElement.SetAttribute("name", "OutPath");
                varElement.SetAttribute("value",@".\out");
                rootElement.AppendChild(varElement);

                doc.Save(xmlPath);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static string GetXmlFile(string filename)
        {
            if(string.IsNullOrEmpty(filename))
            {
                filename = "test.xml";
            }
            string dir = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            return Path.Combine(dir, filename);
        }
    }
}
