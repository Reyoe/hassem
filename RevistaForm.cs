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
	public partial class RevistaForm : Form
	{
		Revista myRevista;
		public RevistaForm()
		{
			myRevista = new Revista();
			InitializeComponent();
		}

		private void BAgregar_Revista_Click(object sender, EventArgs e)
		{
			myRevista.insertRevista(tbEditorial.Text, tbNo_paginas.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text, tbCantidad.Text);

		}

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
