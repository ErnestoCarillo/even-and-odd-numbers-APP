using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczby_parzyste_i_nie_parzyste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj piczbę a ja powiem czy jest ona parzysta czy nie parzysta");

            while (true)
            {
                int number = GetValue();

                if (number % 2 == 0)

                    Console.WriteLine("podałeś liczbę parzystą");
                else
                    Console.WriteLine("podałeś liczbę nie parzystą");

                Console.WriteLine("\n podaj kolejną liczbę.\n Jeżeli chcesz wyjśc wciśnij 't' ");
                




            }

        }

        private static int GetValue()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "T")
                    Environment.Exit(0);
                if (!int.TryParse(val, out int number ))
                {
                    Console.WriteLine("podałeś nie prawidłowe dane, spróbuj jeszcze raz");
                    continue;
                }
                return number;  
            }
        }
        


    }

}
