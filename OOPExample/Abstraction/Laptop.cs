using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Abstraction
{
    /*
==============================Example of Abstraction==========================

------------------------------Abstraction----------------------------
Abstraction means that classes expose only essential data and method and hide the underlying detail.
For example car we can drive the car but we do not see the behinde or how does work engine

------------------------------Field----------------------------------
A field is a variable that belongs to an object of a class

------------------------------Constructor----------------------------
Constructor is a method used to instantiate object of a class. Constructor can only be called at the
moment of object creation.

------------------------------Data hiding----------------------------
Data hiding means makeing the members of a class non-public. Class members are anything that a class
contains field, method etc.

 */

    public class Laptop
    {
        private string brand;
        private string model;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
        public void LaptopKeyboard()
        {
            Console.WriteLine("Type using Keyword");
        }
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotheBoard Information");
        }
        private void InternalProcessor()
        {
            Console.WriteLine("Processor Information");
        }
    }
}
