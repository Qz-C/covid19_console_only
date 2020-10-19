using System;

namespace Covid19
{
	public class Paciente
	{
			//Dominios
			 private string nome;
			 private string cpf;
			 private string estado;
			 private string cidade;
			 private string nascimento;
			 
			 //Propriedades
			 public string Nome {
			 	get {
			 		return nome;
			 	}
			 	set{
			 		nome=value;
			 	}
			 }
			 
			 public string Cpf {
			 	get {
			 		return cpf;
			 	}
			 	set{
			 		cpf=value;
			 	}
			 }
			 
			 public string Estado {
			 	get {
			 		return estado;
			 	}
			 	set{
			 		estado=value;
			 	}
			 }
			
			 public string Cidade {
			 	get {
			 		return cidade;
			 	}
			 	set{
			 		cidade=value;
			 	}
			 }
			
			 public string Nascimento {
			 	get {
			 		return nascimento;
			 	}
			 	set{
			 		nascimento=value;
			 	}
			 }
		
			//Métodos
	}
}
