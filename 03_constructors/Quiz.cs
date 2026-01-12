namespace _0._3_Constructors;

class Quiz {
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden ;

    internal Quiz(int aantalVragen)
    {
vragen = new QuizVraag[aantalVragen];
}
void voegVraagToe(QuizVraag vraag, int index) {
    vragen[index] = vraag;
}
void VoegVraagToeOpIndex(int index, string vraag, sting antwoord) {
   QuizVraag vraag = new QuizVraag(vraag, antwoord);
   voegVraagToe(vraag,index);
}
}