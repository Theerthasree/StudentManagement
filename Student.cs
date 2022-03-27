using System;

namespace studentmanagementsystem
{
    public class Student
    {
        int id;
        string name;
        DateTime Dob;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime dob { get => Dob; set => Dob = value; }

        public Student(int id, string name, DateTime Dob)
        {
            this.Id = id;
            this.Name = name;
            this.dob = Dob;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return this.id + " " + this.name + " " + this.Dob;
            // $"Student(Id: {this.id}, Name: {this.name},Dob: {this.dob})"; 
        }
    }
}
