using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.Data.AbstractFactory;
using FileManager.DataAccess.Data.AbstractProduct;
using FileManager.DataAccess.Data.Product;

namespace FileManager.DataAccess.Data.ConcretFactory
{
    class FileFactory: IAbstractFactory
    {

        public  IFile CreateFile(string TypeFile)
        {
            switch (TypeFile)
            {
                case ".Text":
                    return new Txt();
                    break;
                case ".Json":
                    return new Json();
                    break;

                case ".Xml":
                    return new Xml();
                    break;
            }

            return null;
        }

        
    }
}
