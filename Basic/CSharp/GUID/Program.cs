Guid id = Guid.NewGuid();
Console.WriteLine(id.ToString());
Console.WriteLine();

var id2 = Guid.NewGuid().ToString()[..8];
Console.WriteLine($"{id2} \n");

Guid g = new Guid();
Console.WriteLine(g.ToString());

if (g == Guid.Empty)
    Console.WriteLine("O Guid esta vazio");
Console.WriteLine();

var guid1 = Guid.Parse("fc072692-d322-448b-9b1b-ba3443943579");
Console.WriteLine("Guid1: " + guid1);

Guid.TryParse("fc072692-d322-448b-9b1b-ba3443943579", out var guid2);
Console.WriteLine("Guid2: " + guid2);
Console.WriteLine();

var meuGuid = Guid.NewGuid();
Console.WriteLine("D \t" + meuGuid.ToString("D"));
Console.WriteLine("N \t" + meuGuid.ToString("N"));
Console.WriteLine("B \t" + meuGuid.ToString("B"));
Console.WriteLine("P \t" + meuGuid.ToString("P"));
Console.WriteLine("X \t" + meuGuid.ToString("X"));
Console.WriteLine();

for (var i = 0; i <= 2; i++)
{
    var id3 = Guid.CreateVersion7();
    Console.WriteLine(id3);
}
Console.WriteLine();

for (var i = 0; i <= 2; i++)
{
    var id4 = Guid.CreateVersion7(TimeProvider.System.GetUtcNow()); // Modifique pois ainda está colocando o mesmo time provider
    Console.WriteLine(id4);
}
