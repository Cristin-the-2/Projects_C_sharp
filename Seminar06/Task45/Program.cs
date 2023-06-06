// Программа создает копию заданного массива

int ArrLong(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void GenArr(int[] array, int leftRange, int rightRange)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] CopyArr(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i]=array[i];
    }
    return array2;
}

int[] arr = new int[ArrLong("Введите длину массива: ")];
GenArr(arr, -9, 9);
int[] arrCopy = CopyArr(arr);
PrintArr(arr);
Console.WriteLine();
PrintArr(arrCopy);