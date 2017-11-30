using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /*Nadefinujeme si struct a nasledne aj spravenie sa operatora ++ a --
     * aby sme to nemuseli riesit tak ked je vacsie alebo rovne ako 7 dame na nulu, kvoli pevne definovanemu polu 
     * tyzdna
     * 
     * Ten status mame uz ready a vieme ze sa nieco posahalo....
     * 
     * 
     */

    public struct myResult
    {
        public bool status;
        public int num;

        public static myResult operator ++(myResult res)
        {
            res.num++;
            if (res.num >= 7)
            {
                res.num = 0;
            }
            return res;
        }

        public static myResult operator --(myResult res)
        {
            res.num--;
            if (res.num <= 0)
            {
                res.num = 7;
            }

            return res;
        }

    }
}
