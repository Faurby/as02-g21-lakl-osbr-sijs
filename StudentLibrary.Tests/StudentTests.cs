using System;
using Xunit;
using StudentLibrary;

namespace StudentLibrary.Tests
{
    public class StudentTests
    {
        [Fact]
        public void ToString_prints_expected_output() 
        {
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2025, 12, 1);
            var graduateDate = new DateTime(2023, 4, 7);

            var student = new Student(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = "Id: 4001, Hans Hansen, Status: Active, Start date: 01-01-2020 00:00:00, End date: 01-12-2025 00:00:00, Graduation date: 07-04-2023 00:00:00";
            var output = student.ToString();

            Assert.Equal(expected, output);
        }

        [Fact]
        public void Checks_three_dates_compared_new()
        {
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2030, 12, 1);
            var graduateDate = new DateTime(2030, 4, 7);

            var student = new Student(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = StudentLibrary.Student.Status.New;
            var actual = student.BusinessRules();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Checks_three_dates_compared_dropout()
        {
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2020, 12, 1);
            var graduateDate = new DateTime(2025, 4, 7);

            var student = new Student(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = StudentLibrary.Student.Status.Dropout;
            var actual = student.BusinessRules();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Checks_three_dates_compared_graduation()
        {
            var startDate = new DateTime(2015, 1, 1);
            var endDate = new DateTime(2020, 4, 7);
            var graduateDate = new DateTime(2020, 4, 7);

            var student = new Student(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = StudentLibrary.Student.Status.Graduated;
            var actual = student.BusinessRules();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Id_only_accessed_when_Student_is_instantiated() 
        {   
            var startDate = new DateTime(2015, 1, 1);
            var endDate = new DateTime(2020, 4, 7);
            var graduateDate = new DateTime(2020, 4, 7);

            var student = new Student(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            // Spørg om assert her
            var expected = student.Id;
            var actual = 0;
        }
    }
}
