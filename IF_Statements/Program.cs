using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        Console.WriteLine("Tere maailm!");
        Console.ReadLine();
        string eesNimi;
        string perekonnaNimi;
        int sünniaasta;

        Console.WriteLine("Mis on sinu eesnimi?");
        eesNimi = Console.ReadLine();


        Console.WriteLine("Aga perekonnanimi?");
        perekonnaNimi = Console.ReadLine();

        Console.WriteLine($"Tere { eesNimi} { perekonnaNimi}!");


        Console.WriteLine("Sisesta palun oma sünniaasta");
        sünniaasta = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Sa oled {2019 - sünniaasta} aastat vana.");
        Console.ReadLine();
        */

        /* Start:

         int userNumber;
         Console.WriteLine("Sisesta üks number 1-10ni");
         userNumber = Int32.Parse(Console.ReadLine());

          if (userNumber < 5)
         {
             Console.WriteLine($"{userNumber} on väiksem kui 5.");



         }

         if (userNumber > 5)
         {     Console.WriteLine($"{userNumber} on suurem kui 5.");



         }
         else if (userNumber > 5)
         {
             Console.WriteLine($"{userNumber} on suurem kui 5.");


         }
         else if (userNumber == 5)
         {
             Console.WriteLine($"{userNumber} on võrdne 5ga.");

         }

         goto Start;
         */
        Start:
            int userNumber;
            Console.WriteLine("Sisesta üks number 1-10ni.");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
            {

                if (userNumber > 5)
                {
                    Console.WriteLine($"See number on suurem kui 5.");
                }
                else if (userNumber < 5)
                {
                    Console.WriteLine($"See number on väiksem kui 5.");
                }
                else if (userNumber == 5)
                {
                    Console.WriteLine($"See number on võrdne 5ga.");
                }

            }

            else if (userNumber > 10)
            {
                Console.WriteLine($"See number on suurem kui 10. Keda sa lollitad?");
            }
            else
            {
                Console.WriteLine("$See number on väiksem kui 1. Keda sa lollitad?");
           
            }

            goto Start;
        

 } } } 