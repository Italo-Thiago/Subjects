// Form 1: if else
static bool lovefunc(int flower1, int flower2)
{
    // Resto
    int rest1 = flower1 % 2;
    int rest2 = flower2 % 2;

    // Verificar se a flor ambas são
    // 0 = Par, 1 = Impar
    if (rest1 == 0 && rest2 == 1)
        return true;
    else if (rest2 == 0 && rest1 == 1)
        return true;
    else
        return false;
}

Console.WriteLine($"1, 4: {lovefunc(1, 4)}");
Console.WriteLine($"0, 0: {lovefunc(0, 0)}");
Console.WriteLine($"0, 1: {lovefunc(0, 1)}");

// Form 2: Diferente
static bool lovefunc2(int flower1, int flower2)
{
    return flower1 % 2 != flower2 % 2;
}

Console.WriteLine("");
Console.WriteLine($"1, 4: {lovefunc2(1, 4)}");
Console.WriteLine($"0, 0: {lovefunc2(0, 0)}");
Console.WriteLine($"0, 1: {lovefunc2(0, 1)}");

// Form 3: Lambda
static bool lovefunc3(int flower1, int flower2) => flower1 % 2 != flower2 % 2;

Console.WriteLine("");
Console.WriteLine($"1, 4: {lovefunc3(1, 4)}");
Console.WriteLine($"0, 0: {lovefunc3(0, 0)}");
Console.WriteLine($"0, 1: {lovefunc3(0, 1)}");