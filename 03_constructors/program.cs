namespace _0._3_Constructors;

class Program
{
       static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Quiz quiz = new Quiz(10);
        QuizVraag quizVraag = new QuizVraag("wat is 2+2?", "4");
        quiz.VoegVraagToeOpIndex(0, quizVraag);
        quiz.VoegVraagToeOpIndex(1, "is dit een vraag?", "ja");
        quiz.VoegVraagToeOpIndex(2, "is 5 plus 5 11?", "nee");
        quiz.VoegVraagToeOpIndex(3, "is de aarde rond?", "ja");
        quiz.VoegVraagToeOpIndex(4, "is gras groen?", "ja");
        quiz.VoegVraagToeOpIndex(5, "welke kleur is de zee?", "blauw");
        quiz.VoegVraagToeOpIndex(6, "is zwart een kleur?", "nee");
        quiz.VoegVraagToeOpIndex(7, "is een insect een dier?", "ja");
        quiz.VoegVraagToeOpIndex(8, "hoeveel poten heeft een hond?", "4");
        quiz.VoegVraagToeOpIndex(9, "wat is de hoofdstad van Frankrijk?", "Parijs");

        for (int i = 0; i < 10; i++)
        {
            quiz.StelVraag(i);
        }   

        int finalscore = quiz.score();
        Console.WriteLine(finalscore);
    }
}