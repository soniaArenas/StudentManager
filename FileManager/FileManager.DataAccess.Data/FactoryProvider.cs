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

        public static IFileFactory GetFactory(string TypeFile)
        {
           
                switch (TypeFile)
                {
                    case ".text":
                        return new TxtFactory();
                        break;
                    case ".json":
                        return new JsonFactory();
                        break;

                    case ".xml":
                        return new XmlFactory();
                        break;
                }

                return null;
        }
    }
}
