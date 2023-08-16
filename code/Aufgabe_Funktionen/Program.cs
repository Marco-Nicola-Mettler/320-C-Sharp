namespace Aufgabe_Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            myMath math = new myMath();
            communicator com = new communicator();
            int number1 = com.readInNumber();
            int number2 = com.readInNumber();
            com.giveOutResult("ggt", number1, number2, math.calc_ggt(number1, number2));
        }
    }
}