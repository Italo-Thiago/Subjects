//EN: Ask the user to enter a number of days and convert it in seconds
//PT: Peça ao usuário para inserir um número de dias e converta-o em segundos.

Console.WriteLine("Enter a number of days: ");
int days = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seconds: {days * 86400}");