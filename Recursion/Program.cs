using Recursion;

// Memory_Allocation memo = new Memory_Allocation();

// int test = 3;
// // EN: Call the printFun method with the test value
// // PT: Chama o método printFun com o valor de teste
// memo.printFun(test);

// EN: Output 3 2 1 1 2 3
// PT: Saída 3 2 1 1 2 3

Fibonacci fib = new Fibonacci();

int i = 5;
// EN: Print the Fibonacci series
// PT: Imprime a série de Fibonacci
Console.Write($"Fibonacci series of {i} number(s) is: ");

while (i > 0)
{
    // EN: Print the Fibonacci number
    // PT: Imprime o número de Fibonacci
    Console.Write(fib.fib(i) + " ");
    i--;
}