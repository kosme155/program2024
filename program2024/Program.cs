using program2024;

internal class Program
{
    public static void Main(string[] args)
    {
        string? name = MyConsole.Ask("hva heter du ?");
        Console.WriteLine($"Hei, {name}!");

        int? birthYear = MyConsole.AskForInt("Hvilket år er du født ?");
        var hadBirthday = MyConsole.AskForBool("Har du hatt bursdag i år ?");
        var age = 2024 - birthYear;
        if (!hadBirthday) age--;
        Console.WriteLine($"Da er du {age} år gammel!");
        Console.WriteLine($"Da er du " + age + " år gammel!");
    }
}
