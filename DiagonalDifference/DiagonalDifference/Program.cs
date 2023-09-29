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

    public static int diagonalDifference(List<List<int>> arr)
    {
        int mainDiag = 0;
        int secDiag = 0;
        int matOrder = arr[0][0];

        for (int i = 1; i <= matOrder; i++)
        {

            for (int j = 0; j < matOrder; j++)
            {
                if (i - j == 1)
                {
                    mainDiag += arr[i][j];
                }

                if (i + j == matOrder)
                {
                    secDiag += arr[i][j];
                }
            }
        }

        int diagDiff = mainDiag - secDiag;

        diagDiff = diagDiff < 0
            ? diagDiff * (-1)
            : diagDiff;


        return diagDiff;
    }



    class Solution
    {
        public static void Main(string[] args)
        {


            List<List<int>> arr = new List<List<int>>
        {
            new List<int>{ 3 },
            new List<int>{ 11, 2, 4 },
                new List<int>{ 4, 5, 6 },
                new List<int>{ 10, 8, -12 },
        };


            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}

