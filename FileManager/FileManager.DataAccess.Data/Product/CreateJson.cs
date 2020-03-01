using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using Newtonsoft.Json;

namespace FileManager.DataAccess.Data.Product
{
    class CreateJson:JsonFactory
    {
        public string CreateFile()
        {
           
            
            var json = JsonConvert.SerializeObject(students);
            File.WriteAllText("students.json", json.ToString(), Encoding.UTF8);
            return student;
        }
    }
}
