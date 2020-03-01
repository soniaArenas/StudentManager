using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Data
{
   public interface IFileFactory
    {
        ICreateFile CreateFile();
        IReadFile ReadFile();
        IUpdateFile UpdateFile();
        IDeleteFile DeleteFile();
       
    }
}
