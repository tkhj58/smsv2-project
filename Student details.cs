using System.Runtime.ExceptionServices;

namespace StudentManagement
{
    public class Student
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public string ContactDetails { get; set; }
        public string PostCode { get; set; }

        public Student(string title, string Firstname, string sid, string Surname, string Phonenumber, string Postcode)
        {
            Title = title;
            Name =  Firstname;
            LastName = Surname;
            StudentId = sid;
            ContactDetails = Phonenumber;
            PostCode = Postcode;
        }
    }
}