using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Conversion : iTool
    {

        public myResult result;
        public string msg = "";

        const int _MIN = 0;
        const int _MAX = 6;

        public static string[] week = new string[] { "Nedela","Pondelok","Utorok","Streda","Stvrtok","Piatok","Sobota" };

        public enum Week1 {Nedela, Pondelok, Utorok,Streda,Stvrtok, Piatok, Sobota};

        

        /*public Conversion()
        {

        }*/

        public Conversion(string day)
        {
            this.result = this.convertToInt(day);

            if (this.result.status == false)
            {
                throw new Exception("Nie je cislo");
                //return;
            }

            if (this.result.num < _MIN || this.result.num > _MAX)
            {
                this.result.status = false;
                throw new Exception("nie je v rozsahu 0...6");
                //return;
            }


        }

        public myResult convertToInt(string num)
        {
            myResult result = new myResult();

            result.status = false;
            result.num = 0;

            result.status = int.TryParse(num, out result.num);

            return result;
        }

    }
}
