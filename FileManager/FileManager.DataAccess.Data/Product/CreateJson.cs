using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using Newtonsoft.Json;
using FileManager.DataAccess.Data;

namespace FileManager.DataAccess.Data.Product
{
    class CreateJson:ICreateFile
    {
        public string CreateFile(string TypeFile)
        {
            /*var json = JsonConvert.SerializeObject(students.);
            File.WriteAllText("students.json", json.ToString(), Encoding.UTF8);
            return student;*/
            return "He creado";
        }
    }
}
