using System;

class ejercicio_04a_11
{
	static void Main()
	{
		int[][] numeros = new int[2][];
		int maximo, tamanofila;
		
		for (int i = 0; i < numeros.Length; i++)
		{
			Console.Write("Dime el tamaño de la fila {0}: ", i+1);
			tamanofila = Convert.ToInt32(Console.ReadLine());
			numeros[i] = new int [tamanofila];
			Console.WriteLine("Dime los valores de los numeros");
			for(int j = 0; j < numeros[i].Length; j++)
			{
				numeros[i][j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		
		for(int i = 0; i < numeros.Length; i++)
		{
			maximo = numeros[i][0];
			for(int j = 1; j < numeros[i].Length; j++)
			{
				if (numeros[i][j] > maximo)
				{
					maximo = numeros[i][j];
				}
			}
			
			Console.WriteLine("El {0} es el maximo de la fila {1}", maximo, i);
		}
	}
}
