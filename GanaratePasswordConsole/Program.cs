using GenerationPassword;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Ввудите количетсво паролей");
        int countPasswords = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ВВедите кол-во символов");
        int countChar = Convert.ToInt32(Console.ReadLine());
        var passwords = GeneratorPassword.Generate(countPasswords, countChar);
        foreach(var i in passwords)
            Console.WriteLine(i+"\n");
    }
}