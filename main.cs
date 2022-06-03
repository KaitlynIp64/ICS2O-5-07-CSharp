// Created by: Kaitlyn Ip
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {

        int num;
        var sum = 0;

        Console.Write("This program adds up all the numbers from 1 to the integer entered:\n");
        Console.Write("Input a positive integer: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (var counter = 1; counter <= num; counter++)
            sum += counter;

        Console.WriteLine("The answer is: " + sum);
    }
}