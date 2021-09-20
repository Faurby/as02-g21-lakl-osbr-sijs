
namespace StudentRelated
{
    public class Student 
    {
        int _Id;
        string GivenName;
        string Surname;
        enum Status {
            New,
            Active,
            Dropout,
            Graduated
        }
        DateTime StartDate;
        DateTime EndDate;
        DateTime GraduationDate;

        public Student(int Id) 
        {
            _Id = Id;
        }

        public string ToString() 
        {
            
        }
    }
}