using System;

class Program
{
    static void Main()
    {
        string secretWord = "Хілель";
        char[] guessedWord = new char[secretWord.Length];

        for (int i = 0; i < guessedWord.Length; i++)
        {
            guessedWord[i] = '_';
        }
        int attemptsLeft = 6;

        Console.WriteLine("Вітаємо! Спробуйте вгадати слово!");
        Console.WriteLine("Кількість літер у слові: " + secretWord.Length);
        Console.WriteLine("Кількість можливих невірних спроб: " + attemptsLeft);

    }
}