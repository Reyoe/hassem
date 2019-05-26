namespace Proyecto
{
	partial class LibroForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNombre_autor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbNo_paginas = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbEditorial = new System.Windows.Forms.TextBox();
            this.tbEdicion = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.BAgregar_libro = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edicion";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editorial";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No_paginas";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre_Autor";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellido_Autor";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Titulo";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Año";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // tbNombre_autor
            // 
            this.tbNombre_autor.Location = new System.Drawing.Point(630, 54);
            this.tbNombre_autor.Name = "tbNombre_autor";
            this.tbNombre_autor.Size = new System.Drawing.Size(100, 20);
            this.tbNombre_autor.TabIndex = 9;
            this.tbNombre_autor.TextChanged += new System.EventHandler(this.TbNombre_autor_TextChanged);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(358, 199);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(100, 20);
            this.tbTitulo.TabIndex = 10;
            this.tbTitulo.TextChanged += new System.EventHandler(this.TbTitulo_TextChanged);
            // 
            // tbNo_paginas
            // 
            this.tbNo_paginas.Location = new System.Drawing.Point(358, 121);
            this.tbNo_paginas.Name = "tbNo_paginas";
            this.tbNo_paginas.Size = new System.Drawing.Size(100, 20);
            this.tbNo_paginas.TabIndex = 11;
            this.tbNo_paginas.TextChanged += new System.EventHandler(this.TbNo_paginas_TextChanged);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(113, 199);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 12;
            this.tbCantidad.TextChanged += new System.EventHandler(this.TbCantidad_TextChanged);
            // 
            // tbEditorial
            // 
            this.tbEditorial.Location = new System.Drawing.Point(113, 121);
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(100, 20);
            this.tbEditorial.TabIndex = 13;
            this.tbEditorial.TextChanged += new System.EventHandler(this.TbEditorial_TextChanged);
            // 
            // tbEdicion
            // 
            this.tbEdicion.Location = new System.Drawing.Point(358, 54);
            this.tbEdicion.Name = "tbEdicion";
            this.tbEdicion.Size = new System.Drawing.Size(100, 20);
            this.tbEdicion.TabIndex = 14;
            this.tbEdicion.TextChanged += new System.EventHandler(this.TbEdicion_TextChanged);
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(113, 47);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 20);
            this.tbISBN.TabIndex = 15;
            this.tbISBN.TextChanged += new System.EventHandler(this.TbISBN_TextChanged);
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(630, 189);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(100, 20);
            this.tbAño.TabIndex = 16;
            this.tbAño.TextChanged += new System.EventHandler(this.TbAño_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(630, 117);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 20);
            this.tbApellido.TabIndex = 17;
            this.tbApellido.TextChanged += new System.EventHandler(this.TbApellido_TextChanged);
            // 
            // BAgregar_libro
            // 
            this.BAgregar_libro.Location = new System.Drawing.Point(210, 304);
            this.BAgregar_libro.Name = "BAgregar_libro";
            this.BAgregar_libro.Size = new System.Drawing.Size(75, 23);
            this.BAgregar_libro.TabIndex = 18;
            this.BAgregar_libro.Text = "AGREGAR";
            this.BAgregar_libro.UseVisualStyleBackColor = true;
            this.BAgregar_libro.Click += new System.EventHandler(this.BAgregar_libro_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(506, 304);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 19;
            this.BSalir.Text = "SALIR";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BAgregar_libro);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbEdicion);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LibroForm";
            this.Text = "LibroForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbNombre_autor;
		private System.Windows.Forms.TextBox tbTitulo;
		private System.Windows.Forms.TextBox tbNo_paginas;
		private System.Windows.Forms.TextBox tbCantidad;
		private System.Windows.Forms.TextBox tbEditorial;
		private System.Windows.Forms.TextBox tbEdicion;
		private System.Windows.Forms.TextBox tbISBN;
		private System.Windows.Forms.TextBox tbAño;
		private System.Windows.Forms.TextBox tbApellido;
		private System.Windows.Forms.Button BAgregar_libro;
        private System.Windows.Forms.Button BSalir;
    }
}