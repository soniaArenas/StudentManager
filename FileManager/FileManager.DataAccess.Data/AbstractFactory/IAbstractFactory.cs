using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.Data.AbstractProduct;

namespace FileManager.DataAccess.Data.AbstractFactory
{
    public interface IAbstractFactory
    {
        IFile CreateFile(string TypeFile);
    }
}
