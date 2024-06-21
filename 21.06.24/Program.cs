using System;

namespace _21._06._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();

            Console.Write("inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Inseisci la tua data di nascita (gg/mm/aaaa): ");
            DateTime dataNascita = DateTime.Parse(Console.ReadLine());

            Console.Write("Inserisci il tuo codicefiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il tuo Sesso (M/F): ");
            string sessoInput = Console.ReadLine();
            Sesso genere;

            if (sessoInput.ToUpper() == "M")
            {
                genere = Sesso.Uomo;
            }
            else if (sessoInput.ToUpper() == "F")
            {
                genere = Sesso.Donna;
            }
            else
            {
                throw new ArgumentException("Sesso non valido. Inserisci M o F.");
            }

            Console.Write("Inserisci il comune di residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Inserisci il reddito annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            // Creazione dell'oggetto Contribuente
            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, genere, comuneResidenza, redditoAnnuale);

            // Calcolo dell'imposta
            decimal imposta = contribuente.CalcolaImposta();


            // Visualizzazione del riepilogo
            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
            Console.WriteLine($"nato il {contribuente.DataNascita:dd/MM/yyyy} ({(contribuente.Genere == Sesso.Uomo ? "M" : "F")}),");
            Console.WriteLine($"residente in {contribuente.ComuneDiResiddenza},");
            Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {imposta}");  
            Console.WriteLine("==================================================");

            // Attesa per visualizzare il risultato
            Console.WriteLine("Premi un tasto per terminare...");
            Console.ReadKey();
        }
    }
}
