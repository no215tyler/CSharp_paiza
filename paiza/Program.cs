namespace paiza;
using System.Numerics;

class Program
{
    static void Main()
    {
        // 乗客人数 C#編
        // ある電車に a 人が乗っています。
        // 駅に到着した時に b 人が降りて新たに c 人が乗車する時、
        // 電車に乗っている乗客人数を求めてください。

        // 半角スペース区切りで文字列型で配列化
        string[] input = Console.ReadLine().Split(" ");

        // 文字列型の配列を整数型の配列に変換
        int[] nums = Array.ConvertAll(input, int.Parse);

        int a = nums[0];
        int b = nums[1];
        int c = nums[2];

        // debug
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

        //int result = (a - b - c);
        //Console.WriteLine(result);
    }
}