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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(118, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(118, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edición";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(118, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editorial";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(374, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "No_Páginas";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(374, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre_Autor";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(374, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellido_Autor";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(118, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Titulo";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(118, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Año";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(374, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // tbNombre_autor
            // 
            this.tbNombre_autor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNombre_autor.Location = new System.Drawing.Point(378, 134);
            this.tbNombre_autor.Name = "tbNombre_autor";
            this.tbNombre_autor.Size = new System.Drawing.Size(157, 23);
            this.tbNombre_autor.TabIndex = 9;
            this.tbNombre_autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNombre_autor.TextChanged += new System.EventHandler(this.TbNombre_autor_TextChanged);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTitulo.Location = new System.Drawing.Point(122, 201);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(157, 23);
            this.tbTitulo.TabIndex = 10;
            this.tbTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTitulo.TextChanged += new System.EventHandler(this.TbTitulo_TextChanged);
            // 
            // tbNo_paginas
            // 
            this.tbNo_paginas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNo_paginas.Location = new System.Drawing.Point(380, 261);
            this.tbNo_paginas.Name = "tbNo_paginas";
            this.tbNo_paginas.Size = new System.Drawing.Size(157, 23);
            this.tbNo_paginas.TabIndex = 11;
            this.tbNo_paginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNo_paginas.TextChanged += new System.EventHandler(this.TbNo_paginas_TextChanged);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCantidad.Location = new System.Drawing.Point(378, 327);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(157, 23);
            this.tbCantidad.TabIndex = 12;
            this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCantidad.TextChanged += new System.EventHandler(this.TbCantidad_TextChanged);
            // 
            // tbEditorial
            // 
            this.tbEditorial.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEditorial.Location = new System.Drawing.Point(122, 261);
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(157, 23);
            this.tbEditorial.TabIndex = 13;
            this.tbEditorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEditorial.TextChanged += new System.EventHandler(this.TbEditorial_TextChanged);
            // 
            // tbEdicion
            // 
            this.tbEdicion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEdicion.Location = new System.Drawing.Point(122, 327);
            this.tbEdicion.Name = "tbEdicion";
            this.tbEdicion.Size = new System.Drawing.Size(157, 23);
            this.tbEdicion.TabIndex = 14;
            this.tbEdicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEdicion.TextChanged += new System.EventHandler(this.TbEdicion_TextChanged);
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbISBN.Location = new System.Drawing.Point(122, 137);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(157, 23);
            this.tbISBN.TabIndex = 15;
            this.tbISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbISBN.TextChanged += new System.EventHandler(this.TbISBN_TextChanged);
            // 
            // tbAño
            // 
            this.tbAño.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbAño.Location = new System.Drawing.Point(122, 389);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(157, 23);
            this.tbAño.TabIndex = 16;
            this.tbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAño.TextChanged += new System.EventHandler(this.TbAño_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbApellido.Location = new System.Drawing.Point(378, 201);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(157, 23);
            this.tbApellido.TabIndex = 17;
            this.tbApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbApellido.TextChanged += new System.EventHandler(this.TbApellido_TextChanged);
            // 
            // BAgregar_libro
            // 
            this.BAgregar_libro.BackColor = System.Drawing.Color.YellowGreen;
            this.BAgregar_libro.BackgroundImage = global::Proyecto.Properties.Resources.green2;
            this.BAgregar_libro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BAgregar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregar_libro.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BAgregar_libro.ForeColor = System.Drawing.Color.White;
            this.BAgregar_libro.Image = global::Proyecto.Properties.Resources.icons8_añadir_libro_20;
            this.BAgregar_libro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BAgregar_libro.Location = new System.Drawing.Point(381, 363);
            this.BAgregar_libro.Name = "BAgregar_libro";
            this.BAgregar_libro.Size = new System.Drawing.Size(116, 49);
            this.BAgregar_libro.TabIndex = 18;
            this.BAgregar_libro.Text = "AGREGAR";
            this.BAgregar_libro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BAgregar_libro.UseVisualStyleBackColor = false;
            this.BAgregar_libro.Click += new System.EventHandler(this.BAgregar_libro_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Maroon;
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Image = global::Proyecto.Properties.Resources.icons8_eliminar_filled_20;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BSalir.Location = new System.Drawing.Point(527, 363);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(116, 49);
            this.BSalir.TabIndex = 19;
            this.BSalir.Text = "SALIR";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._394862;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 451);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LibroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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