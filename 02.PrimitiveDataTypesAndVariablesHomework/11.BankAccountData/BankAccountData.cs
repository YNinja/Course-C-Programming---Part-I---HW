/* Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), 
available amount of money (balance), bank name, IBAN, 3 credit card numbers 
associated with the account.
Declare the variables needed to keep the information for a single bank account 
using the appropriate data types and descriptive names. */

using System;
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Angel";
            string middleName = "Angelov";
            string lastName = "Angelov";
            uint balance = 1000000;
            string bankName = "Mega Bank";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            ulong creditCard1 = 378282246310005;
            ulong creditCard2 = 371449635398431;
            ulong creditCard3 = 378734493671000;
            Console.WriteLine("Holder name: {0}", firstName + " " + middleName + " " + lastName);
            Console.WriteLine("Available amount of money: {0}", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("First credit card number, associated with the bank account: {0}", creditCard1);
            Console.WriteLine("Second credit card number, associated with the bank account: {0}", creditCard2);
            Console.WriteLine("Third credit card number, associated with the bank account: {0}", creditCard3);
        }
    }