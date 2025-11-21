namespace _01_functions;

internal class Program
{
    static void Main(string[] args)              // program type: 'string'
    {
        Program Program = new Program();         // er wordt een nieuwe program aangemaakt genaamd 'run'
        Program.Run();                             // nieuwe program: 'run'
                                                 // return = void
    }

    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
    }


}
