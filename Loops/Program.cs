using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int righe;
            //definire a inizio programma variabile

            while (true){
                Console.Write("Choose a number (write 'no' to exit)");
                string prompt = Console.ReadLine();

                if (prompt == "no") {
                    Console.WriteLine("See you next time!");
                    break;
                }
                
                righe = Convert.ToInt32(prompt);
                //converto la variabile righe in un integer
                for (int i = 1; i <= righe; i++){
                    //il primo loop serve a visualizzare un numero di righe pari al numero di righe indicate dall'utente
                    for (int asterischi = 0; asterischi < i; asterischi++){
                    Console.Write("* ");
                    //il secondo loop serve per ogni riga noi dobbiamo stampare un num crescente di * che va da 1 al num di righe

                    Console.Write("\n");
                    //siccome Console.Write non va a capo, "l'escape" "\n" serve per mandare a capo.

                    }
                }
            }
        }
    }
}