using System;
using System.Collections.Generic;

namespace CS23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            list<int> numbers = new();
            bool canExitApp = true;
            string userInput;
            string stopProgram = "exit";
            string summation = "sum";

            while (canExitApp)
            {
                Console.WriteLine($"Сложить числа введите - {summation}");
                Console.WriteLine($"Выйти из программы введите - {stopProgram}"); 
                Console.Write("Ввести число: ");
                userInput = Console.ReadLine();

                if (userInput == summation)
                {
                    int value = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        value += numbers[i];
                    }

                    Console.WriteLine("Cумма: " + value);
                }
                else if (userInput == stopProgram)
                {
                    canExitApp = false;
                }
                else
                {
                    int amount;
                    bool isResultReadInt = int.TryParse(userInput, out amount);

                    if (isResultReadInt)
                    {
                        numbers.Add(amount);
                        Console.WriteLine("Число " + amount + " добавлено");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, попробуйте ещё раз.");
                    }
                }
            }
        }
    }
}
