using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Layer
{
    public class Student
    {
       public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string studentAge { get; set; }
       

        public Student (int Id,string name, string surname, string age)
        {
            StudentId = Id;
            StudentName = name;
            StudentSurname = surname;
            studentAge = age;
        }

    }
}
