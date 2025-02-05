static int convert(int minutes) {
    int seconds = 0;
    seconds = minutes * 60;
    return seconds;
}

Console.WriteLine($"5 = {convert(5)}");
Console.WriteLine($"3 = {convert(3)}");
Console.WriteLine($"2 = {convert(2)}");
