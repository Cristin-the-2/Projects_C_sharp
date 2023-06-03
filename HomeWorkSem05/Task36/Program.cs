// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ArrLong(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void GenArr(int[] array, int lef_range, int righ_range)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(lef_range, righ_range + 1);
    }
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int OddSum(int[] array)
{
  int sum = 0; 
    for(int i = 1; i < array.Length; i +=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] my_arr = new int[ArrLong("Введите длину массива: ")];
GenArr(my_arr, -1000, 1000);
PrintArr(my_arr);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях {OddSum(my_arr)}.");