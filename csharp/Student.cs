using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceApp
{
    internal class Student
    {
        int id;
        string? school;
        string? classroom;

        public int Id { get => id; set => id = value; }
        public string? School { get => school; set => school = value; }
        public string? Classroom { get => classroom; set => classroom = value; }

        public Student()
        {
        }

        public Student(int id, string? school, string? classroom)
        {
            this.Id = id;
            this.School = school;
            this.Classroom = classroom;
        }

        public void Study()
        {
            Console.WriteLine("study");
        }
    }
}
