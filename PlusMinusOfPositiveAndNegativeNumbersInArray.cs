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
//using System.Runtime.InteropServices;
///// <summary>
///// https://www.hackerrank.com/challenges/plus-minus/problem?h_r=next-challenge&h_v=zen
///// </summary>
//class Solution
//{

//    // Complete the plusMinus function below.
//    static List<string> PlusMinus(int[] arr)
//    {
//        int positiveNumber = 0; int negativeNumber = 0; int ZeroNumber = 0;
//		decimal positiveResult = 0.0m;decimal negativeResult = 0.0m;decimal zeroResult = 0.0m; 
//		decimal finalResult = 0.0m;

//		for (int i = 0; i < arr.Length; i++)
//		{
//			if (arr[i] > 0)
//			{
//                positiveNumber ++;
//			}
//			if (arr[i]== 0)
//			{
//                ZeroNumber++;
//			}
//			if (arr[i] < 0)
//			{
//				negativeNumber++;
//			}

//		}
//		//result = Marshal.SizeOf(positiveNumber);
//		positiveResult = positiveNumber;
//		negativeResult = negativeNumber;
//		zeroResult = ZeroNumber;
//		finalResult = arr.Length;
//		positiveResult /= finalResult;
//		negativeResult /= finalResult;
//		zeroResult /= finalResult;
//		//string positiveNumberValue=string.Format("{0:0.0#}", positiveNumber);
//		//Console.WriteLine($"{positiveResult/arr.Length} {negativeResult/arr.Length} {zeroResult/arr.Length}");

//		//string v = $"{positiveResult / finalResult} {negativeResult / finalResult} {zeroResult / finalResult}";
//		//return new List<string> { String.Format("{0:0.00000#}",positiveResult),String.Format("{0:0.00000#}",negativeResult),String.Format("{0:0.00000#}",zeroResult)};
//		return new List<string> { String.Format("{0:N6}", positiveResult),String.Format("{0:N6}", negativeResult),String.Format("{0:N6}", zeroResult)};

//	}

//	static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp =>
//		{
//			return Convert.ToInt32(arrTemp);
//		})
//        ;
//         var result=PlusMinus(arr);
//		Console.WriteLine(result[0]+"\n"+result[1]+"\n"+result[2]);
//    }
//}
