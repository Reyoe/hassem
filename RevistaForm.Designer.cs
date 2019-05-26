namespace Proyecto
{
	partial class RevistaForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.BAgregar_Revista = new System.Windows.Forms.Button();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbEditorial = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbNo_paginas = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbNombre_autor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAgregar_Revista
            // 
            this.BAgregar_Revista.Location = new System.Drawing.Point(191, 292);
            this.BAgregar_Revista.Name = "BAgregar_Revista";
            this.BAgregar_Revista.Size = new System.Drawing.Size(75, 23);
            this.BAgregar_Revista.TabIndex = 37;
            this.BAgregar_Revista.Text = "AGREGAR";
            this.BAgregar_Revista.UseVisualStyleBackColor = true;
            this.BAgregar_Revista.Click += new System.EventHandler(this.BAgregar_Revista_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(641, 135);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 20);
            this.tbApellido.TabIndex = 36;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(641, 207);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(100, 20);
            this.tbAño.TabIndex = 35;
            // 
            // tbEditorial
            // 
            this.tbEditorial.Location = new System.Drawing.Point(124, 139);
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(100, 20);
            this.tbEditorial.TabIndex = 32;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(124, 217);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 31;
            // 
            // tbNo_paginas
            // 
            this.tbNo_paginas.Location = new System.Drawing.Point(369, 139);
            this.tbNo_paginas.Name = "tbNo_paginas";
            this.tbNo_paginas.Size = new System.Drawing.Size(100, 20);
            this.tbNo_paginas.TabIndex = 30;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(369, 217);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 20);
            this.tbTitulo.TabIndex = 29;
            // 
            // tbNombre_autor
            // 
            this.tbNombre_autor.Location = new System.Drawing.Point(641, 72);
            this.tbNombre_autor.Name = "tbNombre_autor";
            this.tbNombre_autor.Size = new System.Drawing.Size(100, 20);
            this.tbNombre_autor.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Apellido_Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombre_Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "No_paginas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Editorial";
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(492, 292);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 38;
            this.BSalir.Text = "SALIR";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // RevistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BAgregar_Revista);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbEditorial);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbNo_paginas);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbNombre_autor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RevistaForm";
            this.Text = "RevistaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BAgregar_Revista;
		private System.Windows.Forms.TextBox tbApellido;
		private System.Windows.Forms.TextBox tbAño;
		private System.Windows.Forms.TextBox tbEditorial;
		private System.Windows.Forms.TextBox tbCantidad;
		private System.Windows.Forms.TextBox tbNo_paginas;
		private System.Windows.Forms.TextBox tbTitulo;
		private System.Windows.Forms.TextBox tbNombre_autor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BSalir;
    }
}