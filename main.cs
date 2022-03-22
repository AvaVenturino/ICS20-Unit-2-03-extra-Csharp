// Created by: Mr Coxall
// Created on: Sep 2020
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int streetNumber;
        string streetName;

        Console.WriteLine("This program puts together a user's address.");
        Console.WriteLine("");
        Console.Write("Enter your Street Number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Street Name: ");
        streetName = Console.ReadLine();


        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber + " " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}