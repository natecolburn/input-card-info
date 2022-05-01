using System;
using System.Text.RegularExpressions;


// Author: Nathan Colburn
// date: 6/22/2019

//about:
// input card info



namespace Assignment_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare strings.
            string name, num;
            
            bool flag = false;
            
            Console.WriteLine("Enter Name on Card:");

            //while flag is false,
            
            do
            {
                
                name = Console.ReadLine();
                
                Match match = Regex.Match(name, @"\b[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}\b", RegexOptions.IgnoreCase);
               
                flag = match.Success;
                
                if (!flag)
                    Console.WriteLine("Invalid Entry \nIn Enter Name on Card: ");
            } while (!flag);

               
                flag = false;
            //ask the user to enter the  card number
            Console.WriteLine("\nEnter Credit Card Number:");
            
            while (!flag)
            {
                
                num = Console.ReadLine();
                
                Match match = Regex.Match(num, @"^[0-9]{12,19}$", RegexOptions.IgnoreCase);
                
                flag = match.Success;
                
                if (!flag)
                    Console.WriteLine("Invalid Entry \nEnter Credit Card Number: ");
            }

            //print "Thank you" message
            Console.WriteLine("\nThank you for your Order.");

            Console.ReadKey();
        }
    }
}
