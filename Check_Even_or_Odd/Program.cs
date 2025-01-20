using Check_Even_or_Odd;

Console.WriteLine("---------------");
Console.WriteLine("Teste 1°");
int number1 = 101;
Console.Write("Número 101: ");
if (Rest.isEven(number1) == true)
    Console.WriteLine("True");
else   
    Console.WriteLine("False");

Console.Write("Número 50: ");
int number2 = 50;
if (Rest.isEven(number2) == true)
    Console.WriteLine("True");
else   
    Console.WriteLine("False");
Console.WriteLine("---------------");

Console.WriteLine("Teste 2°");
int number1_AND = 101;
Console.Write("Número 101: ");
if (Operator_AND.isEven_AND(number1_AND) == true)
    Console.WriteLine("True");
else   
    Console.WriteLine("False");

Console.Write("Número 50: ");
int number2_AND = 50;
if (Operator_AND.isEven_AND(number2_AND) == true)
    Console.WriteLine("True");
else   
    Console.WriteLine("False");
Console.WriteLine("---------------");

Console.WriteLine("Teste 3°");
int number1_Bitwise = 101;
Console.Write("Número 101: ");
if (Bitwise.isEven_Bitwise(number1_Bitwise) == true)
    Console.WriteLine("True");
else   
    Console.WriteLine("False");

Console.Write("Número 50: ");
int number2_Bitwise = 50;
if (Bitwise.isEven_Bitwise(number2_Bitwise) == true)
    Console.WriteLine("True");
else   
    Console.WriteLine("False");
Console.WriteLine("---------------");