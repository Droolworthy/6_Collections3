//В массивах вы выполняли задание "Динамический массив"
//Используя всё изученное, напишите улучшенную версию динамического массива(не обязательно брать своё старое решение)
//Задание нужно, чтобы вы освоились с List и прощупали его преимущество..
//Проверка на ввод числа обязательна.
//Пользователь вводит числа, и программа их запоминает.
//Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
//Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
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
                    TryAddNumber(numbers, userInput);
                }
            }
        }

        static void TryAddNumber(List<int>numbers, string userInput)
        {
            bool isSuccess = int.TryParse(userInput, out int amountNumbers);

            if (isSuccess)
            {
                numbers.Add(amountNumbers);
                Console.WriteLine("Число " + amountNumbers + " добавлено");
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
