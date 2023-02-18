// Напишите функцию, которая вычисляет расстояние Хэмминга 
// для двух данных строк.

Console.Write("Введите первую строку: ");
string? str1 = Console.ReadLine();
char[] arrStr1 = str1.ToCharArray();

Console.Write("Введите вторую строку: ");
string? str2 = Console.ReadLine();
char[] arrStr2 = str2.ToCharArray();

int HamDis = 0;

if(arrStr1.Length == arrStr2.Length)
{
    for(int i =0; i < arrStr1.Length; i++)
    {
        if(arrStr1[i] != arrStr2[i]) HamDis++;
    }
    Console.WriteLine($"Расстояние Хэмминга: {HamDis}.");
}
else Console.WriteLine("Строки разной длины.");