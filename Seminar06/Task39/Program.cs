// Программа перевернет одномерный массив (последний элемент на первом, первый на последнем)

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
    Console.WriteLine("[" + string.Join(",", array) + "]");
}

void Reverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

var myArr = new int[ArrLong("Введите длину массива: ")];
GenArr(myArr, -10, 10);
PrintArr(myArr);
Reverse(myArr);
PrintArr(myArr);