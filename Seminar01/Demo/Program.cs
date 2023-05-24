//Программа принимает на вход число и выдает его квадрат

Console.Write("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа равен: {square}");