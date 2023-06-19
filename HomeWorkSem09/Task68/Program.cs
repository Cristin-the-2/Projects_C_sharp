// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int myM = ReadInt("Введите число M: ");
int myN = ReadInt("Введите число N: ");
if (myM >= 0 && myN >= 0) Console.WriteLine($"Функция Аккермана для чисел {myM} и {myN}: {Ackermann(myM, myN)}");
else Console.WriteLine("Числа должны быть неотрицательные.");