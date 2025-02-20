Console.Write("Enter the base: ");
string @base = Console.ReadLine();

Console.Write("Entered the exponent: ");
double exponent = Convert.ToDouble(Console.ReadLine());

// Criar uma classe que divida a base se tiver o caractere "/"
// Converter a saida para double novamente.
static double[] SepareteBase(string @base)
{
    string[] texts = @base.Split("/");
    double[] numbers = [2];
    foreach (string text in texts)
    {
        double number = Convert.ToDouble(text);
        numbers.Append(number);
    }

    return numbers;
}

static double Power(string @base, double exponent)
{
    double base_double = Convert.ToDouble(@base);
    if (exponent == 0)
        return 1;
    return base_double * exponent;
}

static double PowerD(double @base, double exponent)
{
    if (exponent == 0)
        return 1;
    return @base * exponent;
}

static void MultiPower(double[] numbers, double exponent)
{
    foreach (double number in numbers)
    {
       Console.WriteLine(PowerD(number, exponent));
    }
}

// Console.WriteLine($"Result: {Power(@base, exponent)}");
// SepareteBase("7/9");
