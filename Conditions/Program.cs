using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, please, write something");
            //Console.Write fa scrivere qualcosa al programma nel terminale
            string prompt = Console.ReadLine();
            //Console.ReadLine permette di inserire un prompt

            // if (prompt == "primo")
            //     Console.Write("hai scritto primo");
            // else if (prompt == "secondo")
            //     Console.Write("hai scritto secondo");
            // else
            //     Console.Write($"hai scritto {prompt}");


        switch (prompt){
            case "primo":
                Console.Write("hai scritto primo");
                break;
            case "secondo": 
                Console.Write("hai scritto secondo");
                break;
            default:
                Console.Write($"hai scritto {prompt}");
                break;
            //anche dopo il default è da inserire il break

            }
        }
    }
}

