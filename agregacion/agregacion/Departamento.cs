/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 06/05/2019
 * Hora: 20:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;

namespace agregacion
{
	/// <summary>
	/// Description of Departamento.
	/// </summary>
	public class Departamento
	{
		Provincia[] p = new Provincia[50];
		int np=0;
		private string nomdepartamento;
		
		public string Nomdepartamento {
			get { return nomdepartamento; }
			set { nomdepartamento = value; }
		}
		public Departamento(string nomdepartamento)
		{
			this.nomdepartamento=nomdepartamento;
		}
		public void agregarProvincias(int s)
		{
			for (int i = 0; i < s; i++) {
				
			}
		}
		public void poblaciondepar()
		{
			if(np>0)
			{
			int poblaciondepartamento=0;
				for(int i=0;i<np;i++)
				{
					poblaciondepartamento+=p[i].Poblacion;	
				}
				MessageBox.Show("LA Poblacion del departamento "+nomdepartamento+" es "+poblaciondepartamento);
			}
			else
			{
				MessageBox.Show("No se a agregado ninguna provincia");
			}
		}
		public int poblaciond()
		{
			int poblaciondepartamento=0;
			if(np>0)
			{
			
				for(int i=0;i<np;i++)
				{
					poblaciondepartamento+=p[i].Poblacion;	
				}
				MessageBox.Show("LA Poblacion del departamento "+nomdepartamento+" es "+poblaciondepartamento);
			}
			else
			{
				MessageBox.Show("No se a agregado ninguna provincia");
			}
			return poblaciondepartamento;
		}
		
	}
}
