//using System.Collections.Generic;
//using System.Linq;
//using System;

//class Result
//{

//	/*
//	 * Complete the 'diagonalDifference' function below.
//	 *
//	 * The function is expected to return an INTEGER.
//	 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
//	 */

//	public static int DiagonalDifference(List<List<int>> arr)
//	{
//		/*int diagonalDifference = 0;*/
//		int leftdiagonal = 0; int rightdiagonal = 0;


//		for (int i = 0; i < arr.Count; i++)
//		{
//			//         for (int j = 0; j < arr.Count; j++)
//			//{

//			if (arr[index: i][index: i] == arr[index: i][i])
//			{
//				leftdiagonal += arr[i][i];
//				//rightdiagonal += arr[i++, j -].ToString();
//			}
//			//             if( i+j ==arr.Count-1 )
//			//	{
//			//                 //var a = arr.Equals(i + j == 2);
//			//                 //rightdiagonal += arr.Find(arr[i+j])  ;
//			//                 rightdiagonal += arr[i][j];


//			//             }

//			//         }

//			leftdiagonal += arr[index: i][index: i];

//			rightdiagonal += arr[index: i][index: arr.Count - i - 1];

//		}


//		return Math.Abs(rightdiagonal - leftdiagonal);

//	}

//}
//class Solution
//{
//	public static void Main(string[] args)
//	{

//		int n = Convert.ToInt32(Console.ReadLine().Trim());

//		List<List<int>> arr = new List<List<int>>();

//		for (int i = 0; i < n; i++)
//		{
//			arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());

//		}
//		int result = Result.DiagonalDifference(arr);
//		Console.WriteLine(result);

//	}
//}
