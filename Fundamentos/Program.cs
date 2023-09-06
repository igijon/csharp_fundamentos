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
Utilidades.intercambioRef(ref x, ref y);
Console.WriteLine(" de Intercambiar por Referencia: x: {0} y: {1}", x, y);

Console.WriteLine("Números aleatorios: ");
Utilidades.printRandom();
Console.WriteLine();

Console.WriteLine("Factorial de {0}: es: {1} ", x, Utilidades.factorial(x));

Console.WriteLine("Ganadores lotería: ");
int[] numLot = Utilidades.numLot();
for (int i = 0; i < numLot.Length; i++)
    Console.Write(numLot[i] + " ");
Console.WriteLine();

Utilidades.ordenar(numLot);
for (int i = 0; i < numLot.Length; i++)
    Console.Write(numLot[i] + " ");
Console.WriteLine();

int[,] vectorBidi = new int[3, 5];
Utilidades.inicializaVectorBidimensional(vectorBidi);
Utilidades.verVectorBidimensional(vectorBidi);
Console.WriteLine();
Utilidades.printVChars();


string cadena = "hola mundo";
Console.WriteLine(cadena[3]);
//No permitido cadena[3]='A'

char[] letras = new char[] { 'h', 'o', 'l', 'a' };
string saludo = new string(letras);
Console.WriteLine(saludo);

Console.ReadKey(); //Detenemos la consola hasta que el usuario pulsa una tecla