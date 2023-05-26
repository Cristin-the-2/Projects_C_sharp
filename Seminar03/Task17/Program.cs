// Программа принимает на вход координаты точки X и Y (не равны нулю) и выдает номер четверти плоскости 
//в которой эта точка находится

int[] coords = new int[2];

Console.Write("Введите Х: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if(coords[0] > 0 && coords[1] > 0)
{
    Console.WriteLine("Мы находимся в первой четверти");
}
else if (coords[0] < 0 && coords[1] > 0)
{
    Console.WriteLine("Мы находимся во второй четверти");
}
else if (coords[0] < 0 && coords[1] < 0)
{
    Console.WriteLine("Мы находимся в третьей четверти");
}
else if (coords[0] > 0 && coords[1] < 0)
{
    Console.WriteLine("Мы находимся в четвертой четверти");
}
else
{
    Console.WriteLine("Координата находится на осях");
}