using System;

namespace archivos
{
	class Principal
	{
		public static void Main (string[] args)
		{
			
			Archivo archivo = new Archivo("ejemplo.csv");
			archivo.leer();
			
			archivo.leer();
			
			//Observador observador = new Observador();
			//observador.inicia();
		}
	}
}

