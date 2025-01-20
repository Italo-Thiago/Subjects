using System;

namespace Recursion;

public class Memory_Allocation
{
    // EN: Function to demonstrate working of recursion
    // PT: Função para demonstrar o funcionamento da recursão
    public void printFun(int test)
    {
        if (test < 1)
            return;
        else
        {
            // EN: Print the current value
            // PT: Imprime o valor atual
            Console.Write(test + " ");
            
            // EN: Statement 2 - Call the function recursively with the next value
            // PT: Declaração 2 - Chama a função recursivamente com o próximo valor
            printFun(test - 1);

            // EN: Print the current value again
            // PT: Imprime o valor atual novamente
            Console.Write(test + " ");
            return;
        }
    }
}
