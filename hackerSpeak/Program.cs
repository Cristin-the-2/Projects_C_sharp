// Напишите функцию, которая принимает строку в качестве аргумента 
// и возвращает закодированную (на язык3 х4к3р4) версию строки.

Console.Write("Введите строку: ");
string? str = Console.ReadLine();
char[] arrStr = str.ToCharArray();

for(int i=0; i<arrStr.Length; i++)
{
    if(arrStr[i].Equals('а'))
    {
        Console.Write("4");
    }
    else if(arrStr[i].Equals('е'))
    {
        Console.Write("3");
    }
    else if(arrStr[i].Equals('и'))
    {
        Console.Write("1");
    }
    else if(arrStr[i].Equals('о'))
    {
        Console.Write("0");
    }
    else if(arrStr[i].Equals('с'))
    {
        Console.Write("5");
    }
    else
    {
        Console.Write(arrStr[i]);
    }
}
Console.WriteLine();