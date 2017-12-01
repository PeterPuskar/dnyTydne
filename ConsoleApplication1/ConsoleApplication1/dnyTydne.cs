using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class dnyTydne : Conversion
    {

        /*public dnyTydne():base()
        {

        }*/

        public dnyTydne(string day) : base(day)
        {

        }
        
        public static void getWeekDay(string day)
        {
            Conversion con = new Conversion(day);
            if (con.result.status)
            {
                Console.WriteLine("(Prvy den je nedela) (Array) Den: {0}", Conversion.week[con.result.num]);
                Console.WriteLine("(Prvy den je nedela) (Enum) Den: {0}", (Week1)con.result.num);
            }
            
        }
        public static void getWeekDay(string day, bool mondayFirst)
        {
            Conversion con = new Conversion(day);
            if (con.result.status)
            {
                if (mondayFirst)
                {
                    //ak je pondelok prvy musime posunut cislo o jedno vpred, aby sme nezacinali s nedelou...
                    con.result++;

                   // string nieco = Week1(0);
                    Console.WriteLine("(Prvy den je pondelok) (Array) Den: {0}", Conversion.week[con.result.num]);
                    Console.WriteLine("(Prvy den je pondelok) (Enum) Den: {0}", (Week1)con.result.num);
                }
                else
                {

                    //staticke metody nemoze ani virtual ani override su ako su, ale mozeme ju zavolat
                    //tak neviem ci je to tako spravne pochopene....

                    dnyTydne.getWeekDay(day);
                }
               
            }
            
        }

        public static void getWeekDay(Conversion con)
        {
            //Conversion con = new Conversion(day);
            if (con.result.status)
            {
                Console.WriteLine("S objektom.... (Prvy den je nedela) (array) Den: {0}", Conversion.week[con.result.num]);
                Console.WriteLine("S objektom....(Prvy den je pondelok) (Enum) Den: {0}", (Week1)con.result.num);
            }
           
        }
        public static void getWeekDay(Conversion con, bool mondayFirst)
        {
            //Conversion con = new Conversion(day);
            if (con.result.status)
            {
                if (mondayFirst)
                {
                    con.result++;
                    Console.WriteLine(" S objektom.... (Prvy den je pondelok) (Array) Den: {0}", Conversion.week[con.result.num]);
                    Console.WriteLine(" S objektom....(Prvy den je pondelok) (Enum) Den: {0}", (Week1)con.result.num);
                }else
                {
                    dnyTydne.getWeekDay(con);
                }
            }
            
        }


    }
}
