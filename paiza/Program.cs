namespace paiza;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] strs = Console.ReadLine().Split(',');
        //int[] nums = Array.ConvertAll(strNums, int.Parse);

        foreach (string str in strs)
        {
            Console.WriteLine(str);
        }
    }
}

