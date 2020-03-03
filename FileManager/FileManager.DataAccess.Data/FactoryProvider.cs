using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data.AbstractFactory;
using FileManager.DataAccess.Data.ConcretFactory;

namespace FileManager.DataAccess.Data
{
    public static class FactoryProvider
    {

        public static IAbstractFactory GetFactory(string TypeFile)
        {
            return new FileFactory();
            
        }
    }
}
