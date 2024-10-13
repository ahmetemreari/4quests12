using System;

class Program
{
    static void Main(string[] args)
    {
        // şarkı sözü
        PrintFavoriteSongLyrics();

        // tamsayı
        int remainder = GetRandomNumberRemainder();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + remainder);

        // Parametre1
        int product = MultiplyNumbers(5, 10);
        Console.WriteLine("Çarpım sonucu: " + product);

        // Parametre2
        PrintWelcomeMessage("Ahmet", "Yılmaz");
    }

    // şarkı sözü2
    static void PrintFavoriteSongLyrics()
    {
        Console.WriteLine("Sevdiğim şarkı sözü: 'Hayat bayram olsa, insanlar el ele tutuşsa...'");
    }

    // tamsayı2
    static int GetRandomNumberRemainder()
    {
        Random random = new Random();
        int number = random.Next();
        return number % 2;
    }

    // Parametre3
    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    // Parametr4
    static void PrintWelcomeMessage(string firstName, string lastName)
    {
        Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}");
    }
}
