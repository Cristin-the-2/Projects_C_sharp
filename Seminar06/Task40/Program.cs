// Программа принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины

int[] ReadArr(string text)
{
    Console.Write(text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void CheckTriangle(int[] array)
{
    if ((array[0] < array[1] + array[2]) && (array[1] < array[0] + array[2]) && (array[2] < array[1] + array[0]))
    {
        Console.WriteLine("Треугольник существует.");
    }
    else Console.WriteLine("Треугольник не существует.");
}

int[] triangle = ReadArr("Введите числа: ");
PrintArr(triangle);
CheckTriangle(triangle);