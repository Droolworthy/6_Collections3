using System;
using System.Collections.Generic;

namespace CS23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new();
            bool isExitApp = true;
            string userInput;
            string stopProgram = "exit";
            string summation = "sum";

            while (isExitApp)
            {
                Console.WriteLine($"Сложить числа введите - {summation}");
                Console.WriteLine($"Выйти из программы введите - {stopProgram}"); 
                Console.Write("Ввести число: ");
                userInput = Console.ReadLine();

                if (userInput == summation)
                {
                    ShowSum(numbers);
                }
                else if (userInput == stopProgram)
                {
                    isExitApp = false;
                }
                else
                {
                    AddNumber(numbers, userInput);
                }
            }
        }
        static void AddNumber(List<int>numbers, string userInput)
        {
            bool isSuccess = int.TryParse(userInput, out int amount);

            if (isSuccess)
            {
                numbers.Add(amount);
                Console.WriteLine("Число " + amount + " добавлено");
            }
            else
            {
                Console.WriteLine("Ошибка, попробуйте ещё раз.");
            }
        }
        static void ShowSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Cумма: " + sum);
        }
    }
}
