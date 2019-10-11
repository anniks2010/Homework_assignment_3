using System;

namespace Homework_assignment_3
{
    class Program
    {
        static void Main(string[] args)


        {
            Start:
            Console.WriteLine("What is the temperature out side?");
            float userNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Is it in Fahrenheit (F) or Celsius (°C) scale?");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer== "fahrenheit")
            {
                Console.WriteLine("Would you like to convert it to Celsius scale, Y/N?");
                string userchoise = Console.ReadLine().ToUpper();
                if(userchoise== "Y")
                {
                    float celsiusCalculations = (float)(Math.Round((double)((userNumber - 32) * 5 / 9),2));
                    Console.WriteLine($"({userNumber} - 32) x 5 / 9 = {celsiusCalculations} °C");
                }
                else
                {
                    Console.WriteLine("Thank You!");
                }
            }
            else
            {
                Console.WriteLine("Would you like to convert it to Fahrenheit scale, Y/N?");
                string userChoise2 = Console.ReadLine().ToUpper();
                if (userChoise2 == "Y")
                {
                    float fahrenheitCalculations = (float)(Math.Round((double)((userNumber * 9) / 5 + 32),2));
                    Console.WriteLine($"({userNumber} x 9) / 5 + 32 = {fahrenheitCalculations} F");
                }
                else
                {
                    Console.WriteLine("Thank you!");
                }
            }

            goto Start;




            Console.ReadLine();
        }
    }
}
