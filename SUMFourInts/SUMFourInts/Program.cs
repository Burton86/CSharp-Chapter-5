﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SUMFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            const int MAX = 4;
            string inputString;

            for (int i = 0; i < MAX; ++i)
                WriteLine("Enter a number>>>>");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum = sum + num;
        
            while (exit != 999)
            {

            }
            Write("The sume is " + sum);





        }
    } 
}
