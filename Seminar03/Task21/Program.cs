// Программа принимает на вход координаты двух точек и находит расстояние между ними в 2д пространстве

int[] coords1 = new int[2];
Console.Write("Введите Х первой точки: ");
coords1[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y первой точки: ");
coords1[1] = Convert.ToInt32(Console.ReadLine());

int[] coords2 = new int[2];
Console.Write("Введите Х второй точки: ");
coords2[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y второй точки: ");
coords2[1] = Convert.ToInt32(Console.ReadLine());

double dis = Math.Round(Math.Sqrt(Math.Pow((coords1[0] - coords2[0]), 2) + Math.Pow((coords1[1] - coords2[1]), 2)), 2);

Console.WriteLine($"Расстояние между точками: {dis}.");