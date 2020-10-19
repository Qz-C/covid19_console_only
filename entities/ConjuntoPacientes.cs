using System;
using System.Collections.Generic;
using System.Collections;

namespace Covid19
{
	public class ConjuntoPacientes
	{
		private List<Paciente> listPacientes;
		
		//Contrutor
		public ConjuntoPacientes()
		{
			listPacientes = new List<Paciente>();
		}
		
		public int Tamanho{
			get{
				return listPacientes.Count;
			}
		}
		
		//Métodos
		public void inserirPaciente(Paciente p)
		{
			listPacientes.Add(p);
		}
		
		public Paciente ObterPaciente (string cpf)
		{
			foreach ( Paciente p in listPacientes )
				if( p.Cpf == cpf )
					return p;
				return null;
		}
		
		public void RemoverPaciente(string cpf)
		{
			Paciente p = ObterPaciente(cpf);
			if(p != null)
			{
				listPacientes.Remove(p);
			}
		}
		
		public void AlterarPaciente(string cpf, Paciente p)
		{
			RemoverPaciente(cpf);
			inserirPaciente(p);
		}
		
		public Paciente ObterPacientePos( int pos)
		{
			return listPacientes[pos];
		}
	}

}