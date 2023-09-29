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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static double CalcPercentage(int element, int length)
    {
        return (double)element / length;
    }

    public static List<double> plusMinus(List<int> arr)
    {
        int posiItems = 0;
        int negItems = 0;
        int zeroItems = 0;
        var length = arr.Count;

        foreach (int i in arr)
        {
            if (i > 0)
            {
                posiItems++;
            }
            else if (i < 0)
            {
                negItems++;
            }
            else
            {
                zeroItems++;
            }
        }

        double posiRatio = CalcPercentage(posiItems, length);
        double negRatio = CalcPercentage(negItems, length);
        double zeroRatio = CalcPercentage(zeroItems, length);

        return new List<double>
        {
            posiRatio,
            negRatio,
            zeroRatio
        };
    }



}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> input = new List<int> { 1, 1, 0, -1, -1 };
        List<double> output = Result.plusMinus(input);


        foreach (var item in output)
        {
            Console.WriteLine(item.ToString("F6"));
        }
    }
}
