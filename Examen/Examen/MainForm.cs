/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 22/04/2019
 * Hora: 19:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Cuenta[] nc= new Cuenta[50];
		int n=0;
		int p=-1;
		bool tipo=true;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCreaClick(object sender, EventArgs e)
		{
			lv.Items.Clear();
			String t = txtt.Text;
			String c =txtm.Text;
			if(t.Equals(""))
			{
				lbl.Text="El titular es requisito";
			}
			else
			{
				if(c.Equals(""))
				{
					nc[n] = new Cuenta(t);
					n++;
				}
				else
				{
					nc[n] = new Cuenta(t,double.Parse(c));
					n++;
				}
				for(int i =0; i < n ;i++)
				{
					ListViewItem lvi = new ListViewItem(nc[i].Titular.ToString());
					lvi.SubItems.Add(nc[i].Cantidad.ToString());
					lv.Items.Add(lvi);
				}
			}
				
				
				
				
			
			
		}
		void BtnbuscarClick(object sender, EventArgs e)
		{
			String t = txtt.Text;
			for(int i =0; i < n ;i++)
			{
				if(nc[i].Titular.ToString().Equals(t))
					{
						txtm.Text=nc[i].Cantidad.ToString();
						lbl.Text="Cuenta encontrada";
						p=i;
					}
					
			}
			
	
		}
		void BtntranClick(object sender, EventArgs e)
		{
			lv.Items.Clear();
			double tran=double.Parse(txttran.Text);
			if(rdbdeposito.Checked==true)
			{
				nc[p].ingresar(tran);
			}
			else
			{
				if(nc[p].Cantidad>tran)
				{
					nc[p].retirar(tran);
				}
				else
				{
					lbl.Text="Transaccion imposible";
				}
				
			}
			for(int i =0; i < n ;i++)
				{
					ListViewItem lvi = new ListViewItem(nc[i].Titular.ToString());
					lvi.SubItems.Add(nc[i].Cantidad.ToString());
					lv.Items.Add(lvi);
				}	
	
		}
		
	}
}
