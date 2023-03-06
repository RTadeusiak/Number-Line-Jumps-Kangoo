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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // Sprawdzenie, czy drugi kangur znajduje się przed pierwszym kangurem na początku
        if (x2 > x1 && v2 > v1)
        {
            return "NO";
        }

        // Symulacja skoków kangurów
        int pos1 = x1, pos2 = x2;
        while (pos1 != pos2)
        {
            pos1 += v1;
            pos2 += v2;

            // Sprawdzenie, czy kangury wykonają taki sam skok i znajdą się na tej samej pozycji
            if (pos1 == pos2)
            {
                return "YES";
            }

            // Sprawdzenie, czy drugi kangur znajduje się przed pierwszym kangurem
            if (pos2 < pos1)
            {
                return "NO";
            }
        }

        return "YES";
    }
    public static string kangaroo1(int x1, int v1, int x2, int v2)
    {
        if (v2 >= v1 && x2 > x1)
        {
            return "NO";
        }

        int pos1 = x1, pos2 = x2;
        while (pos1 < pos2)
        {
            pos1 += v1;
            pos2 += v2;
        }
        return pos1 == pos2 ? "YES" : "NO";
    }


}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);
        string result1 = Result.kangaroo1(x1, v1, x2, v2);
        Console.WriteLine(result);
        Console.WriteLine(result1);
    }
}
