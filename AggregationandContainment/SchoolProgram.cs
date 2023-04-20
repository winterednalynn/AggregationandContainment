using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AggregationandContainment
{
    public class SchoolProgram
    {
        //Fields
        //string _className;✔ 
        //string _classNumber;✔ 
        //string _roomNumber;✔ 
        //Instructor _instructor; // Aggregation✔ 
        //List<Student> _classRoster; // Containment✔ 

        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; 
        List<Student> _classRoster;


        //Constructor✔ 
        //School(className, classNumber, roomNumber, instructor)✔ 
        //Initialize the List of students inside the constructor, do not let the user pass in their own list. (?) //Uncertain if I did this. 

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            ClassName = className;
            ClassNumber = classNumber;
            RoomNumber = roomNumber;
            Instructor = instructor;
            _classRoster = new List<Student>();

         

        }
         public SchoolProgram()
        {
            _classRoster = new List<Student>(); 
        }

        //Property✔ 
        //className, classNumber, roomNumber, instructors(get; set; )✔ 
        //classRoster(get only, no set)✔ 
        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        public Instructor Instructor { get => _instructor; set => _instructor = value; }
       public List<Student> ClassRoster { get => _classRoster;  }

        //Methods

       
        //AddStudent(Student student) ✔ 
        //Add a student object to the class student list✔ 
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }
        //AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)✔ 
        //Takes information for a student object.(?)
        //Create a new student object in the method, and add them to the classRoster list.(?)
        public void AddStudent(string firstName, string lastName, int CSIgrade, int GenEdGrade)
        {
           Student student = new Student(firstName, lastName, CSIgrade, GenEdGrade);
            _classRoster.Add(student); 
        }

        //Override ToString - Extra Credit ( + 1 )
        //Class Name - Class Number - Room Number - Instructor Name - Number of Students
        // Prog 124 : J102 - Will Cram - Number of Students: 13
        public override string ToString()
        {
            return $"Class Name: {_className}, Class Number : {_classNumber}, Room Number {_roomNumber}, Instructor Name: {_instructor}, Number of Student {_classRoster}"; 
        }

    }
}
