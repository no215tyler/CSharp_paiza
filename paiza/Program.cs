namespace paiza;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = new List<int>();

        string input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            if (int.TryParse(input, out var num))
            {
                nums.Add(num);
            }
        }

        Console.WriteLine(nums.Max());
    }
}