using System; 
using Xunit;
using StudentLibrary;

namespace ImmutableStudentLibraryTests 
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void Compare_two_records() 
        {
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2025, 12, 1);
            var graduateDate = new DateTime(2023, 4, 7);

            var student1 = new ImmutableStudent(4002, "Niels", "Nielsen", startDate, endDate, graduateDate);
            var student2 = new ImmutableStudent(4002, "Niels", "Nielsen", startDate, endDate, graduateDate);

            bool compareTwoRecords = student1.Equals(student2);

            Assert.True(compareTwoRecords);
        }

        [Fact]
        public void Checks_three_dates_compared_new_immutablestudent()
        {
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2030, 12, 1);
            var graduateDate = new DateTime(2030, 4, 7);

            var student = new ImmutableStudent(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = StudentLibrary.ImmutableStudent.Status.New;
            var actual = student.GetStatus();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Checks_three_dates_compared_dropout_immutablestudent()
        {
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2020, 12, 1);
            var graduateDate = new DateTime(2025, 4, 7);

            var student = new ImmutableStudent(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = StudentLibrary.ImmutableStudent.Status.Dropout;
            var actual = student.GetStatus();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Checks_three_dates_compared_graduation_immutablestudent()
        {
            var startDate = new DateTime(2015, 1, 1);
            var endDate = new DateTime(2020, 4, 7);
            var graduateDate = new DateTime(2020, 4, 7);

            var student = new ImmutableStudent(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = StudentLibrary.ImmutableStudent.Status.Graduated;
            var actual = student.GetStatus();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_prints_expected_output_immutablestudent() 
        {
            var startDate = new DateTime(2020, 1, 1);
            var endDate = new DateTime(2025, 12, 1);
            var graduateDate = new DateTime(2023, 4, 7);

            var student = new ImmutableStudent(4001, "Hans", "Hansen", startDate, endDate, graduateDate);

            var expected = "Id: 4001, Hans Hansen \r\n Status: Active \r\n Start date: 01-01-2020 00:00:00 \r\n End date: 01-12-2025 00:00:00 \r\n Graduation date: 07-04-2023 00:00:00";
            var output = student.ToString();

            Assert.Equal(expected, output);
        }
    }
}