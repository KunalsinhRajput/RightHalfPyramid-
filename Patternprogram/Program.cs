﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*output of this program is 
         *
         **
         ***
         ****
         ******/
namespace Patternprogram
{
     class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
         
    }
}
