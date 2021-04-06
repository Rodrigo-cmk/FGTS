using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {









            Double sal;
            Double Resul;

            Console.WriteLine();
            Console.WriteLine("     FGTS");
            Console.WriteLine();
            Console.WriteLine("--> Digite o valor a ser calculado.");

            sal = Convert.ToDouble (Console.ReadLine());

            Resul = (sal*8) / 100;

            Console.WriteLine();
            Console.WriteLine($"Salário: {sal:C2}");
            Console.WriteLine($"FGTS: {Resul:C2}");

















        }
    }
}
