using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
   public interface IFileFactory
    {
        ICreateFile CreateFile(string TypeFile);
        IReadFile ReadFile(string TypeFile);
        IUpdateFile UpdateFile(string TypeFile);
        IDeleteFile DeleteFile(string TypeFile);
       
    }
}
