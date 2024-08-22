namespace paiza;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string strNums = Console.ReadLine();
        string[] numsArray = strNums.Split(' ');
        int[] nums = Array.ConvertAll(numsArray, int.Parse);
        int count = nums.Count(num => num == 1);
        Console.WriteLine(count);
    }
}

