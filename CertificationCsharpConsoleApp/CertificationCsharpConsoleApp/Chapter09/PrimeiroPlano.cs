using System;
using System.Threading;

namespace CertificationCsharpConsoleApp.Chapter09 {
	public class PrimeiroPlano {
		public static void Contar() {
			for (int i = 0; i < 4; i++) {
				Thread.Sleep(500);
				Console.Write("PP ");
			}
		}
	}
}
