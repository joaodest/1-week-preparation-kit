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
    public static long CalculateMax(List<long> arr)
    {
        return arr.Sum() - arr[0];
    }

    public static long CalculateMin(List<long> arr)
    {
        return arr.Sum() - arr[arr.Count - 1];
    }

    public static void miniMaxSum(List<long> arr)
    {

        arr.Sort();

        long maxSum = CalculateMax(arr);
        long minSum = CalculateMin(arr);
        Console.WriteLine($"{minSum} {maxSum}");
    }
}

class Solution
    {
        public static void Main(string[] args)
        {

          

        List<long> arr = new List<long> { 1000000000, 2000000000, 3000000000, 4000000000, 5000000000, };
            Result.miniMaxSum(arr);
        }
    }

