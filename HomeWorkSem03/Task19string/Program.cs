//Проверка на палиндромность с применением строчного типа данных

Console.Write("Введите число: ");
string? number = Console.ReadLine();
char[] arr_number = number.ToCharArray();
bool result = false;
 
for(int i = 0; i <= (arr_number.Length / 2); i++)
{
    if(arr_number[i] == arr_number[arr_number.Length - 1 - i])
    {
        result = true;
    }
    else
    {
        break;
    }
}
 
if(result == true)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}