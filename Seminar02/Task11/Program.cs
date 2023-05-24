// Программа выводит случайное трехзначное число и удаляет вторую цифру этого числа

Random rand = new Random();
int randNumber = rand.Next(100, 1000);

Console.WriteLine(randNumber);

int firstNumber = randNumber / 100;
int thirdNumber = randNumber % 10;
int Number = (firstNumber * 10) + thirdNumber;

Console.WriteLine(Number);