using System;

namespace Recursion;

public class Fibonacci
{
    // EN: Function for fibonacci
    // PT: Função para fibonacci
    public int fib(int n)
    {
        // EN: Stop condition
        // PT: Condição de parada
        if (n == 0)
            return 0;

        // EN: Stop condition
        // PT: Condição de parada
        if (n == 1 || n == 2)
            return 1;
    
        // EN: Recursion function
        // PT: Função recursiva
        else
            return (fib(n - 1) + fib(n - 2));
    }
}
