using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.classes
{
    internal class Student
    {
        public int Id1 { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string surname { get; set; }

        public Student(int id, string name, string surname)
        {
            Id = Id1++;
            Name = name;
            this.surname = surname;
        }
    }
}
