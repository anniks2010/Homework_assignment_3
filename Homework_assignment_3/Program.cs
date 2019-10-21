using System;

namespace Homework_assignment_3
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("What is the temperature out side?");
            float userNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Is it in Fahrenheit (F) or Celsius (°C) scale?");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == "fahrenheit" || userAnswer == "f")
            {
                Console.WriteLine("Would you like to convert it to Celsius scale, Y/N?");
                string userchoise = Console.ReadLine().ToUpper();
                if (userchoise == "Y")
                {
                    GetCelsius(userNumber);

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
                    GetFahrenheit(userNumber);

                }
                else
                {
                    Console.WriteLine("Thank you!");
                }
            }


            Console.ReadLine();
        }
        public static void GetFahrenheit(float celsiusTemperature)
        {
            float fahrenheitCalculations = (float)(Math.Round((double)((celsiusTemperature * 9) / 5 + 32), 2));
            Console.WriteLine($"Temperature is {fahrenheitCalculations} F.");
        }
        public static void GetCelsius(float fahrenheitTemperature)
        {
            float celsiusCalculations = (float)(Math.Round((double)((fahrenheitTemperature - 32) * 5 / 9), 2));
            Console.WriteLine($"Temperature is {celsiusCalculations} °C.");
        }


    }
}
