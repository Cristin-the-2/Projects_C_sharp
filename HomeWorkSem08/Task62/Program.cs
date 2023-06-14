// Напишите программу, которая заполнит спирально массив 4 на 4. 

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateSpiralMatrix(int line, int column)
{
    int i = 0, j = 0, k = 0;
    int start = 1;
    int[,] spiral = new int[line, column];
    while (start <= line * column)
    {
        spiral[i, j] = start;
        if (i == k && j < column - k - 1) j++;
        else if (j == column - k - 1 && i < line - k - 1) i++;
        else if (i == line - k - 1 && j > k) j--;
        else i--;

        if ((i == k + 1) && (j == k) && (k != column - k - 1))
        {
            k++;
        }
        start++;
    }
    return spiral;
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

int myLine = ReadInt("Введите количество строк спирали: ");
int myColumn = ReadInt("Введите количество столбцов спирали: ");
int[,] mySpiral = GenerateSpiralMatrix(myLine, myColumn);
PrintMatrix(mySpiral);