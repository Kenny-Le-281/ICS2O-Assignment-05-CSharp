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
        float answer = 0;
        float denominator = 1;

        // input
        Console.WriteLine("This program calculates the value of π");
        Console.WriteLine("Please input a positive whole number");

        Console.WriteLine("");
        Console.Write("Input the whole positive number: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        // process
        if (userInput < 0)
        {
            Console.WriteLine("Please input a positive whole number!");
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
            Console.WriteLine("The value of π is " + answer.ToString("0.000000"));
        }

        Console.WriteLine("\nDone.");
    }
}