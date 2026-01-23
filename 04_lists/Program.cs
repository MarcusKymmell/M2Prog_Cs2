namespace _04_lists;
using System.Reflection;
using System.Runtime.Serialization.Formatters;


class Program
{
    double[] prijzen = new double[] { 0.99, 5.60, 10.11, 2.50 };
    string[] artiekelen = new string[] { "ijsje", "crepes", "lunch menu", "snoep" };
    Formulier[] formulieren = new Formulier[2];

    internal class Formulier
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Run();    
    }
    internal void Run()
    {   
        formulieren[0] = new Formulier()
        {
            Feedback = "prijzen maar lekker",
            Sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "eten viel tegen",
            Sterren = 2
        };
        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(artiekelen[i]);
            Console.WriteLine(prijzen[i]);
        }
        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine($"{formulier.Feedback}");
            Console.WriteLine($"{formulier.Sterren}");
        }
    }
}   