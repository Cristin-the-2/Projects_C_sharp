// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ShowElement(int[,] matrix, int line, int column)
{
    if (line < matrix.GetLength(0) && column < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент матрицы с индексом [{line},{column}] = {matrix[line, column]}.");
    }
    else
    {
        Console.WriteLine($"Элемента матрицы с индексом [{line},{column}] нет.");
    }
}

Random rand = new Random();
int m = rand.Next(1, 10);
int n = rand.Next(1, 10);

int[,] myMatrix = GenerateMatrix(m, n);
int i = ReadInt("Введите искомую строку: ");
int j = ReadInt("Введите искомый столбец: ");

PrintMatrix(myMatrix);
Console.WriteLine();
ShowElement(myMatrix, i, j);