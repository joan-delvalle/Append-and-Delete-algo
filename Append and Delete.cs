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
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     *  3. INTEGER k
     */

    public static string appendAndDelete(string s, string t, int k)
    {
        int commonLength = 0;

   
    for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
    {
        if (s[i] == t[i])
            commonLength++;
        else
            break;
    }

    int totalOps = (s.Length - commonLength) + (t.Length - commonLength);

    if (totalOps == k || (totalOps < k && (k - totalOps) % 2 == 0) || k >= s.Length + t.Length)
        return "Yes";
    else
        return "No";
    }

    }
      
class Solution
{
    public static void Main(string[] args)
    {
  string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        Console.WriteLine(result);
    }
}
        
