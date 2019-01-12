using CertificationCsharpConsoleApp.Chapter01;
using CertificationCsharpConsoleApp.Chapter02;
using CertificationCsharpConsoleApp.Chapter03;
using CertificationCsharpConsoleApp.Chapter04;
using CertificationCsharpConsoleApp.Chapter09;
using System;
using System.Threading;

namespace CertificationCsharpConsoleApp {
	class Program {
		static void Main(string[] args) {
			/*
			 * Capítulo 01 - diga olá
			 */

			var digaOla = new DigaOla();
			digaOla.DizerOla();

			/*
			 * Capítulo 02 - Classes e Objetos
			 */

			// Exemplo de Classe
			var empregado = new Empregado() {
				Nome = "Jose",
				SobreNome = "Carlos"
			};

			Console.WriteLine(
				"Nome: {0} {1} | {2}",
				empregado.Nome,
				empregado.SobreNome,
				empregado.Promover());

			// Exemplo de Array
			var numeros = new ArraysDemo();
			numeros.ArrayInteiros();
			Console.WriteLine();

			// Exemplo de Lista
			var nomes = new ListaDemo();
			nomes.MinhaLista();
			Console.WriteLine();

			// Tratando exceções
			var excecao = new TratandoExcecao();
			excecao.DivisaoPorZero();
			Console.WriteLine();

			/**
			 * Capítulo 09 - 
			 * Exemplo de Multithreading - ThreadPool - Async e Await
			 * Cria uma nova threading que executa o método ImprimirX
			 */
			Thread thread = new Thread(Multithreading_Example.ImprimirX);
			thread.Start();

			// Executa a threading principal
			for (int i = 0; i < 1000; i++) {
				Console.Write("O");
			}

			/**
			 * Exemplo de ThreadPool
			 * Cria uma nova threading em primeiro plano que executa o método Contar
			 */
			Console.WriteLine();
			Thread t = new Thread(PrimeiroPlano.Contar);
			t.Start();

			// Cria uma nova threading em segundo plano que executa uma tarefa
			SegundoPlano.Tarefa();

			// Imprime exemplos de concatenação usando a classe StringBuilder
			Console.WriteLine();
			StringBuilderExample.ImprimirExemploStringBuilder();
			//Console.WriteLine();

			// Imprime exemplos de Boxing e Unboxing
			BoxingAndUnboxing.ImprimirExemploBoxingAndUnboxing();
			Console.WriteLine();
		}
	}
}
