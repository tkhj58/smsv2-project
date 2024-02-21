using System;

namespace StudentManagement
{
    public class UserInterface
    {
        private StudentManagement sms;
        public UserInterface(StudentManagement SMS)
        {
            sms = SMS;
        }
        public void Run()
        {
            Console.WriteLine("Welcome to the Student Management system (SMS)");
            Console.WriteLine("This Management system allows users to \n" +
                " add new Students, edit students, and search for students," );
            bool exit = false;
            do
            {
                DisplayMenu();
                string userInput = Console.ReadLine();
                Console.Clear(); // Comand clears the screen for user readability, due to a less clogged UI
                switch (userInput)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        EditStudent();
                        break;
                    case "3":
                        ViewCurrentStudents();
                        break;
                    case "4":
                        FindStudentRecord();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("option not available , please try input again.");
                        break;
                }

            } while (!exit);
        }
        public void DisplayMenu()
        {
            Console.WriteLine("\nStudent Management System (SMS)");
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Edit a student record");
            Console.WriteLine("3. View current students");
            Console.WriteLine("4. Find student record");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your option: ");
        }
        public void AddStudent()
        {
            Console.Write("Enter student title: ");
            string title = Console.ReadLine();
            Console.Write("Enter the firstname: ");
            string Firstname = Console.ReadLine();
            Console.Write("Enter the Surname: ");
            string Surname = Console.ReadLine();
            Console.Write("Enter the SID: ");
            string sid = Console.ReadLine();
            Console.Write("Enter student contact number: ");
            string Phonenumber = Console.ReadLine();
            Console.Write("Enter Students address postcode: ");
            string Postcode = Console.ReadLine();
            if (sms.StudentExists(sid))
            {
                Console.WriteLine($"This student {sid} has an existing record");
            }
            else
            {
                Student newstudent = new Student(title, Firstname, Surname, sid, Phonenumber, Postcode);
                sms.AddStudent(newstudent);
            }
        }

        public void ViewCurrentStudents()
        {
            foreach (Student PresentStudent in sms.PresentStudents.Values)
            {
                Console.WriteLine($"Title: '{PresentStudent.Title}' First name: '{PresentStudent.Name}'Last name:'{PresentStudent.LastName} ID: '{PresentStudent.StudentId}'");
            }
        }
        public void EditStudent()
        {
            Console.Write("Enter the students SID: ");
            string sid = Console.ReadLine();
            sms.EditStudent(sid);
        }
        public void FindStudentRecord()
        {
            Console.Write("Enter the student's sid or postcode: ");
            string sid = Console.ReadLine();
            sms.FindStudentRecord(sid);
        }
    }
}

