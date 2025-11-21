namespace _01_functions;

internal class Program
{
    static void Main(string[] args)              // program type: 'string'
    {
        Program Program = new Program();         // er wordt een nieuwe program aangemaakt genaamd 'run'
        Program.Run();                          // nieuwe program: 'run'
        Program.vraag1();
        Program.vraag2();
        Program.vraag3();
        Program.vraag4();
        Program.vraag5();
        Program.vraag6();
                                                 // return = void
    }

    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");


    }

    internal void vraag1()
    {
        Console.WriteLine("how do you think you'd survide in a zombie apocolypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void vraag2()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void vraag3()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void vraag4()
    {
        Console.WriteLine("Which species would be the rudest if all animals could talk?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void vraag5()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void vraag6()
    {
        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }


}
