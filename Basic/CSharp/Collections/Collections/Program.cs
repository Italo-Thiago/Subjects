using Collections.BinarySearch;

List<int> zero = [];
List<int> list = PopulationList(zero, 50);
ShowList(list);
int number = 40;
Console.WriteLine($"\nIterative = {Binary.Iterative(list, number)}");
Console.WriteLine($"\nRecursive = {Binary.Recursive(list, number, 0, list.Count)}");

Array myIntArray = Array.CreateInstance(typeof(int),5);

myIntArray.SetValue(8, 0);
myIntArray.SetValue(2, 1);
myIntArray.SetValue(6, 2);
myIntArray.SetValue(3, 3);
myIntArray.SetValue(7, 4);

Array.Sort(myIntArray);

Console.WriteLine("The int array contains the following: ");
Binary.PrintValues(myIntArray);

object myObjectOdd = 1;
Binary.FindMyObject(myIntArray, myObjectOdd);

object myObjectEven = 6;
Binary.FindMyObject(myIntArray, myObjectEven);
                
List<int> PopulationList(List<int> list, int size) 
{
    for (int i = 1; i < size; i++)
    {
        list.Add(i);
    }

    return list;
}

void ShowList(List<int> list)
{
    foreach (var element in list)
    {
       Console.Write($" {element}"); 
    } 
}

