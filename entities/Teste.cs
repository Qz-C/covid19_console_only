using System;

namespace Covid19
{
	
	public class Teste : Obito
	{
		//Dominios
		private bool infectado;
		
		//Propriedades
		public bool Infectado{
			get {
				return infectado;
			}
			set {
				infectado = value;
			}
		}
		
		public override void ler(){
			base.ler();
			Console.WriteLine("Infectado");
			infectado = Convert.ToBoolean(Console.ReadLine());
		}
	}
}
