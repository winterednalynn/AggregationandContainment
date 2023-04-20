using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationandContainment
{

    //Student
    //Fields
    //string _firstName;✔ 
    //string _lastName;✔ 
    //int _csiGrade;✔ 
    //int _genEdGrade;✔ 
    //Constructor and Property for all✔ 
    //Override ToString✔ 
    //First Name - Last Name - CSI Grade - GenEd Grade✔ 
    
    public class Student
    {
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CsiGrade = csiGrade;
            GenEdGrade = genEdGrade;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public override string ToString()
        {
            return $"First Name: {_firstName} \n Last Name: {_lastName} \n CSI Grade: {_csiGrade} \n GenEd Grade: {_genEdGrade}"; 
        }


    }

}//Namespace
