/*
Write a function that returns teh string "something" joined with a space " " and the given argument "a".
*/

static string GiveMeSomething(string a) {
    return $"something" + " " + a;
}

Console.WriteLine(GiveMeSomething("is better than nothing"));
Console.WriteLine(GiveMeSomething("Bob Jane"));
Console.WriteLine(GiveMeSomething("something"));
