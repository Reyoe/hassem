using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
	public partial class PeriodicoForm : Form
	{
		Periodico myPeriodico;
		public PeriodicoForm()
		{
			myPeriodico = new Periodico();
			InitializeComponent();
		}

		private void BAgregar_Periodico_Click(object sender, EventArgs e)
		{
			myPeriodico.insertPeriodico(tbEditorial.Text, tbNo_paginas.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text, tbCantidad.Text, tbSecciones.Text);
		}

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
