// Программа задает двумерный массив и находит элементы с нечетными индексами и возводит эти элементы в квадрат

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

int[,] GhangeMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
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

int M = ReadInt("Введите количество строк матрицы: ");
int N = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(M, N);
PrintMatrix(myMatrix);
System.Console.WriteLine();
myMatrix = GhangeMatrix(myMatrix);
PrintMatrix(myMatrix);