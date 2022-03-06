// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.

using System;
class Program  {

   static void Main()

    {
        
        void Revers(int currentNumber)
        {
            int a = currentNumber / 100;
            int b = currentNumber % 100 / 10;
            int c = currentNumber % 100 % 10;
            Console.WriteLine(c * 100 + b * 10 + a);
        }
    
        Console.Write("Введите 3-х значное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Revers(number);
    
    
    }
    

}

