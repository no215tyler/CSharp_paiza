namespace paiza;

class Program
{
    static void Main()
    {
        string[] strNums = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(strNums, int.Parse);
        int n = 10000;
        n = n / nums[0];
        n = n % nums[1];
        Console.WriteLine($"{n}");
    }
}

