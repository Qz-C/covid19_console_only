using System;

namespace Covid19
{
	public class Obito
	{
		//Dominios
		private string cpf;
		private string data;
		
		//Propriedades
		public string CpfPaciente{
			get { 
				return cpf;
			}
			set {
				cpf=value;
			}
		}
		
			public string Data{
			get { 
				return data;
			}
			set {
				data=value;
			}
		}
		
		//Métodos
		public virtual void ler(){
			Console.WriteLine("cpf");
			cpf = Console.ReadLine();
			Console.WriteLine("data");
			data = Console.ReadLine();
		}
	}

}
