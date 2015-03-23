﻿/* Problem 10. Employee Data

A marketing company wants to keep record of its employees. 
Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single 
employee using appropriate primitive data types. Use descriptive 
names. Print the data at the console. */

using System;
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Angel";
            string lastName = "Angelov";
            byte age = 25;
            char gender = 'm';
            ulong idNumber = 8306112507;
            uint employeeNumber = 27560001;
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID Number: {0}", idNumber);
            Console.WriteLine("Unique Employee Number: {0}", employeeNumber);
        }
    }