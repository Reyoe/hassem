namespace Proyecto
{
    partial class PrestamoForm
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
            this.lbFolio = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbCurpO = new System.Windows.Forms.Label();
            this.lbCurpC = new System.Windows.Forms.Label();
            this.tbFolio = new System.Windows.Forms.TextBox();
            this.tbCurpOp = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbCurpCliente = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.pPrestamo = new System.Windows.Forms.Panel();
            this.lbPrestamo = new System.Windows.Forms.Label();
            this.pBPrestamo = new System.Windows.Forms.PictureBox();
            this.pPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFolio
            // 
            this.lbFolio.AutoSize = true;
            this.lbFolio.BackColor = System.Drawing.Color.Transparent;
            this.lbFolio.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbFolio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbFolio.Location = new System.Drawing.Point(95, 120);
            this.lbFolio.Name = "lbFolio";
            this.lbFolio.Size = new System.Drawing.Size(47, 21);
            this.lbFolio.TabIndex = 0;
            this.lbFolio.Text = "Folio";
            this.lbFolio.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbFecha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbFecha.Location = new System.Drawing.Point(95, 189);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(55, 21);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha";
            // 
            // lbCurpO
            // 
            this.lbCurpO.AutoSize = true;
            this.lbCurpO.BackColor = System.Drawing.Color.Transparent;
            this.lbCurpO.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbCurpO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurpO.Location = new System.Drawing.Point(308, 120);
            this.lbCurpO.Name = "lbCurpO";
            this.lbCurpO.Size = new System.Drawing.Size(125, 21);
            this.lbCurpO.TabIndex = 2;
            this.lbCurpO.Text = "Curp_Operador";
            // 
            // lbCurpC
            // 
            this.lbCurpC.AutoSize = true;
            this.lbCurpC.BackColor = System.Drawing.Color.Transparent;
            this.lbCurpC.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.lbCurpC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurpC.Location = new System.Drawing.Point(308, 189);
            this.lbCurpC.Name = "lbCurpC";
            this.lbCurpC.Size = new System.Drawing.Size(109, 21);
            this.lbCurpC.TabIndex = 3;
            this.lbCurpC.Text = "Curp_Cliente";
            // 
            // tbFolio
            // 
            this.tbFolio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbFolio.Location = new System.Drawing.Point(99, 144);
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Size = new System.Drawing.Size(157, 23);
            this.tbFolio.TabIndex = 4;
            this.tbFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCurpOp
            // 
            this.tbCurpOp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCurpOp.Location = new System.Drawing.Point(312, 144);
            this.tbCurpOp.Name = "tbCurpOp";
            this.tbCurpOp.Size = new System.Drawing.Size(157, 23);
            this.tbCurpOp.TabIndex = 5;
            this.tbCurpOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFecha
            // 
            this.tbFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbFecha.Location = new System.Drawing.Point(99, 213);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(157, 23);
            this.tbFecha.TabIndex = 6;
            this.tbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCurpCliente
            // 
            this.tbCurpCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCurpCliente.Location = new System.Drawing.Point(312, 213);
            this.tbCurpCliente.Name = "tbCurpCliente";
            this.tbCurpCliente.Size = new System.Drawing.Size(157, 23);
            this.tbCurpCliente.TabIndex = 7;
            this.tbCurpCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Maroon;
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btSalir.Image = global::Proyecto.Properties.Resources.icons8_eliminar_filled_20;
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalir.Location = new System.Drawing.Point(312, 261);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(116, 49);
            this.btSalir.TabIndex = 9;
            this.btSalir.Text = "SALIR";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalir.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.DarkCyan;
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btAgregar.Image = global::Proyecto.Properties.Resources.icons8_libreta_de_ahorros_20;
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAgregar.Location = new System.Drawing.Point(99, 261);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(116, 49);
            this.btAgregar.TabIndex = 8;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // pPrestamo
            // 
            this.pPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.pPrestamo.BackgroundImage = global::Proyecto.Properties.Resources._704059_1920_1200;
            this.pPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPrestamo.Controls.Add(this.lbPrestamo);
            this.pPrestamo.Controls.Add(this.pBPrestamo);
            this.pPrestamo.Location = new System.Drawing.Point(0, 0);
            this.pPrestamo.Name = "pPrestamo";
            this.pPrestamo.Size = new System.Drawing.Size(555, 56);
            this.pPrestamo.TabIndex = 61;
            // 
            // lbPrestamo
            // 
            this.lbPrestamo.AutoSize = true;
            this.lbPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.lbPrestamo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrestamo.ForeColor = System.Drawing.Color.White;
            this.lbPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPrestamo.Location = new System.Drawing.Point(179, 3);
            this.lbPrestamo.Name = "lbPrestamo";
            this.lbPrestamo.Size = new System.Drawing.Size(197, 39);
            this.lbPrestamo.TabIndex = 55;
            this.lbPrestamo.Text = "PRÉSTAMOS";
            this.lbPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBPrestamo
            // 
            this.pBPrestamo.Image = global::Proyecto.Properties.Resources.icons8_libreta_de_ahorros_50;
            this.pBPrestamo.Location = new System.Drawing.Point(108, 3);
            this.pBPrestamo.Name = "pBPrestamo";
            this.pBPrestamo.Size = new System.Drawing.Size(46, 46);
            this.pBPrestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPrestamo.TabIndex = 56;
            this.pBPrestamo.TabStop = false;
            // 
            // PrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.libross;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.pPrestamo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbCurpCliente);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbCurpOp);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.lbCurpC);
            this.Controls.Add(this.lbCurpO);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbFolio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrestamoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrestamoForm";
            this.pPrestamo.ResumeLayout(false);
            this.pPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFolio;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbCurpO;
        private System.Windows.Forms.Label lbCurpC;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.TextBox tbCurpOp;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbCurpCliente;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Panel pPrestamo;
        private System.Windows.Forms.Label lbPrestamo;
        private System.Windows.Forms.PictureBox pBPrestamo;
    }
}