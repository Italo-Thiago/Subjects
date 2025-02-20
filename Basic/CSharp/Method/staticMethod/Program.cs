/*
 * Desenvolva uma classe estática que ofereça um método para somar dois números e retornar o resultado. Esse exercício é focado na definição e uso de métodos utilitários.
*/

Console.WriteLine(SumNumber.Sum(5, 5));

public static class SumNumber
{
    public static int number_one = 1;
    public static int number_two = 2;

    public static int Sum(int number_one,int number_two)
    {
        return number_one + number_two;
    }
}


