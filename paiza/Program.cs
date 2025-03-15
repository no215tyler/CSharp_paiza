namespace paiza;
using System.Numerics;

class Program
{
    static void Main()
    {
        // 引き算・掛け算 C#編
        string[] nums = Console.ReadLine().Split(" ");
        int num1 = int.Parse(nums[0]);
        int num2 = int.Parse(nums[1]);
        int result1 = num1 - num2;
        int result2 = num1 * num2;
        Console.WriteLine($"{result1} {result2}");
    }
}