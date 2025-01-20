int[] array = { 10, 7, 8, 9, 1, 5 };
int n = array.Length;
QuickSort(array, 0, n - 1);
Console.WriteLine("Array ordenado: ");
PrintArray(array);

static void QuickSort(int[] array, int low, int high)
{
    if (low < high)
    {
        int pi = Partition(array, low, high);

        QuickSort(array, low, pi - 1);  // Antes do pivô
        QuickSort(array, pi + 1, high); // Depois do pivô
    }
}

static int Partition(int[] array, int low, int high)
{
    int pivot = array[high];
    int i = (low - 1);

    for (int j = low; j < high; j++)
    {
        if (array[j] < pivot)
        {
            i++;
            Swap(ref array[i], ref array[j]);
        }
    }

    Swap(ref array[i + 1], ref array[high]);
    return i + 1;
}

static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

static void PrintArray(int[] array)
{
    foreach (int t in array)
    {
        Console.Write(t + " ");
    }
    Console.WriteLine();
}

