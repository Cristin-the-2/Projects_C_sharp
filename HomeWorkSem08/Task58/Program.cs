// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultipleMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiple = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j1 = 0; j1 < matrix1.GetLength(1); j1++)
        {
            for (int j2 = 0; j2 < matrix2.GetLength(1); j2++)
            {
                multiple[i, j2] += matrix1[i, j1] * matrix2[j1, j2];
            }
        }
    }
    return multiple;
}

int myLine1 = ReadInt("Введите количество строк первой матрицы: ");
int myColumn1 = ReadInt("Введите количество столбцов первой матрицы: ");
int[,] myMatrix1 = GenerateMatrix(myLine1, myColumn1);

int myLine2 = ReadInt("Введите количество строк второй матрицы: ");
int myColumn2 = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] myMatrix2 = GenerateMatrix(myLine2, myColumn2);

Console.WriteLine("Первая матрица:");
PrintMatrix(myMatrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(myMatrix2);

if (myColumn1 == myLine2)
{
    int[,] myMultipleMatrix = MultipleMatrix(myMatrix1, myMatrix2);
    Console.WriteLine("Результат перемножения:");
    PrintMatrix(myMultipleMatrix);
}
else
{
    Console.WriteLine("Размеры матриц недопустимы для перемножения.");
}