using System;

namespace Covid19
{
	class Program
	{
		public static void Main(String []args)
		{
			ConjuntoPacientes p = new ConjuntoPacientes();
			UserInterface UI = new UserInterface();
			ConjuntoTestes t = new ConjuntoTestes();
			ConjuntoObitos o = new ConjuntoObitos();
			
			UI.ler(p);
			UI.listar(p);
			
			t.ler();
			t.listar();
			o.ler();
			o.listar();
			
			Console.ReadKey(true);
		}
	}
}