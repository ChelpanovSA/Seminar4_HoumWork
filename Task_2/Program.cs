// *Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12/*

void Dellet(string[] args)
{
        Console.WriteLine("Введите число");
    int numA = int.Parse(Console.ReadLine()!);
    int result = 0;
    int number = 0;
        {
        int numB = numA;
        while (numB > 0)
        {
            number = numB % 10;
            result = result + number;
            numB = numB / 10;
        }
    }
    Console.WriteLine($"Сумма цифр {numA} равна {result}");
}

Dellet(args);