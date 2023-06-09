// Программа задает двумерный массив и находит сумму элементов на главной диагонали (индексы 0,0 1,1 и т.д.)

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
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

int FindSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i< matrix.GetLength(1); i++)
    {
        sum += matrix[i,i];
    }
    return sum;
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
System.Console.WriteLine($"Сумма элементов на главной диагонали = {FindSum(myMatrix)}.");