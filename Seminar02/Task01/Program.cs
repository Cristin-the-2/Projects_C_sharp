//Программа выводит случайное число (1, 99) и показывает наибольшую цифру числа

Random rand = new Random();
int randNumber = rand.Next(10, 100);

Console.WriteLine(randNumber);

int leftNumber = randNumber / 10;
int rightNumber = randNumber % 10;

if(leftNumber > rightNumber)
{
    Console.WriteLine($"{leftNumber} > {rightNumber}");
}
else if(rightNumber > leftNumber)
{
    Console.WriteLine($"{rightNumber} > {leftNumber}");
}
else
{
    Console.WriteLine($"Числа равны.");
}