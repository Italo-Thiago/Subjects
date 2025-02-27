Console.Write("Enter the base: ");
string @base = Console.ReadLine().Replace(" ", "");

Console.Write("Entered the exponent: ");
double exponent = Convert.ToDouble(Console.ReadLine().Replace(" ", ""));

// Criar uma classe que divida a base se tiver o caractere "/"
// Converter a saida para double novamente.
static double[] SepareteBase(string @base)
{
    string[] texts = @base.Split("/");
    double[] numbers = new double[2];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(texts[i]);
    }

    return numbers;
}

static double Power(string @base, double exponent)
{
    double base_double = Convert.ToDouble(@base);
    if (exponent == 0)
        return 1;
    return Math.Pow(base_double, exponent);
}

static void MultiPower(double[] numbers, double exponent)
{
    if (exponent < 0 && exponent % 2 == 0)
    {
        exponent = Math.Abs(exponent);
        for (int i = 0; i < numbers.Length; i++)
        {
            double temp = numbers[i];
            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - 1 - 1] = temp;
        }
        foreach (double number in numbers)
        {
            Console.WriteLine($"Base: {number}, Exponent: {exponent} = {Math.Pow(number, exponent)}!");
        }
    }
    else
    {
        foreach (double number in numbers)
        {
            Console.WriteLine($"Base: {number}, Exponent: {exponent} = {Math.Pow(number, exponent)}!");
        }
    }
}

double[] numbers = SepareteBase(@base);
MultiPower(numbers, exponent);
// Console.WriteLine($"Result: {Power(@base, exponent)}");
// SepareteBase("7/9");