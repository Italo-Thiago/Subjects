using StringTo; // Diretiva using deve ficar no topo

string name = "123";
Console.WriteLine($"Convert: {StringToNumber(name)}");

string name2 = "456";
Console.WriteLine($"Convert: {StringToNumber2(name2)}");

string name3 = "789";
// Note que agora usamos o método através da classe Converter
Console.WriteLine($"Convert: {Converter.StringToNumber3(name3)}");

// Forma de resolver 1
// Método
static int StringToNumber(string str)
{
    return Convert.ToInt32(str);
}

// Forma de resolver 2
// Lambda/Função anônima
static int StringToNumber2(string str) => int.Parse(str);

// Forma de resolver 3
// Criando sua própria função dentro de uma classe no namespace
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

            // Validação: verifica se todos os caracteres são dígitos
            for (int i = signed; i < source.Length; ++i)
            {
                if (source[i] > '9' || source[i] < '0')
                {
                    return null;
                }
            }

            // Conversão: soma os dígitos multiplicados pelas respectivas potências de 10
            for (int mult = 1, i = source.Length - 1; i >= signed; --i, mult *= 10)
            {
                result = checked(result + ((source[i] - '0') * mult));
            }

            return signed == 1 ? -result.Value - 1 : result;
        }
    }
}
