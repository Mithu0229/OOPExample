using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Static
{
    /*
     -----------------------------------------Static----------------------
    Static methods belong to a class as a whole not to a specific instance.
    Static method can not use the instance data (value of the field or return data by properties)
    A static class can not be instantiated it only works as a container for method.
    Static classs can only contain static method.
    non static classes can contain static methods.
    if a private method does not use instanc data make its static.
    all const variable are static
 */
    public static class Calculator
    {
        public static int Add(int a, int b) => a+ b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public const int numberOfVallue = 4;
    }
}
