using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.Data.Product;

namespace FileManager.DataAccess.Data
{
    public class JsonFactory : IFileFactory
    {
        public ICreateFile CreateFile()
        {
            return new CreateJson();
        }

        public IDeleteFile DeleteFile()
        {
            throw new NotImplementedException();
        }

        public IReadFile ReadFile()
        {
            throw new NotImplementedException();
        }

        public IUpdateFile UpdateFile()
        {
            throw new NotImplementedException();
        }
    }
}
