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
        public RevistaForm(string editorial, string paginas, string nombre, string apellido, string titulo, string año, string cantidad)
        {
            myRevista = new Revista();
            InitializeComponent();

            tbEditorial.Text = editorial;
            tbNo_paginas.Text = paginas;
            tbNombre_autor.Text = nombre;
            tbApellido.Text = apellido;
            tbTitulo.Text = titulo;
            tbAño.Text = año;
            tbCantidad.Text = cantidad;

            tbEditorial.Enabled = false;
            tbNo_paginas.Enabled = false;
            tbNombre_autor.Enabled = false;
            tbApellido.Enabled = false;
            tbTitulo.Enabled = false;
            tbAño.Enabled = false;
            tbCantidad.Enabled = false;
            BAgregar_Revista.Enabled = false;

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
