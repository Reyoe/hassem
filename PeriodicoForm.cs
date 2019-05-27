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
        string metodo, id;
		public PeriodicoForm()
		{
			myPeriodico = new Periodico();
			InitializeComponent();
            lbNPeriodico.Text = "NUEVO PERIODICO";
		}
        public PeriodicoForm(string id, string editorial, string paginas, string nombre, string apellido, string titulo, string año, string cantidad, string secciones,string metodo)
        {
            
            myPeriodico = new Periodico();
            this.metodo = metodo;
            this.id = id;
            InitializeComponent();
            if (metodo == "mostrar")
            {
                tbEditorial.Text = editorial;
                tbNo_paginas.Text = paginas;
                tbNombre_autor.Text = nombre;
                tbApellido.Text = apellido;
                tbTitulo.Text = titulo;
                tbAño.Text = año;
                tbCantidad.Text = cantidad;
                tbSecciones.Text = secciones;

                tbEditorial.Enabled = false;
                tbNo_paginas.Enabled = false;
                tbNombre_autor.Enabled = false;
                tbApellido.Enabled = false;
                tbTitulo.Enabled = false;
                tbAño.Enabled = false;
                tbCantidad.Enabled = false;
                tbSecciones.Enabled = false;
                BAgregar_Periodico.Enabled = false;
                lbNPeriodico.Text = "DETALLES DEL PERIODICO";
            }
            if (metodo == "modificar")
            {
                lbNPeriodico.Text = "MODIFICAR PERIODICO";
                tbEditorial.Text = editorial;
                tbNo_paginas.Text = paginas;
                tbNombre_autor.Text = nombre;
                tbApellido.Text = apellido;
                tbTitulo.Text = titulo;
                tbAño.Text = año;
                tbCantidad.Text = cantidad;
                tbSecciones.Text = secciones;


                BAgregar_Periodico.Text = "MODIFICAR";
            }
        }

        private void BAgregar_Periodico_Click(object sender, EventArgs e)
		{
            if (this.metodo == "modificar")
            {
                myPeriodico.updatePeriodico(this.id, tbEditorial.Text, tbNo_paginas.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text, tbCantidad.Text, tbSecciones.Text);
                MessageBox.Show("Periodico Modificado con exito");

            }
            else {
                myPeriodico.insertPeriodico(tbEditorial.Text, tbNo_paginas.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text, tbCantidad.Text, tbSecciones.Text);
                MessageBox.Show("Periodico agregado con exito");

            }

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
