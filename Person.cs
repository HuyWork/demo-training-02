using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceApp
{
    internal class Person
    {
        string? name;
        int age;
        float height;
        float weight;

        public string? Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }

        public Person() { }

        public Person(string? name, int age, float height, float weight)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return "Name: " + Name + " | Age: " + Age + " | Height: " + Height + " | Weight: " + Weight + "\n";
        }
    }
}
