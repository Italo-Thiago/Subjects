static int StringToNumber(string str) {
    return Convert.ToInt32(str);
}

string name = "123";
Console.WriteLine($"Convert: {StringToNumber(name)}");

