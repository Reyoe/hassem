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
	public partial class ClienteForm : Form
	{
		Cliente myCliente;
		public ClienteForm()
		{
			myCliente = new Cliente();

			InitializeComponent();
		}
        public ClienteForm(string curp, string nombre, string apellido, string correo, string colonia, string calle, string no)
        {
            myCliente = new Cliente();

            InitializeComponent();

            tbCurp.Text = curp;
            tbNombre.Text = nombre;
            tbApellido.Text = apellido;
            tbCorreo.Text = correo;
            tbColonia.Text = colonia;
            tbCalle.Text = calle;
            tbNo.Text = no;

            tbCurp.Enabled = false;
            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            tbCorreo.Enabled = false;
            tbColonia.Enabled = false;
            tbCalle.Enabled = false;
            tbNo.Enabled = false;

            button1.Enabled = false;
        }
        private void Button1_Click(object sender, EventArgs e)
		{
		    myCliente.insertCliente(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNo.Text);
		
		}

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
