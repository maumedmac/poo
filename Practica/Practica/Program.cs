/*
 * Realizarun programa que permita introducir 2 números,  presionar una tecla puede ser: 1,2,3, 4
 * y realice la operación de la tecla señalada:
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Introduce la opcion->");
			Console.WriteLine("1.Áreay perímetro  de un rectángulo");
			Console.WriteLine("2.Área y perímetro  de un triangulo");
			Console.WriteLine("3.Área y perímetro  de un circulo");
			Console.WriteLine("4.Área y perímetrode un cuadrado");
            int n=int.Parse(Console.ReadLine());
           
            switch(n%4)
            {
            	case 1:
            		Console.WriteLine("Introuce la base->");
            		int b=int.Parse(Console.ReadLine());
            		Console.WriteLine("Introduce la altura->");
            		int h=int.Parse(Console.ReadLine());
            		Console.WriteLine("El area es "+(b*h)+" y el perimetro es "+(2*b+2*h));
            		break;
            	case 2:
            		Console.WriteLine("Introuce la base->");
            		b=int.Parse(Console.ReadLine());
            		Console.WriteLine("Introduce la altura->");
            		h=int.Parse(Console.ReadLine());
            		Console.WriteLine("El area es "+((b*h)/2)+" y el perimetro es "+3*(Math.Sqrt(b*b+h*h)));
            		break;
            	case 3:
            		Console.WriteLine("Introuce el radio->");
            		b=int.Parse(Console.ReadLine());
            		Console.WriteLine("El area es "+(b*b*Math.PI)+" y el perimetro es "+(2*Math.PI*b));
            		break;
            	case 0:
            		Console.WriteLine("Introuce el lado->");
            		b=int.Parse(Console.ReadLine());
            		Console.WriteLine("El area es "+(b*b)+" y el perimetro es "+(4*b));
            		break;
            }

			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}