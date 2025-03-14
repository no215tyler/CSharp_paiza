namespace paiza;
using System.Numerics;

class Program
{
    static void Main()
    {
        // Eメールアドレス C#編
        string local = Console.ReadLine();
        string domain = Console.ReadLine();
        Console.WriteLine($"{local}@{domain}");
    }
}
