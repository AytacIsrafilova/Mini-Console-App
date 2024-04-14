using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    internal class Classroom
    {


        private static int nextId;
        private Student[] students;

        public int Id { get; set; }
        public string Name { get; set; }
        public ClassType Type { get; set; }
        public int Capacity { get; }
        public int StudentCount { get; private set; }

        public Classroom(string name, ClassType type)
        {
            Id = nextId++;
            Name = name;
            Type = type;
            Capacity = (type == ClassType.Backend) ? 20 : 15;
            students = new Student[Capacity];
        }


        Student[] Students = new Student[0];
        Classroom[] Classrooms = new Classroom[0];

        public void ClassRoomAdd(Classroom classroom)
        {
            Array.Resize(ref Classrooms, Classrooms.Length + 1);
            Classrooms[Classrooms.Length - 1] = classroom;
        }
        public void StudentAdd(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public int StudentFindId(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student.Id;
                }
            }
            return nextId;
        }

        public void StudentDeleteById(int id)
        {
            Student[] newStudents = { };
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    Array.Resize(ref newStudents, Students.Length + 1);
                    newStudents[Students.Length - 1] = student;
                }
            }
            Students = newStudents;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
    }  
}

