/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 22/04/2019
 * Hora: 19:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Examen
{
	/// <summary>
	/// Description of Cuenta.
	/// </summary>
	public class Cuenta
	{
		
		public Cuenta(string t,double c)
		{
			this.titular=t;
			this.cantidad=c;
		}
		public Cuenta(string t)
		{
			this.titular=t;
			this.cantidad=0.0;
		}
		
		private double cantidad;
			
		public double Cantidad  {
			get { return cantidad; }
			set { cantidad = value; }
		}
	    private String titular;
		
		public String Titular {
			get { return titular; }
			set { titular = value; }
		}
	    public void ingresar(double c)
	   	{
	    	cantidad+=c;
	    	
	    }
	    public void retirar(double c)
	   	{
	    	cantidad-=c;
	    }
	    	
	}
}
