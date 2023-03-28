// Напишите функцию, которая принимает массив чисел и возвращает массив, 
// в котором каждое число — это число из исходного массива 
// + сумма всех предыдущих чисел из того же массива.

int[] AskArr(string text)
{
    Console.Write(text);
    string? str = Console.ReadLine();
    int[] array = str.Split(' ').Select(s => Int32.Parse(s)).ToArray();
    return array;
}

void PrintArr(int[] A)
{
    Console.WriteLine("[" + string.Join(",", A) + "]");
}

int[] arr = AskArr("Введите массив через пробел: ");
PrintArr(arr);

int sum = 0;
int[] arr1 = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    sum = sum + arr[i];
    arr1[i] = sum;
}
PrintArr(arr1);