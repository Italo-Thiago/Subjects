// EN: Function to find the maximum number in a given array.
// PT: Função para encontrar o número máximo em um array dado.
static int FindMax(int[] a, int lo, int hi)
{
    // EN: If lo becomes greater than hi, then return minimum integer possible
    // PT: Se lo se tornar maior que hi, então retorne o menor inteiro possível
    if (lo > hi)
        return int.MinValue;
    
    // EN: If the subarray has only one element, return the element
    // PT: Se o subarray tiver apenas um elemento, retorne o elemento
    if (lo == hi)
        return a[lo];
    int mid = (lo + hi) / 2;

    // EN: Get the maximum element from the left half
    // PT: Obtenha o elemento máximo da metade esquerda
    int leftMax = FindMax(a, lo, mid);

    // EN: Get the maximum element from the right half
    // PT: Obtenha o elemento máximo da metade direita
    int rightMax = FindMax(a, mid + 1, hi);
    
    // EN: Return the maximum element from the left and right half
    // PT: Retorne o elemento máximo das metades esquerda e direita
    return Math.Max(leftMax, rightMax);
}

int[] array = { 1, 3, 5, 7, 9, 11 };
int lower = 3;
int upper = 5;

Console.WriteLine($"Resultado = {FindMax(array, lower, upper)}"); // 11