using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Funktionen
{
    internal class myMath
    {
        public int calculateSpecificMode(CalcEnum mode, int number1, int number2)
        {
            switch (mode)
            {
                case CalcEnum.GGT:
                    return calc_ggt(number1, number2);
                case CalcEnum.KGV:
                    return calc_kgv(number1, number2);
                default: return 0;
            }
        }
        public int calc_ggt(int a, int b)
        {
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }
        public int calc_kgv(int a, int b)
        {
            int z = a * b / calc_ggt(a, b);
            return z;
        }
    }
}
