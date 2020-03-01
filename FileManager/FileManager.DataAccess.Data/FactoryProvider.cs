using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;

namespace FileManager.DataAccess.Data
{
    public static class FactoryProvider
    {

        public static IFileFactory GetFactory(string TypeFile, string TypePerson)
        {
           

                switch (TypeFile)
                {
                    case ".Text":
                        return new TxtFile();
                        break;
                    case ".Json":
                        return new JsonFile();
                        break;

                    case ".Xml":
                        return new XmlFile();
                        break;
                }

                return null;
            
            throw new NotSupportedException();
        }
    }
}
