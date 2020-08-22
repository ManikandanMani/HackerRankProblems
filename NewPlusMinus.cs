//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace MyConsole
//{
//	class NewPlusMinus
//	{
//		static void Main(string[] args)
//		{
//			var n = Double.Parse(Console.ReadLine());
//			var a = Console.ReadLine().Split(' ').Select(val => Int32.Parse(val));

//			Console.WriteLine(string.Format("{0:N6}",a.Count(val => val > 0) / n));
//			Console.WriteLine(string.Format("{0:N6}",a.Count(val => val < 0) / n));
//			Console.WriteLine(string.Format("{0:N6}",a.Count(val => val == 0) /n));
//		}
//	}
//}
