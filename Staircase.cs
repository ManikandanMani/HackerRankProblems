using System;
using System.Text;

class StaircaseProblem
{
    // https://www.hackerrank.com/challenges/staircase/problem

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i <=n; i++)
		{
			// solution 1
			StringBuilder str = new StringBuilder(String.Empty);
			str.Append(' ', n - i);
			str.Append('#', i);
			Console.WriteLine(str);

			// solution 2
			//Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));

		}
		//Staircase(n);
	}
}
