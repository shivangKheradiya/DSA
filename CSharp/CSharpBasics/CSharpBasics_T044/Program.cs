using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers for division:");
            string[] strInts = Console.ReadLine().Split(' ');

            int numerator, denominator;
            if (Int32.TryParse(strInts[0], out numerator )  && Int32.TryParse(strInts[1], out denominator) && denominator !=0) 
            {
                int result = numerator / denominator;
                Console.WriteLine($"Result : {result}");
            }
            else
            {
                Console.WriteLine("Result Can't obtain: conversion problem");
            }
        }
    }
}
