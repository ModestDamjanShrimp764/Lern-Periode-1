using System;

class Program
{
    static void Main(string[] args)
    {
        // Begrüßung
        Console.WriteLine("Willkommen beim Passwort-Generator!");

        // Frage nach der gewünschten Passwortlänge
        Console.Write("Geben Sie die gewünschte Passwortlänge ein: ");
        int passwortLaenge;
        while (!int.TryParse(Console.ReadLine(), out passwortLaenge) || passwortLaenge <= 0)
        {
            Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
        }

        // Erstelle das Passwort
        string passwort = ErstellePasswort(passwortLaenge);

        // Gib das Passwort aus
        Console.WriteLine($"Generiertes Passwort: {passwort}");
    }

    static string ErstellePasswort(int laenge)
    {
        // Definiere die Zeichen, die im Passwort verwendet werden können
        const string Zeichen = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";

        // Zufallsgenerator
        Random random = new Random();

        // Passwort-Array
        char[] passwort = new char[laenge];

        // Fülle das Passwort mit zufälligen Zeichen
        for (int i = 0; i < laenge; i++)
        {
            passwort[i] = Zeichen[random.Next(Zeichen.Length)];
        }

        // Konvertiere das Zeichen-Array in einen String und gib es zurück
        return new string(passwort );
    }
}



