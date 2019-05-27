namespace Proyecto
{
    partial class EjemplaresForm
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
            this.lbId_ejemplar = new System.Windows.Forms.Label();
            this.lbIsbnL = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.lbCaducidad = new System.Windows.Forms.Label();
            this.tbId_ejemplar = new System.Windows.Forms.TextBox();
            this.tbIsbnLibro = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbCaducidad = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pEjemplar = new System.Windows.Forms.Panel();
            this.lbEjemplar = new System.Windows.Forms.Label();
            this.pBEjemplar = new System.Windows.Forms.PictureBox();
            this.pEjemplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEjemplar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId_ejemplar
            // 
            this.lbId_ejemplar.AutoSize = true;
            this.lbId_ejemplar.BackColor = System.Drawing.Color.Transparent;
            this.lbId_ejemplar.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbId_ejemplar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbId_ejemplar.Location = new System.Drawing.Point(80, 121);
            this.lbId_ejemplar.Name = "lbId_ejemplar";
            this.lbId_ejemplar.Size = new System.Drawing.Size(102, 21);
            this.lbId_ejemplar.TabIndex = 0;
            this.lbId_ejemplar.Text = "Id_Ejemplar";
            // 
            // lbIsbnL
            // 
            this.lbIsbnL.AutoSize = true;
            this.lbIsbnL.BackColor = System.Drawing.Color.Transparent;
            this.lbIsbnL.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbIsbnL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIsbnL.Location = new System.Drawing.Point(80, 184);
            this.lbIsbnL.Name = "lbIsbnL";
            this.lbIsbnL.Size = new System.Drawing.Size(96, 21);
            this.lbIsbnL.TabIndex = 1;
            this.lbIsbnL.Text = "ISBN_Libro";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.BackColor = System.Drawing.Color.Transparent;
            this.lbEstado.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbEstado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEstado.Location = new System.Drawing.Point(308, 121);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(62, 21);
            this.lbEstado.TabIndex = 2;
            this.lbEstado.Text = "Estado";
            this.lbEstado.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescripcion.Location = new System.Drawing.Point(80, 245);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(99, 21);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lbObservaciones.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbObservaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbObservaciones.Location = new System.Drawing.Point(308, 245);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(120, 21);
            this.lbObservaciones.TabIndex = 4;
            this.lbObservaciones.Text = "Observaciones";
            // 
            // lbCaducidad
            // 
            this.lbCaducidad.AutoSize = true;
            this.lbCaducidad.BackColor = System.Drawing.Color.Transparent;
            this.lbCaducidad.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbCaducidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCaducidad.Location = new System.Drawing.Point(308, 184);
            this.lbCaducidad.Name = "lbCaducidad";
            this.lbCaducidad.Size = new System.Drawing.Size(91, 21);
            this.lbCaducidad.TabIndex = 5;
            this.lbCaducidad.Text = "Caducidad";
            // 
            // tbId_ejemplar
            // 
            this.tbId_ejemplar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbId_ejemplar.Location = new System.Drawing.Point(84, 145);
            this.tbId_ejemplar.Name = "tbId_ejemplar";
            this.tbId_ejemplar.Size = new System.Drawing.Size(157, 23);
            this.tbId_ejemplar.TabIndex = 7;
            this.tbId_ejemplar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIsbnLibro
            // 
            this.tbIsbnLibro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbIsbnLibro.Location = new System.Drawing.Point(84, 208);
            this.tbIsbnLibro.Name = "tbIsbnLibro";
            this.tbIsbnLibro.Size = new System.Drawing.Size(157, 23);
            this.tbIsbnLibro.TabIndex = 8;
            this.tbIsbnLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbDescripcion.Location = new System.Drawing.Point(84, 269);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(157, 23);
            this.tbDescripcion.TabIndex = 9;
            this.tbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEstado
            // 
            this.tbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEstado.Location = new System.Drawing.Point(312, 145);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(157, 23);
            this.tbEstado.TabIndex = 10;
            this.tbEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCaducidad
            // 
            this.tbCaducidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCaducidad.Location = new System.Drawing.Point(312, 208);
            this.tbCaducidad.Name = "tbCaducidad";
            this.tbCaducidad.Size = new System.Drawing.Size(157, 23);
            this.tbCaducidad.TabIndex = 11;
            this.tbCaducidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbObservaciones.Location = new System.Drawing.Point(312, 269);
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(157, 23);
            this.tbObservaciones.TabIndex = 12;
            this.tbObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Proyecto.Properties.Resources.icons8_eliminar_filled_20;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(312, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "SALIR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Proyecto.Properties.Resources.icons8_libros_20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(125, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "AGREGAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pEjemplar
            // 
            this.pEjemplar.BackColor = System.Drawing.Color.Transparent;
            this.pEjemplar.BackgroundImage = global::Proyecto.Properties.Resources._704059_1920_1200;
            this.pEjemplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pEjemplar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pEjemplar.Controls.Add(this.lbEjemplar);
            this.pEjemplar.Controls.Add(this.pBEjemplar);
            this.pEjemplar.Location = new System.Drawing.Point(-1, 1);
            this.pEjemplar.Name = "pEjemplar";
            this.pEjemplar.Size = new System.Drawing.Size(555, 56);
            this.pEjemplar.TabIndex = 60;
            // 
            // lbEjemplar
            // 
            this.lbEjemplar.AutoSize = true;
            this.lbEjemplar.BackColor = System.Drawing.Color.Transparent;
            this.lbEjemplar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEjemplar.ForeColor = System.Drawing.Color.White;
            this.lbEjemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEjemplar.Location = new System.Drawing.Point(176, 6);
            this.lbEjemplar.Name = "lbEjemplar";
            this.lbEjemplar.Size = new System.Drawing.Size(204, 39);
            this.lbEjemplar.TabIndex = 55;
            this.lbEjemplar.Text = "EJEMPLARES";
            this.lbEjemplar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBEjemplar
            // 
            this.pBEjemplar.Image = global::Proyecto.Properties.Resources.icons8_libros_50;
            this.pBEjemplar.Location = new System.Drawing.Point(86, 3);
            this.pBEjemplar.Name = "pBEjemplar";
            this.pBEjemplar.Size = new System.Drawing.Size(46, 46);
            this.pBEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBEjemplar.TabIndex = 56;
            this.pBEjemplar.TabStop = false;
            // 
            // EjemplaresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.libross;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.pEjemplar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.tbCaducidad);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbIsbnLibro);
            this.Controls.Add(this.tbId_ejemplar);
            this.Controls.Add(this.lbCaducidad);
            this.Controls.Add(this.lbObservaciones);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbIsbnL);
            this.Controls.Add(this.lbId_ejemplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EjemplaresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EjemplaresForm";
            this.pEjemplar.ResumeLayout(false);
            this.pEjemplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEjemplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId_ejemplar;
        private System.Windows.Forms.Label lbIsbnL;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.Label lbCaducidad;
        private System.Windows.Forms.TextBox tbId_ejemplar;
        private System.Windows.Forms.TextBox tbIsbnLibro;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbCaducidad;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pEjemplar;
        private System.Windows.Forms.Label lbEjemplar;
        private System.Windows.Forms.PictureBox pBEjemplar;
    }
}