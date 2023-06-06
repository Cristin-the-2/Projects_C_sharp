// Программа выводит числа Фибоначчи без рекурсии

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i-1]+arr[i-2];
    }
    return arr;
}

void PrintArr(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int number = ReadInt("Введите необходимое количество чисел Фибоначчи: ");
int[] fibnum = Fibonacci(number);
PrintArr(fibnum);