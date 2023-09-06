using System;
namespace Fundamentos
{
	public class Utilidades
	{
		public static void intercambio(int a, int b)
		{
			int c;
			c = a; a = b; b = c;
		}

		public static void intercanmbioRef(ref int a, ref int b)
		{
            int c;
            c = a; a = b; b = c;
        }


		public static void printRandom()
		{
			Random n = new Random();
			Console.WriteLine("Números de la lotería primitiva");
			for(int i = 0; i < 6; i++)
			{
				Console.Write("{0} - ", n.Next(1, 46)); //Imprime valores entre 1 y 45 incluídos
			} //Pueden aparecer repetidos
		}

		public static int factorial(int n)
		{
			if (n > 1) { return n * factorial(n - 1); }
			else { return 1; }
		}

		//Construye un array con los "números ganadores" de la lotería
		public static int[] numLot()
		{
			int num;
			Random n = new Random();
			int[] nPremiados = new int[6];
			for(int i = 0; i < nPremiados.Length; i++)
			{
				do
				{
					num = n.Next(1, 46);

				} while (Array.IndexOf(nPremiados, num) >= 0);
				nPremiados[i] = num;
			}
			return nPremiados;
		}
	}
}

