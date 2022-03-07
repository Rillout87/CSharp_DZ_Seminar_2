// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using System;

class Program
{
    static void Main(string[] args)

    {

        void IsWeekend(int Daynmb)
        {
            if ((Daynmb == 6) | (Daynmb == 7))
            {
                Console.WriteLine("Это выходной");
            }
            else if ((Daynmb <= 5) & (Daynmb >= 1))
            {
                Console.WriteLine("Это рабочий день");
            }
            else Console.WriteLine("Такого дня недели не существует");

        }
        Console.Write("Введите номер дня недели: ");
        int DayNumber = Convert.ToInt32(Console.ReadLine());
        IsWeekend(DayNumber);

    }


}
