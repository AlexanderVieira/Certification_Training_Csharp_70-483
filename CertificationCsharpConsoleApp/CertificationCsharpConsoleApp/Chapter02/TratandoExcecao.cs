using System;

namespace CertificationCsharpConsoleApp.Chapter02 {
	public class TratandoExcecao {
		public int x = 3;
		public int y = 0;
		public void DivisaoPorZero() {
			// lança uma exceção divisão por zero
			//Console.WriteLine(" x = {x} divido por y = {y}" + (x / y));			

			// Bloco catch que trata a execeção lançada
			try {
				Console.WriteLine(" x divido por y: " + (x / y) + "\n");
			}
			catch (DivideByZeroException ex) {
				Console.WriteLine("O seguinte erro ocorreu: " + ex.Message + "\n");
			}
			finally {
				Console.WriteLine("Todo código implementado aqui é executado..." + "\n");
			}

			// Bloco catch que trata um execeção sem lançá-la
			try {
				Console.WriteLine(" x divido por y: " + (x / y) + "\n");
			}
			catch {
				Console.WriteLine("Ocorreu um erro!!!" + "\n");
			}
			finally {
				Console.WriteLine("Todo código implementado aqui é executado..." + "\n");
			}
		}
	}
}
