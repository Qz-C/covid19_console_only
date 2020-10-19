using System;

namespace Covid19
{
	public class UserInterface
	{
		
		public void lerPaciente(Paciente p)
		{
			Console.Write("Nome:");
			p.Nome = Console.ReadLine();
			Console.Write("cpf:");
			p.Cpf = Console.ReadLine();
			Console.Write("data de nascimento:");
			p.Nascimento = Console.ReadLine();
			Console.Write("cidade:");
			p.Cidade = Console.ReadLine();
			Console.Write("estado:");
			p.Estado = Console.ReadLine();
			
		}
		
		public void ler(ConjuntoPacientes v)
		{
			int qtd, i;
			do{
				Console.WriteLine("Entre com a quantidade de pacientes");
				qtd = Convert.ToInt32(Console.ReadLine());
			}while(qtd < 0 || qtd > 100);
			for(i=0; i<qtd; i++)
			{
				Paciente p = new Paciente();
				lerPaciente(p);
				v.inserirPaciente(p);
			}	
		}
		
		//public void listar(ConjuntoPacientes v){
		//	foreach( Paciente p in v )
		//		Console.WriteLine("{0} {1} {2} {3} {4}", p.Nome, p.Cpf, p.Cidade, p.Estado, p.Nascimento);
		public void listar( ConjuntoPacientes v ){
			
			Paciente p = new Paciente();
			for( int i = 0; i < v.Tamanho; i++ )
			{
				p = v.ObterPacientePos(i);
				Console.WriteLine( "{0} {1} {2} {3} {4}", p.Nome, p.Cpf, p.Nascimento, p.Cidade, p.Estado );
			}
		}
	}
}
