// Программа составляет частотный словарь элеметов двумерного массива.
// Частотный словарь содержит информацию, сколько раз встречается 
// элемет входных данных.

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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] FreqDict(int[,] matrix)
{
    int[] countDict = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            countDict[matrix[i, j]]++;
        }
    }
    return countDict;
}

void PrintDict(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            Console.WriteLine($"Элемент {i} встречается {arr[i]} раз.");
        }
    }
}

int myLine = ReadInt("Введите количество строк матрицы: ");
int myColumn = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(myLine, myColumn);
PrintMatrix(myMatrix);

PrintDict(FreqDict(myMatrix));