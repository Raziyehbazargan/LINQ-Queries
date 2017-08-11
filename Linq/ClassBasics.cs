using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Csharp
{
    /* A class is the most common kind of reference type.
    The simplest possible class declaration is as follows:
    Preceding the keyword class Attributes and class modifiers. 
    The non-nested class modifiers are :
        public, 
        internal, 
        abstract, 
        sealed, 
        static, 
        unsafe, and partial
        Following YourClassName Generic type parameters, a base class, 
        and interfaces Within the braces Class members(these are methods, properties, indexers, events, fields, constructors, overloaded operators, nested types, and a finalizer)*/
    public class ClassBasics
    {
        //Field: is a variable that is a member of a class or struct

        /*Fields allow the following modifiers:
        Static modifier :static 
        Access modifiers: public, internal, private ,protected 
        Inheritance modifier: new 
        Unsafe code modifier: unsafe 
        Read-only modifier: readonly 
        Threading modifier: volatile*/

        string name;  //An uninitialized field has a default value(0, \0, null, false).
        public int age = 10;

        //A method performs an action in a series of statements

        /*Methods allow the following modifiers:
         Static modifier :static 
         Access modifiers: public, internal, private ,protected 
         Inheritance modifier: new, virtual, abstract, override, sealed 
         Partial method modifier: partial 
         Unmanaged code modifiers: unsafe, extern
         Asynchronous code modifier: asyne*/

        int Foo(int x)  
        {
            return x * 2;
        }

        int MultipleByTwo(int x) => x * 2;
        void SumTwoNum(int x, int y) => Console.WriteLine("{x} + {y} = { x + y }");

        //OverLoading methods:
        //A type may overload methods(have multiple methods with the same name), as long as the signatures are different.
        //the return type and the params modifier are not part of a method’s signature
        void Moo (int x) => Console.Write(x);
        void Moo (double x) => Console.Write(x * 4);
        void Moo (int x, float y) => Console.Write(x - y);
        void Moo (float x, int y) => Console.Write(x + y);

        //Pass-by-Value versus pass-by-reference: 
            //Whether a parameter is pass-by-value or pass-by-reference is also part of the signature.

        /*ref tells the compiler that the object is initialized before entering the function, 
         while out tells the compiler that the object will be initialized inside the function.
         So while ref is two-ways, out is out-only.*/

        void Too(int x) { }
        void Too(ref int x) { }
        // void Too(out int x) { x = 5; } //Compile-error
    }
}