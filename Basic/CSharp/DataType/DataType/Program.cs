namespace Casting {
class Implicity 
{
    public static void Main(string[] args) 
    {
        int i = 57;
        long l = i;
        
        float f = l;

        Console.WriteLine(i);
        Console.WriteLine(l);
        Console.WriteLine(f);
        
    }

}
}