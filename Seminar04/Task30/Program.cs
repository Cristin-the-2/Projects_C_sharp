// Программа выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] arr = new int[8];
void RandArr(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(0, 2);
    }
}

void PrintArr(int[] A)
{
    // for (int i = 0; i < 8; i++)
    // {
    //     Console.Write($"{A[i]}, ");
    // }
    Console.WriteLine("[" + string.Join(",", arr) + "]");
    Console.WriteLine();
}

RandArr(arr);
PrintArr(arr);