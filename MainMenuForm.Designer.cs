namespace Proyecto
{
	partial class MainMenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEjemplar = new System.Windows.Forms.Button();
            this.btnPeriodico = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnRevista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cbOp = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnEjemplar);
            this.panel1.Controls.Add(this.btnPeriodico);
            this.panel1.Controls.Add(this.btnVideo);
            this.panel1.Controls.Add(this.c);
            this.panel1.Controls.Add(this.btnLibro);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnRevista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnEjemplar
            // 
            this.btnEjemplar.BackColor = System.Drawing.Color.Transparent;
            this.btnEjemplar.BackgroundImage = global::Proyecto.Properties.Resources.icons8_libros_30;
            this.btnEjemplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEjemplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjemplar.FlatAppearance.BorderSize = 0;
            this.btnEjemplar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEjemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplar.ForeColor = System.Drawing.Color.White;
            this.btnEjemplar.Location = new System.Drawing.Point(0, 243);
            this.btnEjemplar.Name = "btnEjemplar";
            this.btnEjemplar.Size = new System.Drawing.Size(200, 75);
            this.btnEjemplar.TabIndex = 5;
            this.btnEjemplar.Text = "Ejemplar";
            this.btnEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEjemplar.UseVisualStyleBackColor = false;
            this.btnEjemplar.Click += new System.EventHandler(this.BtnEjemplar_Click);
            // 
            // btnPeriodico
            // 
            this.btnPeriodico.BackColor = System.Drawing.Color.Transparent;
            this.btnPeriodico.BackgroundImage = global::Proyecto.Properties.Resources.icons8_noticias_filled_30;
            this.btnPeriodico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPeriodico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeriodico.FlatAppearance.BorderSize = 0;
            this.btnPeriodico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnPeriodico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodico.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnPeriodico.ForeColor = System.Drawing.Color.White;
            this.btnPeriodico.Location = new System.Drawing.Point(0, 329);
            this.btnPeriodico.Name = "btnPeriodico";
            this.btnPeriodico.Size = new System.Drawing.Size(200, 75);
            this.btnPeriodico.TabIndex = 1;
            this.btnPeriodico.Text = "Periódico";
            this.btnPeriodico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPeriodico.UseVisualStyleBackColor = false;
            this.btnPeriodico.Click += new System.EventHandler(this.BtnPeriodico_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnVideo.BackgroundImage = global::Proyecto.Properties.Resources.icons8_programa_de_televisión_filled_30;
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnVideo.ForeColor = System.Drawing.Color.White;
            this.btnVideo.Location = new System.Drawing.Point(-3, 410);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(200, 75);
            this.btnVideo.TabIndex = 3;
            this.btnVideo.Text = "Video";
            this.btnVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.BtnVideo_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.BackgroundImage = global::Proyecto.Properties.Resources.icons8_contactos_35;
            this.c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c.FlatAppearance.BorderSize = 0;
            this.c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.c.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.c.Location = new System.Drawing.Point(0, 81);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(200, 75);
            this.c.TabIndex = 4;
            this.c.Text = "Cliente";
            this.c.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.C_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnLibro.BackgroundImage = global::Proyecto.Properties.Resources.icons8_literatura_filled_30;
            this.btnLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibro.FlatAppearance.BorderSize = 0;
            this.btnLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.Location = new System.Drawing.Point(0, 162);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(200, 75);
            this.btnLibro.TabIndex = 0;
            this.btnLibro.Text = "Libro";
            this.btnLibro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibro.UseVisualStyleBackColor = false;
            this.btnLibro.Click += new System.EventHandler(this.BtnLibro_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BackgroundImage = global::Proyecto.Properties.Resources.icons8_trabajo_permanente_35_1_;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(0, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(200, 75);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // btnRevista
            // 
            this.btnRevista.BackColor = System.Drawing.Color.Transparent;
            this.btnRevista.BackgroundImage = global::Proyecto.Properties.Resources.icons8_revista_filled_30;
            this.btnRevista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRevista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevista.FlatAppearance.BorderSize = 0;
            this.btnRevista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnRevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevista.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnRevista.ForeColor = System.Drawing.Color.White;
            this.btnRevista.Location = new System.Drawing.Point(0, 491);
            this.btnRevista.Name = "btnRevista";
            this.btnRevista.Size = new System.Drawing.Size(200, 75);
            this.btnRevista.TabIndex = 2;
            this.btnRevista.Text = "Revista";
            this.btnRevista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevista.UseVisualStyleBackColor = false;
            this.btnRevista.Click += new System.EventHandler(this.BtnRevista_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDevolucion);
            this.panel2.Controls.Add(this.btnPrestamo);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnVer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 111);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "MODULO:";
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnDevolucion.Location = new System.Drawing.Point(537, 55);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(108, 53);
            this.btnDevolucion.TabIndex = 11;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.Location = new System.Drawing.Point(432, 55);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(108, 53);
            this.btnPrestamo.TabIndex = 10;
            this.btnPrestamo.Text = "Préstamo";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(324, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 53);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(0, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 53);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(216, 55);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 53);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Transparent;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(108, 55);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(108, 53);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver Detalles";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 309);
            this.dataGridView1.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbCodigo.Location = new System.Drawing.Point(684, 117);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(129, 24);
            this.tbCodigo.TabIndex = 3;
            this.tbCodigo.TextChanged += new System.EventHandler(this.TbCodigo_TextChanged);
            // 
            // cbOp
            // 
            this.cbOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOp.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbOp.FormattingEnabled = true;
            this.cbOp.Location = new System.Drawing.Point(557, 117);
            this.cbOp.Name = "cbOp";
            this.cbOp.Size = new System.Drawing.Size(121, 25);
            this.cbOp.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Proyecto.Properties.Resources.índice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 566);
            this.Controls.Add(this.cbOp);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnUsuario;
		private System.Windows.Forms.Button c;
		private System.Windows.Forms.Button btnVideo;
		private System.Windows.Forms.Button btnRevista;
		private System.Windows.Forms.Button btnPeriodico;
		private System.Windows.Forms.Button btnLibro;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnDevolucion;
		private System.Windows.Forms.Button btnPrestamo;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ComboBox cbOp;
        private System.Windows.Forms.Button btnEjemplar;
    }
}