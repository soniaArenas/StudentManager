using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    class XmlFactory : IFileFactory
    {
        public ICreateFile CreateFile(string TypeFile)
        {
            throw new NotImplementedException();
        }

        public IDeleteFile DeleteFile(string TypeFile)
        {
            throw new NotImplementedException();
        }

        public IReadFile ReadFile(string TypeFile)
        {
            throw new NotImplementedException();
        }

        public IUpdateFile UpdateFile(string TypeFile)
        {
            throw new NotImplementedException();
        }
    }
}
