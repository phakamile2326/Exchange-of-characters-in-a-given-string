﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_of_characters_in_a_given_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("a"));
            Console.WriteLine(test("xy"));
            Console.ReadLine();
        }
        public static string test(string str)
        {
            return str.Length >1
                ?str.Substring(str.Length -1) + str.Substring(1 , str.Length -2) + str.Substring(0,1) : str;
        }
    }
}
