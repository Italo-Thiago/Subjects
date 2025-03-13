namespace Collections.BinarySearch;

public static class Binary
{
    public static int Iterative(List<int> list, int item)
    {
        int lower = 0;
        int upper = list.Count - 1;
        while (lower <= upper)
        {
            int middle = (lower + upper) / 2;
            int element = list[middle];
            if (element == item)
                return middle;
            if (element > item)
                upper = middle - 1;
            else
                lower = middle + 1;
        }

        return -1;
    }

    public static int Recursive(List<int> list, int key, int start, int end)
    {
        int mid;
        if (start <= end)
        {
            mid = (start + end) / 2;
            if (key == list[mid])
                return mid;
            if (key < list[mid])
                return Recursive(list, key, start, mid - 1);
            else
                return Recursive(list, key, mid + 1, end);
        }
        return -1;
    }
    
    // https://learn.microsoft.com/pt-br/dotnet/api/system.array.binarysearch?view=net-8.0
    public static void FindMyObject(Array myArr, object myObject)
    {
        int myIndex = Array.BinarySearch(myArr, myObject);
        if (myIndex < 0)
            Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
        else
            Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex);
    }

    public static void PrintValues(Array myArr)
    {
        int i = 0;
        int cols = myArr.GetLength(myArr.Rank - 1);
        foreach (object o in myArr)
        {
            if (i < cols)
                i++;
            else
            {
                Console.WriteLine();
                i = 1;
            }
            Console.Write("\t{0}", o);
        }
        Console.WriteLine();
    }
}