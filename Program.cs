﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum10nnm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum=0;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine("sum is{0}", sum);
            Console.ReadLine();

        }
    }
}
