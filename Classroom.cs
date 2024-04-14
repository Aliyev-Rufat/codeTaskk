using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.classes
{
    public enum ClassType
    {
        Backend,
        Frontend
    }

    internal class Classroom
    {
        public int Max_Backend_Student = 20;
        public int Min_Backend_Student = 15;

        public int Id { get; }
        public string Name { get; }
        public Student[] Students { get; set; }
        public ClassType Type { get; set; }

        public Classroom(int id, string name, ClassType type)
        {
            Id = id;
            Name = name;
            Type = type;
            Students = new Student[0];
        }


        public void AddStudent(Student student)
        {

        }

        public Student FindId(int id)
        {
            foreach (var student in Students)
            {
                if (student != null && student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Student student = Students[i - 1];
                }
            }


        }
    }
}
