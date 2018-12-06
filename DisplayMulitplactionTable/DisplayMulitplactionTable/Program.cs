using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMulitplactionTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=10; i++)
            {
                
                for (int j=0; j<=10; j++)
                {
                    if (i == 0)
                    {
                        WriteLine(i);
                    }
                    else
                        WriteLine(i * j);
                }
                WriteLine();

            }
            ReadLine();
            
        }
    }
}
