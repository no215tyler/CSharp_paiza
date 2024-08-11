namespace paiza;

class Program
{
    static void Main()
    {
        string[] strNums = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(strNums, int.Parse);

        double result = Math.Pow(((nums[0] + nums[1]) * nums[2]), 2) % nums[3];
        Console.WriteLine(result);
    }
}

