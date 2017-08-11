using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Csharp
{
    public class ConstructorBasics
    {
        //Instance Constructors:
        //Constructors run initialization code on a class or struct. 

        /*Instance constructors allow the following modifiers:
          Access modifiers: public, internal, private, protected 
          Unmanaged code modifiers: unsafe, extern */

        //Field initializations occur before the constructor is executed and in the declaration order of the fields.

        public class Panda
        {
            //Field
            string name;

            //Constructor
            public Panda(string n)
            {
                name = n;
                // Initialization code (set up field) 
            }

        }

        public class Animals
        {
            Panda p = new Panda("Petey");  // Call constructor
        }

        //Overloading constructors
        /*A class or struct may overload constructors. 
        To avoid code duplication, one constructor may call another, using the this keyword:*/

        public class Wine
        {
            public decimal Price;
            public int Year;
            public Wine (decimal price) { Price = price; }
            public Wine (decimal price, int year): this(price) { Year = year; }
            //When one constructor calls another, the called constructor executes first.
            public Wine (decimal price, DateTime year): this(price, year.Year) { }

            //Implicit parameterless constructors:
            /*For classes, the C# compiler automatically generates a parameterless public constructor 
            if and only if you do not define any constructors. However, as soon as you define at
            least one constructor, the parameterless constructor is no longer automatically generated.*/

            //Nonpublic constructors:
            /*Constructors do not need to be public. A common reason to have a nonpublic 
            constructor is to control instance creation via a static method call.*/
            Wine() { } // Private constructor 
            public static Wine Create
            {
                // Perform custom logic here to return an instance of Class1 
            }
        }


        //Object Initializers: 
        //any accessible fields or properties of an object can be set via an object initializer directly after construction
        public class Bunny
        {
            public string Name;
            public bool LikesCarrots;
            public bool LikesHumans;

            public Bunny() { }
            public Bunny(string n)
            {
                Name = n;
            }
        }

        //Using object initializers, you can instantiate Bunny objects as follows:
        public class Jungle
        {
            private void MyBunnies()
            {
                Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
                Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };

                Bunny b3 = new Bunny();
                b3.Name = "Mo";
                b3.LikesCarrots = true;
                b3.LikesHumans = true;

                //OR:

                Bunny b4 = new Bunny("Bo");
                b4.LikesCarrots = true;
                b4.LikesHumans = true;     
            }

        }

    }
}