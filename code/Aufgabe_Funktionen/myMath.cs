using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Funktionen
{
    internal class myMath
    {
        communicator com = new communicator();
        public int calculateSpecificMode(CalcEnum mode)
        {
            switch (mode)
            {
                case CalcEnum.GGT:
                    return calc_ggt();
                case CalcEnum.KGV:
                    return calc_kgv();
                default: return 0;
            }
        }
        public int calc_ggt()
        {
            int a = com.readInNumber();
            int b = com.readInNumber();
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
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
        public int calc_kgv()
        {
            int a = com.readInNumber();
            int b = com.readInNumber();
            int z = a * b / calc_ggt(a, b);
            return z;
        }
    }
}
