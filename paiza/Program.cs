namespace paiza;
using System.Numerics;

class Program
{
    static void Main()
    {
        // int型ではなくlong型の型注釈を使用することでオーバーフローを免れる
        // さらに大きい数値を扱う場合はBigInteger型を定義する（using System.Numericsの名前空間インポートが必要）
        BigInteger num1 = BigInteger.Parse(Console.ReadLine());
        BigInteger num2 = BigInteger.Parse(Console.ReadLine());
        BigInteger result = num1 * num2;
        Console.WriteLine(result);
    }
}
