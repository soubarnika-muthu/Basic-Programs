﻿using System;

namespace BasicCorePrograms
{
    // 1.Flip coin program
    // 2.Leap Year Program
    // 3.Power Of Two Program
    // 4.Harmonic Number Program
    // 5.Prime Factors program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of basic programs");
            Console.WriteLine("Enter choice to select programs: ");
            Console.WriteLine("1.Flip Coin 2.Leap Year 3. Power Of Two 4.Harmonic Number 5.Prime Factors");
            int choice = Convert.ToInt32(Console.ReadLine());
            //Selection statement
            switch (choice)
            {
                case 1:
                    //Computing Flip Coin Program
                    Console.WriteLine("Flip Coin Program!");
                    FlipCoin.ReadInput();
                    break;
                case 2:
                    //Computing Leap Year Program
                    Console.WriteLine("Finding Leap Year Or Not!");
                    LeapYear.ReadInput();
                    break;
                case 3:
                    //Computing Power Of Two Program
                    Console.WriteLine("Finding Power Of Two");
                    PowerOfTwo.ReadInput();
                    break;
                case 4:
                    //Computing Harmonic Number Program
                    Console.WriteLine("Finding Nth Harmonic Number");
                    HarmonicNumber.ReadInput();
                    break;
                case 5:
                    //Computing Prime Factor Program
                    Console.WriteLine("Finding Prime Factors");
                    PrimeFactors.ReadInput();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice!!!");
                    break;
            }

        }
    }
}

