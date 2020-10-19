using System;

namespace Covid19
{
	public class ConjuntoObitos{
		private int qtd;
		private Obito []v = new Obito[100];
		
		public void ler(){
			do{
				Console.WriteLine("Entre com a quantidade de Obitos");
				qtd = Convert.ToInt32(Console.ReadLine());
			}while(qtd < 0 || qtd > 100);
			for(int i=0; i<qtd; i++)
			{
				v[i] = new Obito();
				v[i].ler();
			}
			
		}
		
		public void listar(){
			for(int i=0; i < qtd; i++)
			{
				Console.WriteLine("{0} {1}", v[i].CpfPaciente, v[i].Data);
			}
		}
	}

}