using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Student
    {
        private string name;
        private string record_number;
        private string name_faculty;
        private string course;
        
        public string Name { get => name; set => name = value; }
        public string Record_number { get => record_number; set => record_number = value; }
        public string Name_faculty { get => name_faculty; set => name_faculty = value; }
        public string Course { get => course; set => course = value; }        

        public Student()
        {
        }
        public Student(string name, string record_number, string name_faculty, string course)
        {
            Name = name;
            Record_number = record_number;
            Name_faculty = name_faculty;
            Course = course;            
        }
    }
}
