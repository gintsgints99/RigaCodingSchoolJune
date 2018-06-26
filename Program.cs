using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int vesels = 4;
             Console.WriteLine(vesels);
             vesels = 5;
             Console.WriteLine(vesels);

             int rezultats2 = vesels +4;

             double komats = 5.6; //skaitlis ar komatu
             char simbols = '7';
             string virkne = "abc";
             virkne = virkne + simbols; //sadi var darit
             Console.WriteLine(virkne); */

            /* Console.WriteLine("Ievadiet savu gadu: ");
             string virkne2 = Console.ReadLine();
             int rezultats = Convert.ToInt16(virkne2);
             Console.WriteLine(rezultats);
             rezultats = rezultats + 6;
             Console.WriteLine(rezultats); */


            Console.WriteLine("Ka jus sauc: ");
            string ievade = Console.ReadLine();
            Console.WriteLine("Kads tagad gads: ");
            string gads = Console.ReadLine();
            int skaitlisGads = Convert.ToInt16(gads);


            Console.WriteLine("Kura gada esat dzimis: ");

            gads = Console.ReadLine();
            int skaitlisGadsDzimsanas = Convert.ToInt16(gads);
            int rezultats = skaitlisGads - skaitlisGadsDzimsanas;

            int rezulats = skaitlisGads - skaitlisGadsDzimsanas;
            Console.WriteLine("Sveiki, " + ievade + " jums ir" + rezultats + "gads" );
            Console.ReadLine();
            
            //123 new tesxttxtx

            
       }
    }
}
