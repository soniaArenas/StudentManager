using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;

namespace FileManager.DataAccess.Data.AbstractProduct
{
    public abstract class IFile
    {
       public static SortedDictionary<int, Student> Students =
            new SortedDictionary<int, Student>();
       
        public abstract void CreateFile(object student);
        public abstract void ReadFile(object student);
        public abstract void UpdateFile(object student);
        public abstract void DeleteFile(object student);

    }
}
