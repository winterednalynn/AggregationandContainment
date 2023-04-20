using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationandContainment
{//EDNA LYNN LAXA 
 //PROGRAMMING III 
 //APRIL 18, 2023 
 //AGGREGATION & CONTAINMENT 
    internal class Program
    {
        //Create 3 classes : SchoolProgram, Instructor, Student✔ 
        static void Main(string[] args)
        {
            //In Main(or MainWindow or Form1, depending on your chosen GUI )
            //Create a new instance of SchoolProgram and Instructor.
            //When creating the SchoolPorgram pass your Instructor object into the constructor(this is aggregation ).
            //Create 3 Students and add them to the class roster using your AddStudent() methods, your choice of which to use.
            //Display all the information regarding the class ; // I got really stuck w/ the ADDSTUDENT part & how to display the x number of student. 

            Instructor teacher = new Instructor("James", "Bond");
            SchoolProgram Program = new SchoolProgram("Programming", "48", "K48", teacher);

            Program.AddStudent("Kitana", "Spring", 59, 89); 
            Program.AddStudent("Mileena", "Spring", 99, 98);
            Program.AddStudent("Jaxa", "Spring", 110, 100);

            Console.WriteLine(teacher.ToString());
            Console.WriteLine(Program.ToString());
           

        }
    }
}
