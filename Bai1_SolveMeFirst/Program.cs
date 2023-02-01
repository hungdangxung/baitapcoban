﻿using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int solveMeFirst(int a, int b)
    {
        // Hint: Type return a+b; below 
        if (((1 <= a) && (a <= 1000)) && ((1 <= b) && (b <= 1000)))
        {
            return a + b;
        }
        else
        {
            return 0;
        }
    }
    static void Main(String[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine(sum);
    }
}