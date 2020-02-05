using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference
        public UnitTestMethods()
        {

        }

        // Create an Add method that passes 3 integers
        public int Addition(int x, int y, int z)
        {
            return x + y + z;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiplication(int p, int q)
        {
            return p * q;
        }

        // Create a Divide method that passes 2 integers
        public double Division(int i, int j)
        {
            return i / j;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote

        
    }
}
