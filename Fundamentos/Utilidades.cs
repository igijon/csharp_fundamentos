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
	}
}

