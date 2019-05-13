/*
 * Creado por SharpDevelop.
 * Usuario: Ecstasy
 * Fecha: 22/04/2019
 * Hora: 19:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Examen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtt;
		private System.Windows.Forms.TextBox txtm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCrea;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button btnbuscar;
		private System.Windows.Forms.Button btntran;
		private System.Windows.Forms.TextBox txttran;
		private System.Windows.Forms.RadioButton rdbretiro;
		private System.Windows.Forms.RadioButton rdbdeposito;
		private System.Windows.Forms.Label lbl;
		
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
			this.txtt = new System.Windows.Forms.TextBox();
			this.txtm = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCrea = new System.Windows.Forms.Button();
			this.lv = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.btntran = new System.Windows.Forms.Button();
			this.txttran = new System.Windows.Forms.TextBox();
			this.rdbretiro = new System.Windows.Forms.RadioButton();
			this.rdbdeposito = new System.Windows.Forms.RadioButton();
			this.lbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtt
			// 
			this.txtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtt.Location = new System.Drawing.Point(26, 51);
			this.txtt.Name = "txtt";
			this.txtt.Size = new System.Drawing.Size(182, 26);
			this.txtt.TabIndex = 0;
			// 
			// txtm
			// 
			this.txtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtm.Location = new System.Drawing.Point(214, 51);
			this.txtm.Name = "txtm";
			this.txtm.Size = new System.Drawing.Size(119, 26);
			this.txtm.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre del titular";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(214, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Monto";
			// 
			// btnCrea
			// 
			this.btnCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrea.Location = new System.Drawing.Point(354, 25);
			this.btnCrea.Name = "btnCrea";
			this.btnCrea.Size = new System.Drawing.Size(104, 52);
			this.btnCrea.TabIndex = 4;
			this.btnCrea.Text = "Crear Cuenta";
			this.btnCrea.UseVisualStyleBackColor = true;
			this.btnCrea.Click += new System.EventHandler(this.BtnCreaClick);
			// 
			// lv
			// 
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2});
			this.lv.Location = new System.Drawing.Point(26, 183);
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(419, 137);
			this.lv.TabIndex = 5;
			this.lv.UseCompatibleStateImageBehavior = false;
			this.lv.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Titular";
			this.columnHeader1.Width = 222;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Saldo";
			this.columnHeader2.Width = 192;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnbuscar.Location = new System.Drawing.Point(26, 92);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(105, 33);
			this.btnbuscar.TabIndex = 6;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.BtnbuscarClick);
			// 
			// btntran
			// 
			this.btntran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntran.Location = new System.Drawing.Point(155, 92);
			this.btntran.Name = "btntran";
			this.btntran.Size = new System.Drawing.Size(129, 33);
			this.btntran.TabIndex = 7;
			this.btntran.Text = "Transaccion";
			this.btntran.UseVisualStyleBackColor = true;
			this.btntran.Click += new System.EventHandler(this.BtntranClick);
			// 
			// txttran
			// 
			this.txttran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttran.Location = new System.Drawing.Point(290, 95);
			this.txttran.Name = "txttran";
			this.txttran.Size = new System.Drawing.Size(155, 26);
			this.txttran.TabIndex = 8;
			// 
			// rdbretiro
			// 
			this.rdbretiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbretiro.Location = new System.Drawing.Point(341, 153);
			this.rdbretiro.Name = "rdbretiro";
			this.rdbretiro.Size = new System.Drawing.Size(104, 24);
			this.rdbretiro.TabIndex = 9;
			this.rdbretiro.TabStop = true;
			this.rdbretiro.Text = "Retiro";
			this.rdbretiro.UseVisualStyleBackColor = true;
			// 
			// rdbdeposito
			// 
			this.rdbdeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbdeposito.Location = new System.Drawing.Point(341, 127);
			this.rdbdeposito.Name = "rdbdeposito";
			this.rdbdeposito.Size = new System.Drawing.Size(104, 24);
			this.rdbdeposito.TabIndex = 10;
			this.rdbdeposito.TabStop = true;
			this.rdbdeposito.Text = "Deposito";
			this.rdbdeposito.UseVisualStyleBackColor = true;
			// 
			// lbl
			// 
			this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.Location = new System.Drawing.Point(31, 140);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(302, 23);
			this.lbl.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 371);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.rdbdeposito);
			this.Controls.Add(this.rdbretiro);
			this.Controls.Add(this.txttran);
			this.Controls.Add(this.btntran);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.btnCrea);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtm);
			this.Controls.Add(this.txtt);
			this.Name = "MainForm";
			this.Text = "Examen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
