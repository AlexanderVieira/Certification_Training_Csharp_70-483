using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificationCsharpConsoleApp.Chapter02 {
	public class Empregado {
		public String Nome { get; set; }
		public String SobreNome { get; set; }
		public int Prioridade { get; set; }

		public String Promover() {
			return "Empregado promovido...";
		}

		public String RevisaoAnual() {
			return "Revisão anual completada...";
		}
	}
}
