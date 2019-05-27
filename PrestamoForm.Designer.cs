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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFolio = new System.Windows.Forms.TextBox();
            this.tbCurpOp = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbCurpCliente = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curp_Operador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curp_Cliente";
            // 
            // tbFolio
            // 
            this.tbFolio.Location = new System.Drawing.Point(150, 75);
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Size = new System.Drawing.Size(100, 20);
            this.tbFolio.TabIndex = 4;
            // 
            // tbCurpOp
            // 
            this.tbCurpOp.Location = new System.Drawing.Point(547, 75);
            this.tbCurpOp.Name = "tbCurpOp";
            this.tbCurpOp.Size = new System.Drawing.Size(100, 20);
            this.tbCurpOp.TabIndex = 5;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(150, 159);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(100, 20);
            this.tbFecha.TabIndex = 6;
            // 
            // tbCurpCliente
            // 
            this.tbCurpCliente.Location = new System.Drawing.Point(521, 152);
            this.tbCurpCliente.Name = "tbCurpCliente";
            this.tbCurpCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCurpCliente.TabIndex = 7;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(216, 297);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 8;
            this.btAgregar.Text = "AGREGAR";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(481, 297);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 9;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // PrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tbCurpCliente);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.tbCurpOp);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrestamoForm";
            this.Text = "PrestamoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.TextBox tbCurpOp;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.TextBox tbCurpCliente;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btSalir;
    }
}