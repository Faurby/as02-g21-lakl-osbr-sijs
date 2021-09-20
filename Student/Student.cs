
namespace StudentRelated
{
    public class Student 
    {
        int _Id;
        string _GivenName;
        string _Surname;
        enum Status {
            New,
            Active,
            Dropout,
            Graduated
        }
        DateTime _StartDate;
        DateTime _EndDate;
        DateTime _GraduationDate;

        public string _GivenName { get; set; }
        public string _SurName { get; set; }
        public string _StartDate { get; set; }
        public string _EndDate { get; set; }
        public string _GraduationDate { get; set; }

        public Student(int Id, string GivenName, string SurName, DateTime StartDate, DateTime EndDate, DateTime GraduationDate) 
        {
            _Id = Id;
            
        }

        public override string ToString() 
        {
            
        }

        public 
    }
}