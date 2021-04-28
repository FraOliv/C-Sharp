using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        //void significa che il metodo non ritorna un valore
        {
            Console.Write("Ciao, Inserisci un numero e il programma provvederà a calcolarne il 'Fattoriale' ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"il fattoriale del numero {n} è {Fattoriale(n)}");
        }

        //definisco ed inizializzo un metodo ricorsivo per calcolare il fattoriale di un numero
        static int Fattoriale(int n){
            //scrivo un test condizionale che interrompa la ricorsione in modo di non far crashare il programma. si dice "caso base"
            if (n == 0)
                return 1;
            return n * Fattoriale(n - 1);
        }
    }
}
