// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] ReadArr(string text)
{
    Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int PositiveCount(int[] array)
{
  int count = 0; 
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArr = ReadArr("Введите числа: ");
PrintArr(myArr);
Console.WriteLine($"Количество чисел больше нуля: {PositiveCount(myArr)}.");