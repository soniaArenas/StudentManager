using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
    class Xml:IFileFactory
    {
        public ICreateFile GetCreateFile()
        {
            throw new NotImplementedException();
        }

        public IReadFile GetReadFile()
        {
            throw new NotImplementedException();
        }

        public IUpdateFile GetUpdateFile()
        {
            throw new NotImplementedException();
        }

        public IDeleteFile GetDeleteFile()
        {
            throw new NotImplementedException();
        }

       
    }
}
