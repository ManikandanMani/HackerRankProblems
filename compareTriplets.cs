//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Solution
//{

//    // Complete the compareTriplets function below.
//    static List<int> compareTriplets(List<int> a, List<int> b)
//    {
//        int valueForA = 0; int  valueForB = 0;
//        List<int> comparison = new List<int> { };

//        //int[] arr = new int[3];


//        for (int i = 0; i < a.Count; i++)
//		{

//			if (a[i] > b[i])
//			{

//                valueForA += 1;

//                //comparison.Add(valueForA);
//			}
//			else if(b[i]> a[i])
//			{

//                valueForB += 1;
//                //comparison.Add(valueForB);
//            }
//			//else if(a[i]==b[i])
//			//{
//   //             comparison
//			//}

//		}

//        //for (int i = 0; i < a.Count; i++)
//        //{


//        //          if

//        comparison.Add(valueForA);
//        comparison.Add(valueForB);
//        //}

//        return new List<int> { valueForA, valueForB };
//    }

//    static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp =>
//		{
//			return Convert.ToInt32(bTemp);
//		}).ToList();

//        List<int> result = compareTriplets(a, b);
//		Console.WriteLine(result[0].ToString()+"  "+result[1].ToString());
//        //textWriter.WriteLine(String.Join(" ", result));

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}

