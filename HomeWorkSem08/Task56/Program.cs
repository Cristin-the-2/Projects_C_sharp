// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int line, int column)
{
    int[,] matrix = new int[line, column];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
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

int[] SumLine(int[,] matrix)
{
    int[] sumLine = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumLine[i] += matrix[i, j];
        }
    }
    return sumLine;
}

void FindMinLine(int[] line)
{
    int mini = 0;
    for (int i = 1; i < line.Length; i++)
    {
        if (line[i] > line[mini]) continue;
        mini = i;
    }
    Console.WriteLine($"{mini + 1} строка матрицы имеет наименьшую сумму элементов.");
}

int myLine = ReadInt("Введите количество строк матрицы: ");
int myColumn = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(myLine, myColumn);
PrintMatrix(myMatrix);
FindMinLine(SumLine(myMatrix));