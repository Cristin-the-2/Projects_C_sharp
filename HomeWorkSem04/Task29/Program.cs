// Программа спрашивает длину массива, заполняет массив числами и выводит массив на экран

int ArrLong(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void GenArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(0, 100);
    }
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] my_arr = new int[ArrLong("Введите длину массива: ")];
GenArr(my_arr);
PrintArr(my_arr);