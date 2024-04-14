using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    internal class Student
    {
        private static int _idd;
        public int Id { get; set; }

        public Student(string namee,string surname)
        {
            Id = ++_idd;
            Name = namee;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Surname}";
        }
    }
}
