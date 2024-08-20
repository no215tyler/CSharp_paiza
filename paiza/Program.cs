namespace paiza;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] strArray = str.Split(' ');
        int[] nums = Array.ConvertAll(strArray, int.Parse);
        if (nums[0] == 1 ^ nums[1] == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

