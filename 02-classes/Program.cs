namespace _02_classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program program = new Program(); //een program // void // new het maakt een nieuw object van het type Program // hij returned void 
        program.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto() 
        {
            automaat = true;
            kenteken = "AA824H"
            kilometerStand = "20567"
            merk = "volkswagen"
        };
        
        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometerStand = "65739",
            merk = "volvo"
        };

        RijLeraar rijLeraar = new Rijleraar()
        {
            leeftijd = 30,
            naam = "John",
            zzs = false
        };

        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijleraar = rijleraar,

            tijd = 1130
        };

        Student student = new Student()
        {
            
        }
    }
}
