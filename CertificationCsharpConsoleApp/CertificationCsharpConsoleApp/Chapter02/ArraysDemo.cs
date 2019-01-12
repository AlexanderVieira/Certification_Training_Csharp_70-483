using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationCsharpConsoleApp.Chapter02 {
	public class ArraysDemo {
		public void ArrayInteiros() {
			// Cria uma coleção que é um array
			var numbers = new int[] { -1, 0, 1, 2, 3, 4, 5, 6 };
			foreach (var item in numbers) {
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
	}
}
