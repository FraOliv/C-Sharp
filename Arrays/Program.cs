using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo array rettangolare (multidimensionale) 5x5
        int [,] birillo = new int [5,5];
        //creo variabile contatore
        int counter = 0;


        for (int riga = 0; riga < 5; riga++){
            for (int colonna = 0; colonna < 5; colonna++){
                ++counter;
                //siccome il primo numero di ogni riga dev'essere 0 imposto un condizionale
                birillo[riga,colonna] = (colonna == 0) ? 0 : counter;
                // se colonna è = 0 allora impostagli il valore 0 altrimenti gli imposti il valore contenuto nella variabile counter
                }
            } 
            for (int riga = 0; riga < 5; riga++){
                for (int colonna = 0; colonna < 5; colonna++)
                
                    Console.Write($"{birillo[riga,colonna]} ");
                    Console.Write("\n");
                    //ogniqualvolta il loop mi fa visualizzare l'intera riga (in altre parole, ogni volta che conclude il suo ciclo) vai a capo la visualizzazione.
                    
                
                
            }
            
        }
    }
}
