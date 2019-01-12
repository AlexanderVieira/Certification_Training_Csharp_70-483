using System;
using System.Text;

namespace CertificationCsharpConsoleApp.Chapter03 {
	public class StringBuilderExample {
		public static void ImprimirExemploStringBuilder() {
			string s1 = "Este é um exemplo de ";
			s1 += "concatenação de string";
			Console.WriteLine(s1);

			//Console.WriteLine("-----------------------");

			StringBuilder sb = new StringBuilder("Este é um exemplo de ");
			sb.Append("concatenação de string com StringBuilder");
			Console.WriteLine(sb);

			sb.AppendLine();
			sb.Append("Usando StringBuilder...");
			//Console.WriteLine(sb);

			sb.Replace("StringBuilder", "a classe StringBuilder");
			//Console.WriteLine(" ");
			//Console.WriteLine(" ");
			Console.WriteLine(sb);

		}
	}
}
