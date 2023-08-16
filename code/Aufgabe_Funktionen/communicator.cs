﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Funktionen
{
    internal class communicator
    {
        
        public int readInNumber()
        {
            do
            {
                Console.Write("Geben Sie eine Zahl ein: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Zahl ist ungültig.");
                }
            } while (true);
        }
        public void giveOutResult(string operation, int number1, int number2, int result)
        {
            Console.Clear();
            Console.WriteLine($"Das {operation} von {number1} und {number2} ist {result}.");
        }
    }
}
