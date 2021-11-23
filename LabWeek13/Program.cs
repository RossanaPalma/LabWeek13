/// Chapter No. 25 - Lab_Week13
/// File Name: LabWeek13.java
/// @author: Rossana Palma
/// Date:  November 21, 2021
///
/// Problem Statement: Create a test programs that uses optional parameters, 
/// named parameter and variable number of parameters.

using System;

namespace LabWeek13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Optional parameters
            Student("Mark", "Aloka", 37, "Computer Science");
            Student("John", "Josh");
            Student("Adam", "David", 30);


            //Named parameters
            Console.WriteLine(addNumbers(12, 13));
            Console.WriteLine(addNumbers(firstNumber: 12, secondNumber: 13));
            Console.WriteLine(addNumbers(secondNumber: 13, firstNumber: 12));
            Console.WriteLine(addNumbers(12, secondNumber: 13));

            //Variable of parameters
            Console.WriteLine(mulNumber(5, 6, 7, 8, 100));

            //Dynamic parameters
            mulVal(30.5);
            mulVal("Hello");
            Program p = new Program();
            mulVal(p);


            Console.ReadLine();

        }
        public static void Student(string fname, string lname, int age = 20, string major = "Information System")
        {
            Console.WriteLine("First Name: " + fname);
            Console.WriteLine("Last Name: " + lname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Major: " + major);


        }
        public static int addNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int mulNumber(params int[] num)
        {
            int result = 1;
            foreach (int j in num)
            {
                result *= j;
            }
            return result;
        }
        public static void mulVal(dynamic value)
        {
            // value *= value;
            Console.WriteLine(value);
        }
    }
}


   