using System;
using System.IO;

namespace Covid19
{
	public class ArquivoPacientes
	{
		private string _nome;
		private ConjuntoPacientes _list;
		
		public ArquivoPacientes(string nome, ConjuntoPacientes list)
		{
			_nome = nome;
			_list = list;
		}
		
		public void ler()
		{
			using (FileStream fs = new FileStream(_nome, FileMode.Open, FileAccess.Read))
			{
				using ( StreamReader sr = new StreamReader(fs) )
				{	
					string linha;
					while ( (linha = sr.ReadLine() ) != null )
						if(linha.Trim().Length>0)
						{
							string []v = linha.Split(',');
							
							Paciente p = new Paciente();
							
							p.Nome = v[0];
							p.Cpf = v[1];
							p.Nascimento = v[2];
							p.Cidade = v[3];
							p.Estado = v[4];
						}
				}
			}
		}
		
		public void escrever()
		{
			using (FileStream fs = new FileStream(_nome, FileMode.Create, FileAccess.Write))
			{
				using ( StreamWriter sw = new StreamWriter(fs) )
				{
					Paciente p = new Paciente();
					for( int i = 0; i < _list.Tamanho; i++ )
					{
						p = _list.ObterPacientePos(i);
						sw.WriteLine("{0},{1},{2},{3},{4}", p.Nome, p.Cpf, p.Nascimento, p.Cidade, p.Estado );
					}
				}
			}
		}
	}
}
