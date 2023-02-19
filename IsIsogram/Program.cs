// Напишите функцию, которая принимает строку (слово) и возвращает True 
// или False в зависимости от того, является слово изограмой или нет.

Console.Write("Введите слово: ");
string? str = Console.ReadLine();
str = str.ToLower();
char[] arrStr = str.ToCharArray();
bool Result = false;

for (int tmp = arrStr.Length-1; tmp > 0; tmp = tmp - 1)
{
    for (int i = tmp-1; i >= 0; i = i - 1)
    {
        if (arrStr[tmp] != arrStr[i])
        {
            Result = true;
        }
        else
        {
            Result = false;
            goto LoopEnd;
        }
    }
}

LoopEnd: Console.WriteLine(Result);