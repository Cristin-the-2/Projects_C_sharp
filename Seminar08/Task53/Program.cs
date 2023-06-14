// Задается двумерный массив. Программа меняет местами первую и последнюю строчки
// массива.

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

void ReverseMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int myLine = ReadInt("Введите количество строк матрицы: ");
int myColumn = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(myLine, myColumn);
PrintMatrix(myMatrix);
Console.WriteLine();
ReverseMatrix(myMatrix);
PrintMatrix(myMatrix);