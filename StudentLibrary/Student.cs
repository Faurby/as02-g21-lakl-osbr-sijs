using System;

namespace StudentLibrary
{
    public class Student 
    {
        int _Id;
        string _GivenName;
        string _SurName;
        public enum Status {
            New,
            Active,
            Dropout,
            Graduated
        }
        DateTime _StartDate;
        DateTime _EndDate;
        DateTime _GraduationDate;

        // Properties
        public int Id 
        { 
            get => _Id; 
            // init Only to be set in constructor
        }
        public string GivenName 
        {
            get => _GivenName;
            set => _GivenName = value;
        }
        public string SurName 
        {
            get => _SurName;
            set => _SurName = value;
        }
        public DateTime StartDate 
        {
            get => _StartDate;
            set => _StartDate = value; 
        }
        public DateTime EndDate
        {
            get => _EndDate;
            set => _EndDate = value; 
        }
        public DateTime GraduationDate
        {
            get => _GraduationDate;
            set => _GraduationDate = value; 
        }

        public Student(int Id, string GivenName, string SurName, DateTime StartDate, DateTime EndDate, DateTime GraduationDate) 
        {
            _Id = Id; // Only set in constructor
            _GivenName = GivenName;
            _SurName = SurName;
            _StartDate = StartDate;
            _EndDate = EndDate;
            _GraduationDate = GraduationDate;
        }

        public Status BusinessRules() 
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
            return $"Id: {Id}, {GivenName} {SurName}, Status: {BusinessRules()}, Start date: {StartDate}, End date: {EndDate}, Graduation date: {GraduationDate}";
        }
    }
}
