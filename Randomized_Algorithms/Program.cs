// EN: Random Array
// PT: Array Aleatório
int[] array = { 1, 2, 3, 4, 5 };
Random rng = new Random();

array = array.OrderBy(x => rng.Next()).ToArray();

Console.WriteLine(string.Join(" ", array));

// EN: Random List
// PT: Lista Aleatória
List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6 };
List<int> numbers3 = new List<int>();
List<int> numbers4 = new List<int>() { 7 };

// EN: Example usage
// PT: Exemplo de uso
Console.WriteLine(find_median(numbers1)); // Output: 3
Console.WriteLine(find_median(numbers2)); // Output: 3 or 4 (randomly chosen)
if (find_median(numbers3) == null)
    Console.WriteLine("Null");            // Output: null
Console.WriteLine(find_median(numbers4)); // Output: 7

// EN: Find the median of a list of numbers
// PT: Encontra a mediana de uma lista de números
static int? find_median(List<int> numbers) 
{
    int n = numbers.Count();
    if (n == 0) {
        return null; 
    }
    if (n == 1) {
        return numbers[0];
    }

    // EN: Shuffle the list to ensure a random ordering
    // PT: Embaralha a lista para garantir uma ordem aleatória
    Random rng_2 = new Random();
    numbers = numbers.OrderBy(a => rng_2.Next()).ToList();

    // EN: Find the median by selecting the middle element
    // PT: Encontra a mediana selecionando o elemento do meio
    return numbers[n / 2];
}



