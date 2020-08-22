//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//public class Solution
//{

//    /*
//     * Complete the simpleArraySum function below.
//     */
//    static int simpleArraySum(int[] ar)
//    {
//        /*
//         * Write your code here.
//         */

//        int total=0;
//        int sum = 0;

//		foreach (int item in ar )
//		{
//            sum = ar[item];
//            total += sum;

//		}
//        // usage of for loop passes , for each fails.


//        return total;
//    }

//	public  static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int arCount = Convert.ToInt32(Console.ReadLine());

//        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//        ;
//        int result = simpleArraySum(ar);

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();
//    }
//}

