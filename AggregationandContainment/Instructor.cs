using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AggregationandContainment
{
    //Instructor
    //Fields✔ 
    //string _firstName;✔ 
    //string _lastName;✔ 
    //Constructor and Property for both✔ 
    //Override ToString✔ 
    //First Name Last Name✔ 
    public class Instructor
    {
        string _firstName; 
        string _lastName;

        public Instructor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public override string ToString()
        {
            return $"Instructor: {_firstName} {_lastName}";
        }
    }
}//NameSpace 
