using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace ConsoleApp4 {

	class Comparer : IComparer {
		int IComparer.Compare(object x, object y) {
			int xi = (int)x;
			int yi = (int)y;
			if (xi > yi) return -1;
			else if (xi < yi) return 1;
			else return 0;
		}
	}

	class Program {

		static void Main(string[] args) {
			List<int> a = new List<int>(new int[] { 5, 1, 7, 3, 9 });
			List<int> b = new List<int>(new int[] { 0, 1, 2, 3, 4 });
			int[] arr = a.ToArray();
			int[] brr = b.ToArray();
			Array.Sort(arr, brr, new Comparer());
			a = new List<int>(arr);
			b = new List<int>(brr);
			for (int i = 0; i < a.Count; ++i)
				Console.Write($"{a[i]} ");
			Console.WriteLine();
			for (int i = 0; i < b.Count; ++i)
				Console.Write($"{b[i]} ");
			Console.WriteLine();

		}

		
	}
}
