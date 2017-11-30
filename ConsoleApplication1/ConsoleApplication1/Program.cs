using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Napiste cislo od 0 do 6 vratane....:");
                string day = Console.ReadLine();

                /*
                 * Sposob cislo 1, posleme len string a na strane triedy urobime konverziu
                 */
                dnyTydne.getWeekDay(day);
                dnyTydne.getWeekDay(day, true);

                /*
                 * Sposob 2, zavolame s instanciovanim objektu a s parametrom konstruktora, do metody uz dostaneme
                 * hotove veci
                 */
                dnyTydne.getWeekDay(new Conversion(day));
                dnyTydne.getWeekDay(new Conversion(day), true);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
           

        }
    }
}
