﻿using System;
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
	public partial class LibroForm : Form
	{
		Libro myLibro;
		public LibroForm()
		{
			myLibro = new Libro();
			InitializeComponent();
		}

		private void BAgregar_libro_Click(object sender, EventArgs e)
		{
			myLibro.insertLibro(tbISBN.Text, tbEdicion.Text, tbEditorial.Text, tbNo_paginas.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text, tbCantidad.Text);

		}

		private void TbApellido_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbAño_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbISBN_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbEdicion_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbEditorial_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbCantidad_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbNo_paginas_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbTitulo_TextChanged(object sender, EventArgs e)
		{

		}

		private void TbNombre_autor_TextChanged(object sender, EventArgs e)
		{

		}

		private void Label9_Click(object sender, EventArgs e)
		{

		}

		private void Label8_Click(object sender, EventArgs e)
		{

		}

		private void Label7_Click(object sender, EventArgs e)
		{

		}

		private void Label6_Click(object sender, EventArgs e)
		{

		}

		private void Label5_Click(object sender, EventArgs e)
		{

		}

		private void Label4_Click(object sender, EventArgs e)
		{

		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}