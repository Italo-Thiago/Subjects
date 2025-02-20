/*
Desenvolva um exercício em que o aluno crie um método que receba um número variável de números inteiros através do parâmetro params e que retorne a soma de todos os elementos.
*/

// Criar método para entrada de dados pelo usuário
// Criar método para soma dos números
// Mostrar na tela o resultado

List<int> UserInput()
{
    List<int> sum = [];
    while (true)
    {
        Console.Write("Enter another number ('y' = Yes, 'n' = No): ");
        string? choose = Console.ReadLine().ToLower();
        if (choose.Contains('y'))
        {
            Console.Write("Enter the value: ");
            int number = Convert.ToInt32(Console.ReadLine());
            sum.Add(number);
        }
        else if (choose.Contains('n'))
        {
            Console.WriteLine("Closing Operation!!!");
            break;
        }
        else
            Console.WriteLine("Try again");
    }
    return sum;
}

void PrintList(List<int> arr)
{
    for (int i = 0; i < arr.Count; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// void ParamsList

List<int> sum = [];
sum = UserInput();
PrintList(sum);
