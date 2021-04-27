using System;

namespace TypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 12.5f;
            //per dichiare un float si deve mettere alla fine f
            double d = 130.78;
            decimal dm = 1500.456m;
            //per dichiarare un decimal si mette m alla fine
            double ne = 5e-7;
            // e sta *10 e il numero seguente è l'esponente
            var s = "type inference";
            var b = false;

            Console.WriteLine($"f = {f} d = {d} dm = {dm} ne = {ne} s = {s} b = {b}");
            
        }
    }
}
