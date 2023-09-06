using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Distance
    {
        private int _feet, _inch; // property 
        public int Feet  // Feet is a property unit which is dealing with _feet
        {
            get
            {
                return _feet;
            }
            set
            {
                _feet = value;
            }
        }
        public int Inch
        {
            get
            {
                return _inch;
            }
            set
            {
                _inch = value;
            }
        }
        public Distance() // default constructor
        {
            Console.WriteLine("Default Constructor Called");
            _feet = 1;
            _inch = 1;
        }
        public Distance(int feet,int inch)
        {
            Console.WriteLine("Parameterized Constructor Called");
            this._feet = feet; // this is representative of current object inside the class.
            _inch = inch;
        }
        public Distance(Distance distance)
        {
            Console.WriteLine("Copy Constructor Called");
            _feet =distance._feet;
            _inch = distance._inch;  
        }
    }
   
}
//MSIL CODE
// Assembly  - Pyhsical file of MSIL Code (.exe, .dll)
// DLL - Dynamic Link Library

/*
Class - collection of information about an object . it gives theoratical description about an object
Object - real life representative of class
Encapsulation - a process to wrap the information about an object which you want to create - 
    Properties - how an object look like
    Functions - how an object work
    Events - what kind of action an object can take
    Event Handler - when we associate an event with a function that function is known as event handler
Note -  during encapsulation we will also decide which one member of the class should be public or private 
        and to make a member private is known as Data Hiding

Abstraction - Represent the complixty in very simple manner 

Inheritance - Acquire the members of existing class into new class

Polymorphism - multiple forms


1.  It is a special function which has same name as of the class name. It is automatically called during object
    creation of a class.

Primary Job - It Allocates memory for an object of a class

Features - 

2. It always be public
3. It does not return not even void
4. It always execute once for an object of a class
5. It is used to initialize an object of a class - set default values to class's properties
6. Its primary job is to allocate memory for an object of a class.

7. It has 3 types
   7.1 default constructor - does not accept arguments 
        Syntax - 
         public classname()
                {
                }
   7.2 parameterized constructor - accept arguments 
        syntax:
            public classname(dt var,dt var,....)
                {
                    ....
                }
   7.3 copy constructor  - accept argument of itself class as reference
            public classname(classname refname)
                {
                        ...
                }
if more than one constructor defined inside a class then it is called constructor overloading.

Data Binding: Connection of a function call with its body.


*/