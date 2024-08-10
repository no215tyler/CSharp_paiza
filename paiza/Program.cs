namespace paiza;

class Program
{
    static void Main()
    {
        string[] strNums = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(strNums, int.Parse);

        int x = nums[0] * nums[0];
        int y = (nums[1] * nums[1]) + (nums[2] * nums[2]);
        Console.WriteLine($"{x} {y}");
    }
}

