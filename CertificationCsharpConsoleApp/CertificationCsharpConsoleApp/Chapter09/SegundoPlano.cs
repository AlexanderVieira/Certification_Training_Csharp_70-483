using System;
using System.Threading;
using System.Threading.Tasks;

namespace CertificationCsharpConsoleApp.Chapter09 {
	class SegundoPlano {
		public static void Tarefa() {
			Task task = Task.Run(() => {
				for (int i = 0; i < 4; i++) {
					Thread.Sleep(500);
					Console.Write("SP ");
				}
			});
		}
	}
}
