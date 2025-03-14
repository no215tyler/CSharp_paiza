namespace paiza;
using System.Numerics;

class Program
{
    static void Main()
    {
        // 配列基礎
        string input = Console.ReadLine();
        string[] strAry = input.Split(" ");
        foreach (string str in strAry)
        {
            Console.WriteLine($"{str}");
        }
    }
}
