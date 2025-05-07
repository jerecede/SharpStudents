using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStudents
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

        private int _yob;
        public int Yob
        {
            get => _yob;
            set
            {
                if (value < 1900)
                {
                    _yob = 1900;
                }
                else
                {
                    _yob = value;
                }
            }
        }

        private List<int> _marks = [];
        public List<int>? Marks {
            get => _marks;
            set => _marks = value;
        }

        public Student(string name, string surname, string gender, int yob, List<int> marks)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
            Marks = marks;
        }

        public double Mean()
        {
            return (double)this._marks.Sum() / this._marks.Count; //basta che uno sia castato
        }

        public override string ToString()
        {
            string MarksString = "";
            for (int i = 0; i < this._marks.Count; i++)
            {
                MarksString = MarksString + this._marks[i] + ",";
            }
            MarksString = MarksString.TrimEnd(','); //remove last comma
            return $"STUDENT\nFull Name: {this.Name} {this.Surname}\nGender: {this.Gender}\nYear of Birth: {this.Yob}\nMarks: {MarksString}";
        }
    }
}
