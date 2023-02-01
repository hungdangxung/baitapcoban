using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
class Result
{
    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0, sumMin = 0, sumMax = 0;
        arr.Sort();
        for (int i = 0; i < arr.Count; i++)
        {
            sum += (long)arr[i];
        }
        sumMin = sum - arr[arr.Count - 1];
        sumMax = sum - arr[0];
        Console.Write(sumMin + " " + sumMax);
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.miniMaxSum(arr);
    }
}