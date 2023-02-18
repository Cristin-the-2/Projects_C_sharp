// Напишите функцию, которая принимает число и возвращает 
// слово Google с количеством букв o, равным этому числу.

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string G = new string ('o', N);

Console.WriteLine($"G{G}gle");