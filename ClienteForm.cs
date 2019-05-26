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
        public ClienteForm(string code)
        {

            myCliente = new Cliente();
            InitializeComponent();
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
