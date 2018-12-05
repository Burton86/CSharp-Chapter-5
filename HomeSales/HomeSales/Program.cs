using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double DanielleTotal = 0;
            double EdwardTotal = 0;
            double FrancisTotal = 0;
            String input = null;
            

            while (input != "Z" || "z" != input )
            {
                WriteLine("Enter salespersons initial");
                input = ReadLine();
                if ("F" == input || "f" == input)
                {
                    double SalesofHomes = 0;
                    FrancisTotal = SalesofHomes + FrancisTotal;
                    WriteLine(FrancisTotal);
                }
                else if ("E" == input || "e" == input)
                {
                    double SalesofHomes = 0;
                    EdwardTotal = SalesofHomes + EdwardTotal;
                    WriteLine(EdwardTotal);
                }
                else if ("D" == input || "d" == input)
                {
                    double SalesofHomes = 0;
                    DanielleTotal = SalesofHomes + DanielleTotal;
                    WriteLine(DanielleTotal);
                }
            }      
            


        }
    }
}
