using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning31inkapsling
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var flamingo = new Flamingo("TETE", 222, 23, 3.3, 333);
            var nr = flamingo.NumberOfLongFeather;
            // 3.1 --- 1 
            Person person = new Person();   // Instantiate a Person type variable using default constructor
            //Now, with the get-set, we can directly access the private members variable of the class
            person.Age = 19;
            person.FName = "Johan";
            person.Height = 182.5;
            person.Weight = 78.3;

            // User the PersonHandler class to create a person
            PersonHandler personHandlar = new PersonHandler();
            Person aPerson = personHandlar.CreatePerson(18, "Johan", "Dawed", 180, 200);

            // Create a Animal type list
            List<Animal> animalsList = new List<Animal>();

            //// Test, Try to declare and initilize an object list at the same time
            //List<String> aList = new List<String>(new string[2]);
            // var
            //List<Animal> animalsList2 = new List<Animal>()
            //{
            //    new Dog(),
            //    new Horse(),
            //    new Bird(),
            //};   

            Horse aHorse;                          // creat a horse and put onto the list
            aHorse = new Horse("Hors Name..", 22, 22, "GREE");
            aHorse.Type = AnimalType.Horse;        // Parameterized constructor did not implement this, we set it here
            //add to list
            animalsList.Add(aHorse);
            
            aHorse = new Horse();                  // Create a obj with the defualt constructor
            aHorse.Name = "Tee Horse";
            aHorse.Age = 12;
            aHorse.GrassItLike = "Saspa";
            aHorse.Weight = 134;
            aHorse.Type = AnimalType.Horse;
            // Add to list
            animalsList.Add(aHorse);

            Swan aSwan;
            aSwan = new Swan("SwanName", 232, 3, 3.3, DateTime.Now);   // Create a swan instance and add to list
            aSwan.Type = AnimalType.Bird;           // Parameterized constructor did not implement this one, set it here
            animalsList.Add(aSwan);

            // Create a obj with default constructor
            aSwan = new Swan();
            aSwan.Name = "a Swan..";
            aSwan.WingSpan = 11;
            aSwan.Age = 4;
            aSwan.Type = AnimalType.Bird;
            aSwan.Weight = 11;
            aSwan.WhenImigranteToSouth = DateTime.Now;
            // Add onto list
            animalsList.Add(aSwan);

            // create 2 dog object and add to list
            Dog aDog;
            aDog = new Dog("YES", "YES", "Dog Name..", 22, 4);
            aDog.Type = AnimalType.Dog;               // Parameterized constructor did not implement this one, set it here
            animalsList.Add(aDog);

            aDog = new Dog();
            aDog.AttakPeople = "yes";
            aDog.Age = 3;
            aDog.Name = "Dog ...";
            aDog.Weight = 123;
            aDog.LikeToBark = "yes";
            aDog.Type = AnimalType.Dog;
            aDog.testString = "*****************************";
            animalsList.Add(aDog);

            // create another one
            Dog sDog = new Dog("yes", "yes", "Dog-3 ..", 22, 22);
            sDog.Type = AnimalType.Dog;               // Parameterized constructor did not implement this one, set it here
            animalsList.Add(sDog);

            // Create an obj with the default constructor and add to list
            sDog = new Dog();
            sDog.AttakPeople = "yes";
            sDog.Age = 2;
            sDog.AttakPeople = "no";
            sDog.Name = "Dog-4...";
            sDog.Weight = 111;
            sDog.Type = AnimalType.Dog;
            animalsList.Add(sDog);

            animalsList.Add(sDog);   // add two times onto the list

            // Display the animal on the list. Here is another characteristice of the constructor!
            // If there is a member variable not in the argument list(Not implemented by the parameterized constructor, 
            // C# will initilized it to 0, when using, so becareful with the a field that is used to differentiate object
            // type on a mixed object list !!!!
            // With the deault constructor, all the member variables
            // are initialized as 0. 
            foreach (Animal anml in animalsList)
            {
                Console.WriteLine("\n" + "-------> This is a " + anml.Type + ", Type = " + (int)anml.Type);
                Console.WriteLine("Name: " + anml.Name);
                Console.WriteLine("Age: " + anml.Age);
                Console.WriteLine("Weight: " + "eight: " + anml.Weight);
            };

            // Create a list of Dog list. Here we can see that the Animal type can be used as an interface type
            // but it can not be casted into a concrete type derived from it if it is not.
            List<Dog> dogList = new List<Dog>();
            dogList.Add(aDog);
            dogList.Add(sDog);
            foreach (Animal dog in dogList)
            {
                Dog castDog = (Dog)dog;
                Console.WriteLine(castDog.DogString());

            }

            // 3.3 Polymorephism  6, 7, 8 
            // Can not add a horse onto a dog list, because they are different type classes with different properties.
            // Horse horse = new Horse();
            // dogList.Add(horse);         

            // Only the TOP base class Animal-type-list can store all the animals classes derived from it .

            //3.3  9. call each animal's Stats() function using foreach.... and write to console
            Console.WriteLine("Use foreach to call each animal's Stats function to print out its attributes" );
            foreach (Animal animal in animalsList)
            {
                Console.WriteLine(animal.Stats());
            }
            //Console.ReadKey();

            //3.3  11  the foreach pickout each animal object on the list and call that object's Stats() function.
            // the Stats() function return the strributes in a string format. The Console.WriteLine() display it.

            // 3.3 - 12 use the foreach() to call all the dog's Stats() functions -------------------------
            foreach (Animal animal in animalsList)
            {
                if (animal.Type == AnimalType.Dog) // Add and use an enum type "Type" variable to distinguish the different animals 
                {
                    Dog isDog = (Dog)animal;      // Now, we can Cast animal to Dog type
                    Console.WriteLine(isDog.DogString());
                    Console.WriteLine("Dog stats() return: " + isDog.Stats());
                }

                // Dog isDog = animal as Dog;        // Safe casting .....
                // if(isDog != null )
                //{
                //   isDog.StatusReport();
                //}

                //if(animal is Dog isDog)
                //{
                //    isDog.Status.Report();
                //}

                //Console.WriteLine("+++++++++++ Before ++++++++++++++++");

                if (animal is Dog)             // use the "is" to pick out dogs
                {
                    Dog isDog = (Dog)animal;                 
                    Console.WriteLine("+++++++++++ if animal is Dog == true +++++++++++++++ This one is a dog");
                    Console.WriteLine("Dog stats() is called, it return: " + isDog.Stats());
                }
             
                Console.ReadKey();
            }                 

            // 3.4 --- 11 Varför är polymofism viktigt att behärska?
            // 3.4 --- 12 Hour kan polymorfism förändra och förbättra kod via bra struktur?
            // Polymorphism make program easier to change and add new functionalities when requirment changes.
            // Polymorphism make code re-use so that dumplex codes can be avoided.
            // Polymorphism provide an unified interface for client code to interact with a software module, this
            // make the software more structured and easier to maintain, add new functionalities and change the 
            // existing functionalities.

            // 3.4  --- 13 Vad är det för en skillnad på en Abstrakt klass och ett Interface?
            // Interface defines only the signatures of methods, events, and properts, a class type can inherit and implement multiple interface.
            // Abstract class can has abstract members, virtual members. A class can inheritance and implement only one abstract class.

            //// Test
            //Hedgehog hhog = new Hedgehog("TEST NAME", 222, 222, 222);
            //Console.WriteLine("Hedgehog: " + hhog.Name + hhog.Weight, + hhog.Age + hhog.NumberOfSpikes);
            //Swan swan = new Swan("TTT", 222, 222, 32.3, DateTime.Now);
            //Console.WriteLine("Swan: " + swan.Name + swan.Age + swan.Weight + swan.WingSpan);
        }
    }
}
