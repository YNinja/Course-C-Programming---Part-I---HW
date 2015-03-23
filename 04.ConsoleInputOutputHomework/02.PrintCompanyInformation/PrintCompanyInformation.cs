/* Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager 
and prints it back on the console.

Example input:
program 	user
Company name: 	Telerik Academy
Company address: 	31 Al. Malinov, Sofia
Phone number: 	+359 888 55 55 555
Fax number: 	
Web site: 	http://telerikacademy.com/
Manager first name: 	Nikolay
Manager last name: 	Kostov
Manager age: 	25
Manager phone: 	+359 2 981 981

Example output:

Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  
*/

using System;
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name: ");
            string companyName = Console.ReadLine();

            Console.WriteLine("Company address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Phone number: ");
            string companyNumber = Console.ReadLine();

            Console.WriteLine("Fax number: ");
            string faxNumber = Console.ReadLine();

            Console.WriteLine("Web site: ");
            string webSite = Console.ReadLine();

            Console.WriteLine("Manager first name: ");
            string managerFName = Console.ReadLine();

            Console.WriteLine("Manager last name: ");
            string managerLName = Console.ReadLine();

            Console.WriteLine("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.WriteLine("Manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Tel. " + companyNumber);
            Console.WriteLine("Fax number: {0} ", faxNumber.Length >= 11 ? faxNumber : "(no fax)");
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}) ", managerFName, managerLName,
                managerAge, managerPhone);

        }
    }