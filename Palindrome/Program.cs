// Проверить пятизначное число на палиндромность

// Console.Write("Введите число: ");
// int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int[] arrN = new int[5];
// arrN[0] = N / 10000;
// arrN[1] = (N % 10000) / 1000;
// arrN[2] = ((N % 10000) % 1000) / 100;
// arrN[3] = (((N % 10000) % 1000) % 100) / 10;
// arrN[4] = (((N % 10000) % 1000) % 1000) % 10;

// if (N > 9999 && N < 100000)
// {
//     if (arrN[0] == arrN[4] && arrN[1] == arrN[3])
//     {
//         Console.WriteLine("Число является палиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом.");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное.");
// }

Console.Write("Введите число: ");
string? N = Console.ReadLine();
char[] arrN = N.ToCharArray();
bool result = false;

for(int i = 0; i <= (arrN.Length / 2); i++)
{
    if(arrN[i] == arrN[arrN.Length - 1 - i])
    {
        result = true;
    }
    else
    {
        result = false;
        break;
    }
}

if(result == true)
{
    Console.WriteLine("Число является палиндромом.");
}
else if(result == false)
{
    Console.WriteLine("Число не является палиндромом.");
}