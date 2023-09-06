using Fundamentos;

int x = 10, y = 4;
Console.WriteLine("x: {0} e y: {1}", x, y);
Console.WriteLine("x: "+ x +" e y: "+ y);

Console.WriteLine("Introduce un valor: ");
x = int.Parse(Console.ReadLine()); //Conversión explícita que si no recibe un entero fallará
Console.WriteLine("x: {0}", x);

Console.WriteLine("Antes de Intercambiar por Valor: x: {0} y: {1}", x, y);
Utilidades.intercambio(x, y);
Console.WriteLine("Después de Intercambiar por Valor: x: {0} y: {1}", x, y);
Utilidades.intercanmbioRef(ref x, ref y);
Console.WriteLine(" de Intercambiar por Referencia: x: {0} y: {1}", x, y);

Console.WriteLine("Números aleatorios: ");
Utilidades.printRandom();
Console.ReadKey(); //Detenemos la consola hasta que el usuario pulsa una tecla