/*
Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
*/

static bool lessThan100(int a, int b) {
    double sum = a + b;
    if (sum < 100)
        return true; 
    else
        return false;
}

Console.WriteLine($"22 + 15 = 37 {lessThan100(22, 15)}");
Console.WriteLine($"83 + 34 = 117 {lessThan100(83, 34)}");
Console.WriteLine($"3 + 77 = 80 {lessThan100(3, 77)}");

