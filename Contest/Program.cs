using System.Diagnostics;

namespace Contest
{
    public class Program
    {
        int upperBound = 1000;
        static bool IsPrime(int n)
        {
            // Se n è minore o uguale a 1, non è primo
            if (n <= 1) return false;
            // Se n è 2 o 3, è primo
            if (n <= 3) return true;
            // Se n è divisibile per 2 o 3, non è primo
            if (n % 2 == 0 || n % 3 == 0) return false;
            // Inizia a controllare i divisori da 5 in poi
            int i = 5;
            while (i * i <= n) // Continua fino a i*i che è maggiore di n
            {
                // Se n è divisibile per i o i+2, non è primo
                if (n % i == 0 || n % (i + 2) == 0) return false;
                i += 6; // Incrementa i di 6, poiché i divisori possibili oltre 2 e 3 sono nella forma 6k±1
            }
            // Se nessuna delle condizioni precedenti è vera, n è primo
            return true;
        }

        static void Primes(int upperBound)
        {
            for (int i = 0; i < upperBound; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            // qui il cronometro
            Stopwatch sw = new Stopwatch();
            // si attiva il cronometro
            sw.Start();
            // esegue il metodo da misurare
            Primes(1000);
            // ferma il cronometro
            sw.Stop();
            // stampa del tempo trascorso
            Console.WriteLine($"Execution time: {sw.ElapsedMilliseconds} ms");
        }
    }
}