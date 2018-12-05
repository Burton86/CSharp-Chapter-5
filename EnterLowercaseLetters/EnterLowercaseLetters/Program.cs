using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string letterString;
            WriteLine("Enter A lowercase letter");
            letterString = ReadLine();
            letter = Convert.ToChar(letterString);


            if (letter >= 'a' && letter <= 'z')
            {
                WriteLine(letter + " is an accepted letter");
            }
            else
                WriteLine("ERROR!!!");
            




        }
    }
}
