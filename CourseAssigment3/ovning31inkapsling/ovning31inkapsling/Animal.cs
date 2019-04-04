using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ovning31inkapsling
{
    // Define an Enum type for animal types
    public enum AnimalType : int
    {
        Horse,
        Dog,
        Bird,
        Hedgehog,
        Worm
    }

    class Animal                  // ----------------------------------------------- Animal -----------------------------
    {
        // private variables,  set access level as low as possible. private if possible.
        private string name;
        private int weight;
        private int age;
        
        public AnimalType Type { get; set; }     // animal type

        //make theim property
        public string Name
        {
            get { return name; }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public int Weight    // make it a property
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

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }


        // Constructor: 
        // The conclusion is: in C#, once a parameterized constructor is implemented, it 
        // will have previlige over the default constructor. This means that even one explicitly call the
        // default constructor, the C# will run the implemented parameterized constructor, and the consequence
        // is that there will be error due to no arguments are provide to the parameterized constructor.
        // If one still need to call the defualt constructor, one must explicitly implement it in the program like following.
        // If all the derived classes's default constructors need to called, they need to be implemented in the program as well. 
        // This is a surprise !

        // Default constractor, create an obj and set all variable 0, 0.0 or null.
        public Animal() { }

        // Parameterized constructor
        public Animal(string animalName, int weight, int age)
        {
            Name = animalName;
            Weight = weight;
            Age = age;
        }


        // Stats() function in Aminal class to return a string which contain all the attributes of Animal class
        // and it is overritable by derived classes.
        public virtual string Stats()
        {
           // string s = "name: " + name + " weight: " + weight + "age: " + age;    return s;
            return $"name: {name}, weitht: {weight}, age: {age}"; 
        }

    }

    // Class horse derived from Animal
    class Horse : Animal
    {
        private string grassItLike;  // What grass the horse like to eat
        public string GrassItLike
        {
            get {
                return grassItLike;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    grassItLike = value;
                }
            }
        }

        // override the base class horse's Stats() function
        public override string Stats()
        {
            return base.Stats() + $", grassItLike : {grassItLike}";
        }

        // Default constructor
        public Horse() : base()
        { }

        // Constructor
        public Horse(string name, int weight, int age, string grass) : base(name, weight, age)
        {
            grassItLike = grass; // GrassItLike
        }
    }

    // Class Dog derived from Animal
    class Dog : Animal
    {
        private string attakPeople;
        private string likeToBark;

        public string testString { get; set; }

      //  public string AttachPeople    // yes, no, boolan is ok but 
        public string AttakPeople
        {
            get
            {
                return attakPeople;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    attakPeople = value;
                }
            }
        }

        public string LikeToBark
        {
            get
            {
                return likeToBark;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    likeToBark = value;
                }
            }
        }

        // Constructor
        // Default constructor. 
        public Dog() : base(){ }

        // Parameterized constructor
        public Dog(string attak, string likeBark, string name, int weight, int age) : base(name, weight, age)
        {
          
            AttakPeople = attak;
            LikeToBark = likeBark;
        }

        // override the base class horse's Stats() function
        public override string Stats()
        {
            return base.Stats() + $", {attakPeople}";
        }

        // 3.3  --  13 add a valfri function
        public string DogString()
        {
            return "0===>Function in Dog Class: Dog obj return a valfri string, dog, dog, dog";
        }

    }

    // Class Hedgehog inheritance Animal
    class Hedgehog : Animal
    {
        private int numberOfSpikes;

        // Default constructor
        public Hedgehog() : base()
        { }

        // Parameterized constructor
        public Hedgehog(string name, int weight, int age, int numSpiks) : base(name, weight, age)
        {
            NumberOfSpikes = numSpiks;
        }

        public int NumberOfSpikes
        {
            get
            {
                return numberOfSpikes;
            }
            set
            {
                numberOfSpikes = value;
            }
        }

        // override the base class horse's Stats() function
        public override string Stats()
        {
            return base.Stats() + $", {numberOfSpikes}";
        }
    }

    // class Worm derived from Animal
    class Worm : Animal
    {
        private bool posionous;
        public bool Posionous    // make it a property
        {
            set
            {
                posionous = value;
            }
            get
            {
                return posionous;
            }
        }

        // Default constructor
        public Worm() : base()
        { }

        // Parameterized Constructor 
        public Worm(string name, int weight, int age, bool posionous) : base(name, weight, age)
        {
            Posionous = posionous;
        }
     
        // override the base class horse's Stats() function
        public override string Stats()
        {
            return base.Stats() + $", {posionous}";
        }
    }

    // Class bird derived from animal
    class Bird : Animal
    {
        private double wingSpan;
        public double WingSpan   // make it a property
        {
            get
            {
                return wingSpan;
            }
            set
            {
                wingSpan = value;
            }
        }

        // Default constructor
        public Bird() : base()
        { }

        // Parameterized constructor
        public Bird(string name, int weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        // override the base class horse's Stats() function
        public override string Stats()
        {
            return base.Stats() + $", {wingSpan}";
        }
    }

    //----------
    // Class Pelican inheritance Bird
    class Pelican : Bird
    {
        private double fishCauthDay;        // Fish the pelican can caught every day
        public double FishCauthDay
        {
            get
            {
                return fishCauthDay;
            }
            set
            {
                fishCauthDay = value;
            }
        }

        // Note here, in a multi-inheritance class, there is only one base() constructor
        // Default constructor
        public Pelican() : base()
        { }

        // Parameterized constructor
        public Pelican(string name, int weight, int age, double wingSpan, double fishCauthDay) : base(name, weight, age, wingSpan)
        {
          
            FishCauthDay = fishCauthDay;
        }

        // override base class's Stats() class
        public override string Stats()
        {
            return base.Stats() + $", {fishCauthDay}";
        }
    }

    // Class Flamingo derived from Bird
    class Flamingo : Bird
    {
        private int numberOfLongFeather;    // The date the bird will imigrate to south for winter
        public int NumberOfLongFeather      // make it a property
        {
            get
            {
                return numberOfLongFeather;
            }
            set
            {
                numberOfLongFeather = value;
            }
        }

        // Default constructor
        public Flamingo() : base()
        { }

        // Parameterized constructor
        public Flamingo(string name, int weight, int age, double wingSpan, double numOfLongFeather) : base(name, weight, age, wingSpan)
        {
           
            NumberOfLongFeather = numberOfLongFeather;
        }

        // override base class's Stats() class
        public override string Stats()
        {
            return base.Stats() + $", {NumberOfLongFeather}";
        }
    }

    // Class Flamingo derived from Bird
    class Swan : Bird
    {
        private DateTime whenImigranteToSouth;    // The date the bird will imigrate to south for winter
        public DateTime WhenImigranteToSouth      // make it a property
        {
            get
            {
                return whenImigranteToSouth;
            }
            set
            {
                whenImigranteToSouth = value;
            }
        }

        // Default constructor
        public Swan() : base()
        { }

        //Parameterized constructor
        public Swan(string name, int weight, int age, double wingSpan, DateTime whenImigranteToSouth) : base(name, weight, age, wingSpan)
        {
         
            WingSpan = wingSpan;
            WhenImigranteToSouth = whenImigranteToSouth;
        }

        // override base class's Stats() class
        public override string Stats()
        {
            return base.Stats() + $", {whenImigranteToSouth}";
        }
    }

    // Om samtliga fåglar behöver ett nytt attribut, vi ska lägga det i Bird class.

    // Om alla djur behöver det nya attributet, vi skulle lägga det i Animal class.

}
