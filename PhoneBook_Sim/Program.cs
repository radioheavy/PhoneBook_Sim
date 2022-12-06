using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> phoneNumbers = new List<string>();

        while (true)
        {
            Console.Write("Enter a phone number (or 'q' to quit): ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            phoneNumbers.Add(input);
        }

        File.WriteAllLines("phone_numbers.txt", phoneNumbers.ToArray());

        string[] lines = File.ReadAllLines("phone_numbers.txt");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}