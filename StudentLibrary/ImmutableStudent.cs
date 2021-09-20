using System;

namespace StudentLibrary 
{
    public record ImmutableStudent
    {
        public int Id { get; init; }
        public string GivenName { get; init; }
        public string SurName { get; init; }
        public enum Status {
            New,
            Active,
            Dropout,
            Graduated
        }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }

        public ImmutableStudent(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate) 
        {
            (Id, GivenName, SurName, StartDate, EndDate, GraduationDate) = (id, givenName, surName, startDate, endDate, graduationDate);
        }

        public Status GetStatus() 
        {
            // DateTime: Year, month, day
            DateTime localDate = DateTime.Now;

            var localStart = DateTime.Compare(localDate, StartDate);
            var localGraduation = DateTime.Compare(localDate, GraduationDate);
            var localEnd = DateTime.Compare(localDate, EndDate);
            var endGraduation = DateTime.Compare(EndDate, GraduationDate);

            // New student
            if (localStart == -1) 
            {
                return Status.New;
            }
            // Active student
            else if (localStart == 1 && localEnd == -1)
            {
                return Status.Active; 
            }
            // Dropout
            else if (endGraduation == -1 && localEnd == 1) 
            {
                return Status.Dropout;
            }
            // Graduated
            else 
            {
                return Status.Graduated;
            }
        }

        public override string ToString() 
        {
            return $"Id: {Id}, {GivenName} {SurName} \r\n Status: {GetStatus()} \r\n Start date: {StartDate} \r\n End date: {EndDate} \r\n Graduation date: {GraduationDate}";
        }
    }
    
}