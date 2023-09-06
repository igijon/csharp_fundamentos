using System;
namespace Fundamentos
{
	public class Utilidades
	{
		public struct contacto
		{
			public string nombre;
			public string apellidos;
			public string movil;
			public string email;
		};

		public static void intercambio(int a, int b)
		{
			int c;
			c = a; a = b; b = c;
		}

		public static void intercambioRef(ref int a, ref int b)
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

		public static void ordenar(int[] vector)
		{
			for(int i = 0; i < vector.Length; i++)
			{
				for(int j = 0; j < i; j++)
				{
					if (vector[j] > vector[i])
					{
						intercambioRef(ref vector[j], ref vector[i]);
					}
				}
			}
		}

		public static void inicializaVectorBidimensional(int[,] vectorBidi)
		{
			for(int i = 0; i < vectorBidi.GetLength(0); i++)
			{
				for(int j = 0; j < vectorBidi.GetLength(1); j++)
				{
					Console.Write("Introduce un número: ");
					vectorBidi[i, j] = int.Parse(Console.ReadLine());
				}
			}
		}

        public static void verVectorBidimensional(int[,] vectorBidi)
        {
            for (int i = 0; i < vectorBidi.GetLength(0); i++)
            {
                for (int j = 0; j < vectorBidi.GetLength(1); j++)
                {
                    Console.Write("{0} \t", vectorBidi[i,j]);
                }
				Console.WriteLine();
            }
        }

		public static void printVChars()
		{
			char[] letras = new char[] { 'h', 'o', 'l', 'a' };
			Console.WriteLine(letras);
		}

		public static void manageContacto()
		{
			contacto[] agenda = new contacto[100];
			contacto amigo = new contacto();
			amigo.nombre = "Luis";
			amigo.apellidos = "González Sánchez";
			amigo.email = "luisg@gmail.com";
			amigo.movil = "123456789";
			agenda[0] = amigo;
			Console.WriteLine(amigo.nombre + " " + amigo.apellidos);

		}
    }
}

