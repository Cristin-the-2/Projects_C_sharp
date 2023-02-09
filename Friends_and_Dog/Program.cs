int Count = 0;
double Distance = new Random().Next(1, 10001);
int FirstFriendSpeed = new Random().Next(3, 10);
int SecondFriendSpeed = new Random().Next(3, 10);
int DogSpeed = new Random().Next(10, 21);
int Friend = 1;
double Time = 0;
double TotalTime = 0;
double MinuteTime = 0;
double Days = 0;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Дано: ");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Два друга идут навстречу друг другу. Между ними бегает собака.");
Console.WriteLine("Сколько раз собака пробежит между друзьями, пока они не встретятся?");
Console.WriteLine();
Console.WriteLine($"Скорость первого друга - {FirstFriendSpeed} километр{GetWordEnd(FirstFriendSpeed)} в час.");
Console.WriteLine();
Console.WriteLine($"Скорость второго друга - {SecondFriendSpeed} километр{GetWordEnd(SecondFriendSpeed)} в час.");
Console.WriteLine();
Console.WriteLine($"Скорость собаки - {DogSpeed} километр{GetWordEnd(DogSpeed)} в час.");
Console.WriteLine();
Console.WriteLine($"Расстояние между друзьями в начале {Distance} километр{GetWordEnd(Convert.ToInt32(Distance))}.");
Console.WriteLine();

while (Distance > 0.005)
{
    if (Friend == 1)
    {
        Time = Distance / (FirstFriendSpeed + DogSpeed);
        Friend = 2;
    }
    else
    {
        Time = Distance / (SecondFriendSpeed + DogSpeed);
        Friend = 1;
    }
    Distance = Distance - ((FirstFriendSpeed + SecondFriendSpeed) * Time);
    TotalTime = TotalTime + Time;
    Count++;
}

Distance = Math.Floor(1000 * Distance);
Days = Math.Floor(TotalTime / 24);
TotalTime = TotalTime - (Days * 24);
MinuteTime = Math.Floor(60 * (TotalTime - Math.Floor(TotalTime)));
TotalTime = Math.Floor(TotalTime);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Решение:");
Console.WriteLine();
Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Друзья встретились через {Days} {GetDaysEnd(Convert.ToInt32(Days))}, {TotalTime} час{GetWordEnd(Convert.ToInt32(TotalTime))}, {MinuteTime} минут{GetMinuteEnd(Convert.ToInt32(MinuteTime))}.");
Console.WriteLine();
Console.WriteLine($"Расстояние между друзьями при встрече {Distance} метр{GetWordEnd(Convert.ToInt32(Distance))}.");
Console.WriteLine();
Console.WriteLine($"Собака за это время пробежала между друзьями {Count} раз{GetCountEnd(Convert.ToInt32(Count))}.");
Console.WriteLine();
Console.ResetColor();

string GetWordEnd(int integer)
{
    int lastInt = Convert.ToInt32(integer
                                  .ToString()
                                  .ToCharArray()
                                  .Last()
                                  .ToString());

    if (
        (integer >= 5 && integer <= 20) ||
        (integer == 0) ||
        (integer >= 20 && lastInt >= 5 && lastInt <= 9) ||
        (integer >= 20 && lastInt == 0)
       )
        return "ов";

    else if (
              (integer >= 2 && integer <= 4) ||
              (lastInt >= 2 && lastInt <= 4)
            )
        return "а";

    else if (
             (integer == 1) ||
             (lastInt == 1)
            )
        return string.Empty;

    else
        return " Сообщите код ошибки sdft8595-4240-4ac5-9c79-c953dfd571aa";

}

string GetCountEnd(int integer)
{
    int lastInt = Convert.ToInt32(integer
                                  .ToString()
                                  .ToCharArray()
                                  .Last()
                                  .ToString());
    if (
            (integer >= 2 && integer <= 4) ||
            (lastInt >= 2 && lastInt <= 4 && integer > 20)
        )
        return "а";

    else return string.Empty;

}

string GetMinuteEnd(int integer)
{
    int lastInt = Convert.ToInt32(integer
                                  .ToString()
                                  .ToCharArray()
                                  .Last()
                                  .ToString());
    if (
            (integer >= 2 && integer <= 4) ||
            (lastInt >= 2 && lastInt <= 4 && integer > 20)
        )
        return "ы";

    else if (
            (integer == 1) ||
            (lastInt == 1 && integer > 20)
            )
        return "а";
    else
        return string.Empty;

}

string GetDaysEnd(int integer)
{
    int lastInt = Convert.ToInt32(integer
                                  .ToString()
                                  .ToCharArray()
                                  .Last()
                                  .ToString());
    if (
            (integer >= 2 && integer <= 4) ||
            (lastInt >= 2 && lastInt <= 4 && integer > 20)
        )
        return "дня";

    else if (
            (integer == 1) ||
            (lastInt == 1 && integer > 20)
            )
        return "день";
    else
        return "дней";

}