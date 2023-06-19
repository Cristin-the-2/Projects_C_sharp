// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int MultiplyNumber(int a, int b)
{
    if (b == 0) return 1;
    return a*MultiplyNumber(a, b-1);
}

int A = ReadInt("Введите число: ");
int B = ReadInt("Введите степень: ");
Console.WriteLine($"Число {A} в степени {B}: {MultiplyNumber(A,B)}");