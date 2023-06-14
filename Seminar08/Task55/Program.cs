// Задается двумерный массив. Программа заменяет строки на столбцы. 
// Если это невозможно, программа выводит ошибку.

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

// int[,] ReverseMatrix(int[,] matrix)
// {
//     int[,] newMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[j, i] = matrix[i, j];
//         }
//     }
//     return newMatrix;
// }

int[,] ReverseAnyMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}

int myLine = ReadInt("Введите количество строк матрицы: ");
int myColumn = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(myLine, myColumn);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(ReverseAnyMatrix(myMatrix));

// if (myLine == myColumn)
// {
//     int[,] myNewMatrix = ReverseMatrix(myMatrix);
//     PrintMatrix(myNewMatrix);
// }
// else
// {
//     Console.WriteLine("Количество строк и столбцов не равны друг другу.");
//     Console.WriteLine("Перевернуть матрицу невозможно.");
// }