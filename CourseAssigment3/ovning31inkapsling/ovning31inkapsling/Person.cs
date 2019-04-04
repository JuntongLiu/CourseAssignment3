using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning31inkapsling
{
    class Person
    {
        // private member variables of the class
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // Default constructor
        public Person()
        { }
        // Parameterized constructor
        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
        }

        // Make the private variables a property, so that we can "directly" access the variables
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }                // make the age a property
        }

        public string FName                         // make the fname a property
        {
            get { return fName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    fName = value;
                }
            }
        }

        public string LName                         // make the lname a property
        {
            get { return lName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    lName = value;
                }
            }
        }

        public double Height                        // make the Height a property
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Weight                        // make the weight a property
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
