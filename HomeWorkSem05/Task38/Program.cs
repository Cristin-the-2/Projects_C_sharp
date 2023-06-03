// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,34 7,62 22,47 2,98 78,03] -> 75,05

int ArrLong(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void GenArr(double[] array, int lef_range, int righ_range)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = Math.Round((lef_range + rand.NextDouble() * (righ_range - lef_range)), 2);
    }
}

void PrintArr(double[] array)
{
    Console.WriteLine("[" + string.Join("; ", array) + "]");
}

void FindMinMax(double[] array, out double max, out double min)
{
    max = array[0];
    min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
}

double[] my_arr = new double[ArrLong("Введите длину массива: ")];
GenArr(my_arr, 0, 1000);
PrintArr(my_arr);
FindMinMax(my_arr, out double my_max, out double my_min);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {Math.Round(my_max - my_min, 2)}.");