// 3 Methods for Mul
//3 methods for Sub
using System;

namespace CalculatorApp
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        } 

        public int Substract(int a, int b)
        { 
            return a -b ; 
        } 

        public double Substract(double a, double b)
        {
            return a - b;
        }  

        public int Substract(int a, int b, int c)
        {
            return a - b - c;
        } 

        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }   

        public int Multiply(int a, int b)
        {
            return a * b ;
        } 
        
        public double Multiply (double a, double b)
        {
            return a * b;
        }    



    }  


    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            int sum1 = calculator.Add(5, 10);
            double sum2 = calculator.Add(5.5, 10.5);
            int sum3 = calculator.Add(5, 10, 15);
           
            int Sub1 = calculator.Substract(10, 5); 
            
            double Sub2 = calculator.Substract(10.5, 5.5); 
            int Sub3 = calculator.Substract(10, 5, 2); 
            int Mul1 = calculator.Multiply(5, 10);
            int Mul2 = calculator.Multiply(5, 10, 2); 
            double Mul3 = calculator.Multiply(5.5, 10.5); 

            Console.WriteLine($"Sum of the numbers are as follows: {sum1}, {sum2}, {sum3}"); 
            Console.WriteLine($"Substraction of the numbers are as follows: {Sub1}, {Sub2}, {Sub3}"); 
            Console.WriteLine($"Multiplication of the numbers are as follows: {Mul1}, {Mul2}, {Mul3}"); 
        }
    }
}
