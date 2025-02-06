using StringTo; // Directive using must stay at the top

string name = "123";
Console.WriteLine($"Convert: {StringToNumber(name)}");

string name2 = "456";
Console.WriteLine($"Convert: {StringToNumber2(name2)}");

string name3 = "789";
Console.WriteLine($"Convert: {Converter.StringToNumber3(name3)}");

// From 1: Method
static int StringToNumber(string str)
{
    return Convert.ToInt32(str);
}

// Form 2: Lambda
static int StringToNumber2(string str) => int.Parse(str);

// From 3: Own function
namespace StringTo
{
    public static class Converter
    {
        public static int StringToNumber3(string str) => str.TryParseInt() ?? 0;
    }

    public static class StringExtensions
    {
        public static int? TryParseInt(this string source)
        {
            int signed = source[0] == '-' ? 1 : 0;
            int? result = -signed; // prevent overflow for signed numbers

            // Validation: verifies if all characters are digits
            for (int i = signed; i < source.Length; ++i)
            {
                if (source[i] > '9' || source[i] < '0')
                {
                    return null;
                }
            }

            // Conversion: sums the digits multiplied by their respective power of 10
            for (int mult = 1, i = source.Length - 1; i >= signed; --i, mult *= 10)
            {
                result = checked(result + ((source[i] - '0') * mult));
            }

            return signed == 1 ? -result.Value - 1 : result;
        }
    }
}
