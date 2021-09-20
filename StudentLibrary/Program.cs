using System;

namespace StudentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var StartDate = new DateTime(2020, 8, 10);
            var EndDate = new DateTime(2025, 05, 28);
            var GraduationDate = new DateTime(2025, 05, 28);
            Student student = new Student(4317, "Simon Johann", "Skødt", StartDate, EndDate, GraduationDate);
            
            Console.WriteLine(student.ToString());
        }
    }
}
