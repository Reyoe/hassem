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
    public partial class UsuarioAdOp : Form
    {
        public UsuarioAdOp()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Usuario U = new Usuario();
            Administrador a = new Administrador();
            U.insertUsuario(tbCodigo.Text, tbNombreUsuario.Text, tbContra.Text);
            a.insertAdministrador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
