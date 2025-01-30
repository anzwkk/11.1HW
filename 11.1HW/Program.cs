using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

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

        while (attemptsLeft > 0)
        {
            Console.Write("Введіть літеру: ");
            char input = Console.ReadLine()[0];
            bool found = false;
            string positions = "";

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == input)
                {
                    guessedWord[i] = input;
                    found = true;
                    positions += (i + 1) + " ";
                }
            }
            if (!found)
            {
                attemptsLeft--;
                Console.WriteLine("Неправильна відповідь! Залишилось спроб: " + attemptsLeft);
            }
            else
            {
                Console.WriteLine("Така літера є у слові! Позиція літери: " + positions.Trim());
            }

            Console.WriteLine("Поточне слово: " + new string(guessedWord));
            Console.WriteLine();

            if (new string(guessedWord) == secretWord)
            {
                Console.WriteLine("Вітаємо! Ви відгадали слово: " + secretWord);
                break;
            }
        }

        if (attemptsLeft == 0)
        {
            Console.WriteLine("Ви програли! Загадане слово було: " + secretWord);
        }

        Console.WriteLine("Дякуємо за гру!");
    }
    
}