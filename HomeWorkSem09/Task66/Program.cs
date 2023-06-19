// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int m, int n)
{
    if (n == m) return n;
    return n + SumNumber(m, n - 1);
}

int myM = ReadInt("Введите число M: ");
int myN = ReadInt("Введите число N: ");
if (myM < myN) Console.WriteLine($"Сумма чисел от {myM} до {myN}: {SumNumber(myM, myN)}");
else Console.WriteLine($"Сумма чисел от {myN} до {myM}: {SumNumber(myN, myM)}");