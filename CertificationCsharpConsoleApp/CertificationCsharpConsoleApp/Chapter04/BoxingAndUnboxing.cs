using System;

namespace CertificationCsharpConsoleApp.Chapter04 {
	public class BoxingAndUnboxing {
		public static void ImprimirExemploBoxingAndUnboxing() {
			object obj;
			int x = 35;
			obj = x;
			Console.WriteLine($"obj = {obj} | ocorreu um boxing aqui...");
			Console.WriteLine($"x = {x}");
			obj = 135;
			x = (int)obj;
			Console.WriteLine($"obj = {obj} ");
			Console.WriteLine($"x = {x} | ocorreu um unboxing aqui...");
		}
	}
}
