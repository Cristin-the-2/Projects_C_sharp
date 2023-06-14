// Сформируйте трёхмерный массив двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateCube(int x, int y, int z)
{
    int[,,] cube = new int[x, y, z];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                cube[i, j, k] = rand.Next(10, 100);
            }
        }
    }
    return cube;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

int myX = ReadInt("Введите размер X куба: ");
int myY = ReadInt("Введите размер Y куба: ");
int myZ = ReadInt("Введите размер Z куба: ");

PrintCube(GenerateCube(myX, myY, myZ));