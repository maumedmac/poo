/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 06/05/2019
 * Hora: 20:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System.Windows.Forms;
using System;

namespace agregacion
{
	/// <summary>
	/// Description of Pais.
	/// </summary>
	public class Pais
	{
		Departamento[] d = new Departamento[50];
		int nd=0;
		private string nompais;
		
		public string Nompais {
			get { return nompais; }
			set { nompais = value; }
		}
		public Pais(string nompais)
		{
			this.nompais=nompais;
		}
		public void agregarProvincias(int s)
		{
			for (int i = 0; i < s; i++) {
								
			}
		}
		public int poblacionpais()
		{
			if(nd>0)
			{
			int poblacionpais=0;
				for(int i=0;i<nd;i++)
				{
					poblacionpais+=d[i].poblaciond();
					
				}
				MessageBox.Show("LA Poblacion del departamento "+nompais+" es "+poblacionpais);
			}
			else
			{
				MessageBox.Show("No se a agregado ningun departamento");
			}
		}
		
		
	}
}
