using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int TEST = 0;
            string TESTString;
            int average = 0;
            int ScoreNumber = 0;
            const int Max = 100;
            const int Min = 0;
            int Total = 0;
            
            while(TEST != 999)
            {
                WriteLine("Please enter your test score or Enter 999 to exit the program>>>>");
                TESTString = ReadLine();
                TEST = Convert.ToInt32(TESTString);
                if (TEST < Max && TEST > Min)
                {
                    Total = Total + TEST;
                    ScoreNumber++;
                }
                else if (TEST == 999)
                {
                    average = Total / ScoreNumber;
                    Write("The average is " + average + " out of " + ScoreNumber + " Scores");

                }
            }
            



        }
    }
}
