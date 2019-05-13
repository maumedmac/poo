/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 06/05/2019
 * Hora: 20:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace agregacion
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class agregaProvincia : Form
	{
		public agregaProvincia(int n)
		{
			this.Text= Text+" "+n;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Provincia BtnagregarprovinciClick(object sender, EventArgs e)
		{
			String nom = txtnombreprovincia.Text;
			int pob=int.Parse(txtpoblacionprovincia.Text);
			Provincia p= new Provincia(nom,pob);
			return p;
		}
		
		
		
	}
}
