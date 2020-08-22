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

//namespace MyConsole
//{
//	public class MinimumAndMaximumSumOfArray
//	{

//		// Complete the miniMaxSum function below.

//		static void Main(string[] args)
//		{
//			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),
//						arrTemp => Convert.ToInt32(arrTemp));
//			// int32 =int ;
//			//int64 =long;


//			Int64 maxSum = 0; long minSum = 0;
//			var max = arr.Max();
//			var min = arr.Min();
//			for (int i = 0; i < arr.Length; i++)
//			{
//				if (max == min)
//				{
//					minSum += arr.Length;
//					maxSum += arr.Length;
//				}
//				else
//				{
//					minSum += arr[i];
//					maxSum += arr[i];
//				}
//			}

//			Console.WriteLine(value: $"{minSum - max}\t{maxSum - min}");


//		}
//	}
//}
