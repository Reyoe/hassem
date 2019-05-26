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
        string metodo;
		public ClienteForm()
		{
            metodo = "agregar";
			myCliente = new Cliente();

			InitializeComponent();
		}
        public ClienteForm(string curp, string nombre, string apellido, string correo, string colonia, string calle, string no, string metodo)
        {
            myCliente = new Cliente();

            this.metodo = metodo;

            InitializeComponent();
            if (metodo == "mostrar")
            {
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

            if (metodo == "modificar")
            {
                tbCurp.Text = curp;
                tbNombre.Text = nombre;
                tbApellido.Text = apellido;
                tbCorreo.Text = correo;
                tbColonia.Text = colonia;
                tbCalle.Text = calle;
                tbNo.Text = no;

                tbCurp.Enabled = false;


                button1.Text = "MODIFICAR";
            }
        }
        private void Button1_Click(object sender, EventArgs e)
		{
            if (this.metodo == "modificar")
            {
                myCliente.updateCliente(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNo.Text);
            }
            else {
                myCliente.insertCliente(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNo.Text);
            }
		}

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
