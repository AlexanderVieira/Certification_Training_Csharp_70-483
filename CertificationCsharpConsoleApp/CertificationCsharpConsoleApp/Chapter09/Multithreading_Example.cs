using System;

namespace CertificationCsharpConsoleApp.Chapter09 {
	public class Multithreading_Example {
		public static void ImprimirX() {
			for (int i = 0; i < 1000; i++) {
				Console.Write("X");
			}
		}
	}
}
