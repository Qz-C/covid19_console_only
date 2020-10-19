using System;

namespace Covid19
{
	public class ConjuntoTestes
	{
		private int qtd;
		private Teste []v = new Teste[100];
		
		public void ler(){
			do{
				Console.WriteLine("Entre com a quantidade de Testes");
				qtd = Convert.ToInt32(Console.ReadLine());
			}while(qtd < 0 || qtd > 100);
			for(int i=0; i<qtd; i++)
			{
				v[i] = new Teste();
				v[i].ler();
			}
			
		}
		
		public void listar(){
			for(int i=0; i < qtd; i++)
			{
				Console.WriteLine("{0} {1} {2}", v[i].CpfPaciente, v[i].Data, v[i].Infectado);
			}
		}
	}
}