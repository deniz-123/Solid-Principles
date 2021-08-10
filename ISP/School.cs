namespace SolidPrinciples.ISP
{
    public class School
    {
        interface IHuman
        {
            string Name { get; set; }
            int Age { get; set; }
        }

        interface IStudent : IHuman
        {
            double GPA { get; set; }
            int Year { get; set; }
        }

        interface ITeacher : IHuman
        {
            double Salary { get; set; }
            string Profficiency { get; set; }
        }

        public class Student : IStudent
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double GPA { get; set; }
            public int Year { get; set; }
        }

        public class Teacher : ITeacher
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
            public string Profficiency { get; set; }
        }
    }
}
