using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
   public interface IFileFactory
    {
        ICreateFile GetCreateFile();
        IReadFile GetReadFile();
        IUpdateFile GetUpdateFile();
        IDeleteFile GetDeleteFile();
       
    }
}
