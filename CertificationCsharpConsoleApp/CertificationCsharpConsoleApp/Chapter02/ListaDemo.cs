using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationCsharpConsoleApp.Chapter02 {
	public class ListaDemo {
		public void MinhaLista() {
			// Cria uma coleção que uma lista de string
			var nomes = new List<String>()
			{
				"Jose",
				"André",
				"Pedro",
				"Thiago"
			};

			foreach (var item in nomes) {
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
	}
}
