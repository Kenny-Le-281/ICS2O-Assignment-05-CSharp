// Created by: Kenny Le
// Created on: May 2022
//
// This program calculates the value of π

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the value of π
        const int NUMERATOR = 4;
        int userInput;
        int counter = 0;
        double answer = 0;
        double denominator = 1;

        // input
        Console.WriteLine("This program calculates the value of π");

        Console.WriteLine("");
        Console.Write("Please input a positive whole number: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        // process
        if (userInput < 0)
        {
            Console.Clear();
            Console.WriteLine("Input a positive whole number.");
        }
        else
        {
            while (counter < userInput)
            {
                if (counter % 2 == 0)
                {
                    denominator = counter * 2 + 1;
                    answer += NUMERATOR / denominator;
                }
                else
                {
                    denominator = counter * 2 + 1;
                    answer += -(NUMERATOR / denominator);
                }
                
                counter++;
            }
             // output
            Console.WriteLine("");
            Console.WriteLine("The value of π is " + answer);
        }

        Console.WriteLine("\nDone.");
    }
}