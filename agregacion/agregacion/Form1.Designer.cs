/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 06/05/2019
 * Hora: 20:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace agregacion
{
	partial class agregaProvincia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtnombreprovincia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtpoblacionprovincia;
		private System.Windows.Forms.Button btnagregarprovinci;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtnombreprovincia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtpoblacionprovincia = new System.Windows.Forms.TextBox();
			this.btnagregarprovinci = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtnombreprovincia
			// 
			this.txtnombreprovincia.Location = new System.Drawing.Point(60, 49);
			this.txtnombreprovincia.Name = "txtnombreprovincia";
			this.txtnombreprovincia.Size = new System.Drawing.Size(100, 20);
			this.txtnombreprovincia.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(60, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(60, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Poblacion";
			// 
			// txtpoblacionprovincia
			// 
			this.txtpoblacionprovincia.Location = new System.Drawing.Point(60, 109);
			this.txtpoblacionprovincia.Name = "txtpoblacionprovincia";
			this.txtpoblacionprovincia.Size = new System.Drawing.Size(100, 20);
			this.txtpoblacionprovincia.TabIndex = 3;
			// 
			// btnagregarprovinci
			// 
			this.btnagregarprovinci.Location = new System.Drawing.Point(95, 155);
			this.btnagregarprovinci.Name = "btnagregarprovinci";
			this.btnagregarprovinci.Size = new System.Drawing.Size(75, 23);
			this.btnagregarprovinci.TabIndex = 4;
			this.btnagregarprovinci.Text = "Agregar";
			this.btnagregarprovinci.UseVisualStyleBackColor = true;
			this.btnagregarprovinci.Click += new System.EventHandler(this.BtnagregarprovinciClick);
			// 
			// agregaProvincia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnagregarprovinci);
			this.Controls.Add(this.txtpoblacionprovincia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnombreprovincia);
			this.Name = "agregaProvincia";
			this.Text = "Agregar Provincia";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
