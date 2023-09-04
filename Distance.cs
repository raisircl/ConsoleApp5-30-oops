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
 
*/