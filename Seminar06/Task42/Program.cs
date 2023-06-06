// Программа преобразовывает десятичное число в двоичное

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ConvertToBin(int n)
{
    int count = 0;
    int n2 = n;
    while(n2>0)
    {
        n2 = n2/2;
        count++;
    }
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = n%2;
        n = n/2;
    }
    Array.Reverse(arr);
    return arr;
}

void PrintArr(int[] array)
{
    Console.WriteLine(string.Join("", array));
}

int number = ReadInt("Введите число: ");
PrintArr(ConvertToBin(number));