// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;

class Program
{
    static void Main(string[] args)

    {

        void FindThirdDigit(string currentNumber)
        {
            if (currentNumber.Length > 2)
            {
                Console.WriteLine(currentNumber[2]);
            }
            else Console.WriteLine("Третьей цифры нет");

        }
        Console.Write("Введите число: ");
        string number = Console.ReadLine();
        FindThirdDigit(number);

    }


}

