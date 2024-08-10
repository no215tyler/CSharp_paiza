namespace paiza;

class Program
{
    static void Main()
    {
        //string[] strNums = Console.ReadLine().Split(' ');
        //int[] nums = Array.ConvertAll(strNums, int.Parse);

        int num = int.Parse(Console.ReadLine());
        if (num != 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

