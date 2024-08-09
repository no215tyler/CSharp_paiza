class Greet
{
    private string name;
    private string language;
    private string hitokoto;

    public Greet(string name, string language, string hitokoto)
    {
        this.name = name;
        this.language = language;
        this.hitokoto = hitokoto;
    }

    public void Greeting()
    {
        Console.WriteLine($"name: {name}");
        Console.WriteLine($"language: {language}");
        Console.WriteLine($"hitokoto: {hitokoto}");
    }
}