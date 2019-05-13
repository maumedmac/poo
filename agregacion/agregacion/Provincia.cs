/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 06/05/2019
 * Hora: 19:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace agregacion
{
	/// <summary>
	/// Description of Provincia.
	/// </summary>
	public class Provincia
	{
		private string nomprovincia;
		public string Nomprovincia {
			get { return nomprovincia; }
			set { nomprovincia = value; }
		}
		
		private int poblacion;
		
		public int Poblacion {
			get { return poblacion; }
			set { poblacion = value; }
		}
		
		public Provincia(string nomprovincia,int poblacion)
		{
			this.nomprovincia=nomprovincia;
			this.poblacion=poblacion;
		}
	}
}
