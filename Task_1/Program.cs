//*Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16.

int Extent(int A, int B)
{
    int result = 1;
    for (int count = 1; count <= B; count++)
    {
        result = result * A;
    }
    return result;
}
int ReadConsole(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

Console.Clear();
int A = ReadConsole("Введите число А:");
int B = ReadConsole("Введите число B:");
int pow = Extent(A, B);
Console.Write(pow);
