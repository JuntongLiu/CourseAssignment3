using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning31inkapsling
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        
        // Use the parameter to create a person and return to the caller
        public  Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            // instantiate a Person type object
            // fill in the object's property
            //aPerson.Age = age;
            //aPerson.FName = fname;
            //aPerson.LName = lname;
            //aPerson.Height = height;
            //aPerson.Weight = weight;

            return new Person(age, fname, lname, height, weight);    // return to the caller to complete the person-creation.
        }

        // We need to change this class to an abstract class before we can declare the following
        // abstract functions.

       // // we prepare to make this an abstract or interface class, create a constructor
       //public PersonHandler()
       // {
       //     this.PersonGenerator();
       // }

       // // make an abstract function, so, all concrete-person-creator(teacher, engineer, sales,...) 
       // // can inheritance and implement it.
       // public abstract void PersonGenerator();
    }
}
