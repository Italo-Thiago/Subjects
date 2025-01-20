using System;

namespace Recursion;

public class Direct_and_Indirect
{
    // An example of direct recursion
    // PT: Um exemplo de recursão direta

    int value = 1;

    public static void directRecFun(int v)
    {
        if (v == 5)
            return;
        // EN: Print the current value
        // PT: Imprime o valor atual
        Console.WriteLine($"direct value = {v}");
        // EN: Call the function recursively with the next value
        // PT: Chama a função recursivamente com o próximo valor
        directRecFun(v + 1);
    }

    public static void indirectRecFun1(int v)
    {
        if (v == 5)
            return;
        // EN: Print the current value
        // PT: Imprime o valor atual
        Console.WriteLine($"indirect value one = {v}");
        // EN: Call the second function recursively with the next value
        // PT: Chama a segunda função recursivamente com o próximo valor
        indirectRecFun2(v + 2);
    }

    public static void indirectRecFun2(int v)
    {
        if (v == 5)
            return;
        // EN: Print the current value
        // PT: Imprime o valor atual
        Console.WriteLine($"indirect value two = {v}");
        // EN: Call the first function recursively with the next value
        // PT: Chama a primeira função recursivamente com o próximo valor
        indirectRecFun1(v + 2);
    }

    // EN: Start the direct recursion
    // PT: Inicia a recursão direta
    // directRecFun(value);
    // EN: Start the indirect recursion
    // PT: Inicia a recursão indireta
    // indirectRecFun1(value);
    // indirectRecFun2(value);
}
