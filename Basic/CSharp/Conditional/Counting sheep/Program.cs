bool[] sheeps =
[
    true,
    true,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    false,
    true,
    false,
    true,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    false,
    false,
    true,
    true,
];

// Form 1: Method
static int CountSheeps(bool[] sheeps)
{
    int n_of_sheeps = 0;
    for (int i = 0; i < sheeps.Length; i++)
        if (sheeps[i] == true)
            n_of_sheeps++;
    return n_of_sheeps;
}

Console.WriteLine($"Number of sheeps: {CountSheeps(sheeps)}");

// From 2: Lambda
static int CountSheeps2(bool[] sheeps)
{
    return sheeps.Count(s => s);
}

Console.WriteLine($"Number of sheeps2: {CountSheeps2(sheeps)}");

// From 3: Foreach
static int CountSheeps3(bool[] sheeps)
{
    int count = 0;
    foreach (bool sheep in sheeps)
    {
        if (sheep)
            count++;
    }
    return count;
}
Console.WriteLine($"Number of sheeps3: {CountSheeps3(sheeps)}");