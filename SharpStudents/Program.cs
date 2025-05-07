namespace SharpStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("jeremias", "cedeno", "male", 2003, new List<int> { 5, 4, 10 });
            Console.WriteLine(s1.Mean());
            Student s2 = new Student("hugo", "martinez", "male", 1995, new List<int> { 7, 9, 10 });
            Student s3 = new Student("jan", "stigliani", "male", 200, new List<int> { 7, 8, 6 });

            List<Student> students = [s1, s2, s3];
            foreach (var student in students)
            {
                Console.WriteLine(student.Mean());
            }

            Teacher t1 = new Teacher { Name = "andrea", Surname = "asioli", Subject = "computer science", Students = students };
            Console.WriteLine(t1.ToString());
        }
    }
}
