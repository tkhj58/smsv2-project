using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class StudentManagement
    {
        private Dictionary<string, Student> CurrentStudents = new Dictionary<string, Student>();
        private Dictionary<string, Student> ExStudents = new Dictionary<string, Student>();
        public Dictionary<string, Student> PresentStudents
        {
            get
            {
                return PresentStudents;
            }
        }
        public Dictionary<string, Student> exStudents
        {
            get
            {
                return ExStudents;
            }
        }

        public bool StudentExists(string SID)
        {
            return ExStudents.ContainsKey(SID) ||
                CurrentStudents.ContainsKey(SID);
        }

        public void AddStudent(Student newStudent)
        {
            //Adds new students and not overwrtite them
            if (!StudentExists(newStudent.StudentId))
            {
                CurrentStudents.Add(newStudent.StudentId, newStudent);
            }
        }
        public void EditStudent(string SID)
        {
            //Access and edit student records
            if (StudentExists(SID))
            {
                Student editStudent = CurrentStudents[SID];
                ExStudents.Add(SID, editStudent);
                CurrentStudents.Remove(SID);
            }
        }
        public void FindStudentRecord(string SID)
        {
            //Utilises a search for students in the database
            if (StudentExists(SID))
            {
                Student existingStudent = ExStudents[SID];
                CurrentStudents.Add(SID, existingStudent);
                ExStudents.Remove(SID);
            }
      
        
        
        
        
        
        
        }
    }
}