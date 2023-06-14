// Задается двумерный массив. Программа удаляет строку и столбец на пересечении
// который раположен наименьший элемент.


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

int[] FindMin(int[,] matrix)
{
    int[] minloc = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minloc[0], minloc[1]])
            {
                minloc[0] = i;
                minloc[1] = j;
            }
        }
    }
    return minloc;
}

int[,] DeleteMinLineColumn(int[,] matrix, int[] arr)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int rownew = 0;
    int colnew = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == arr[0]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == arr[1]) continue;
            newMatrix[rownew, colnew] = matrix[i, j];
            colnew++;
        }
        rownew++;
        colnew = 0;
    }
    return newMatrix;
}

int myLine = ReadInt("Введите количество строк матрицы: ");
int myColumn = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(myLine, myColumn);
PrintMatrix(myMatrix);
int[] myMin = FindMin(myMatrix);
Console.WriteLine($"Минимальный элемент лежит в {myMin[0] + 1} строке в {myMin[1] + 1} столбце.");
PrintMatrix(DeleteMinLineColumn(myMatrix, myMin));