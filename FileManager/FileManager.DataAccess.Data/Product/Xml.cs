using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.Data.AbstractProduct;
using System.Xml;
using FileManager.Common.Layer;
using System.IO;

namespace FileManager.DataAccess.Data.Product
{
    class Xml : IFile
    {
        public string path;
        public string name;
        public override void CreateFile(object student)
        {
            if (!File.Exists(path))
            {
                Create();
            }
          
        }

        public void Create()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, "Students", string.Empty);
            doc.AppendChild(element1);

        }
        public void AppendStudent()
        {
            XmlElement element2 = doc.CreateElement(string.Empty, "nivel1", string.Empty);
            element1.AppendChild(element2);
            XmlElement element3 = doc.CreateElement(string.Empty, "nivel2", string.Empty);
            XmlText text1 = doc.CreateTextNode("texto");
            element3.AppendChild(text1);
            element2.AppendChild(element3);
            XmlElement element4 = doc.CreateElement(string.Empty, "nivel3", string.Empty);
            XmlText text2 = doc.CreateTextNode("más texto");
            element4.AppendChild(text2);


           
        }
        public void GetStudentById()
        {
            XmlDocument docu = XmlDocument.Load(path);
            foreach (var node in docu.DescendantNodes)
        }
        public override void DeleteFile(object student)
        {
            throw new NotImplementedException();
        }

        public override void ReadFile(object student)
        {
            throw new NotImplementedException();
        }

        public override void UpdateFile(object student)
        {
            throw new NotImplementedException();
        }

        
    }
}
