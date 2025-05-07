using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStudents
{
    internal class Teacher
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Subject { get; set; }
        public List<Student> Students { get; set; } = new();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public override string ToString()
        {
            string studentsString = "";
            for (int i = 0; i < this.Students.Count; i++)
            {
                studentsString += this.Students[i].ToString() + "\n\n";
            }
            return $"TEACHER\nFull Name: {this.Name} {this.Surname}\nSubject: {this.Subject}\nStudents:\n\n{studentsString}";
        }
    }
}
