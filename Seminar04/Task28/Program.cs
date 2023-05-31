// Программа принимает число Н и выдает произведение от 1 до Н

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int A)
{
    int sum = 1;
    if (A < 0) 
    {
        Console.WriteLine("Факториала отрицательного числа не существует");
        return -1;
    }
    else if (A == 0) return sum;
    else
    {
        for (int i = 2; i <= A; i++)
        {
            sum *= i;
        }
        return sum;
    }
}

int number = ReadInt("Введите число N: ");
Console.WriteLine($"Факториал = {Factorial(number)}.");