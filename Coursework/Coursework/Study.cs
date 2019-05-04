using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Study
    {
        private string subject;
        private string name_teacher;
        private double mark;

        public string Subject { get => subject; set => subject = value; }
        public string Name_teacher { get => name_teacher; set => name_teacher = value; }
        public double Mark { get => mark; set => mark = value; }

        public Study(string subject, string name_teacher, double mark)
        {
            Subject = subject;
            Name_teacher = name_teacher;
            Mark = mark;
        }
        public Study()
        {
        }
    }    
}
