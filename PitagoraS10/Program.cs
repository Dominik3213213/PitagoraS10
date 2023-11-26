using System;
class Pitagoras
{
	static void Main(string[] args)
	{
		double a, b, c;
		Console.WriteLine("Podaj A");
		a = double.Parse(Console.ReadLine());
		Console.WriteLine("Podaj B");
		b = double.Parse(Console.ReadLine());
		c = (a * a + b * b);
		Console.WriteLine("C wynosi : {0}", c);
		c = Math.Sqrt(a * a + b * b);
		Console.WriteLine("Pierwiastek z C wynosi: {0}", c);
		Console.ReadLine();

	}
}