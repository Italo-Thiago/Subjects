// Ask the user to enter a number of days and convert it in seconds

Console.WriteLine("Enter a number of days: ");
int days = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seconds: {days * 86400}");