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
        string metodo;
        public UsuarioAdOp()
        {
            InitializeComponent();
            metodo = "INSERTAR";
            cbTipo.SelectedIndex=0;
        }
        public UsuarioAdOp(string codigo,string nombre_usuario, string contrasenia, string curp, string nombre, string apellido, string correo, string colonia, string calle, string no_casa,string metodo,int tipo)
        {
            InitializeComponent();
            this.metodo = metodo;
            
            cbTipo.SelectedIndex = tipo;
            if (metodo == "mostrar")
            {
                lbNUsuario.Text = "DETALLES USUARIO";
                tbCodigo.Text = codigo;
                tbNombreUsuario.Text = nombre_usuario;
                tbContra.Text = contrasenia;
                tbCurp.Text = curp;
                tbNombre.Text = nombre;
                tbApellido.Text = apellido;
                tbCorreo.Text = correo;
                tbColonia.Text = colonia;
                tbCalle.Text = calle;
                tbNoCasa.Text = no_casa;


                tbCodigo.Enabled = false;
                tbNombreUsuario.Enabled = false;
                tbContra.Enabled = false;
                tbCurp.Enabled = false;
                tbNombre.Enabled = false;
                tbApellido.Enabled = false;
                tbCorreo.Enabled = false;
                tbColonia.Enabled = false;
                tbCalle.Enabled = false;
                tbNoCasa.Enabled = false;
                btAgregarU.Enabled = false;
                cbTipo.Enabled = false;
            }
            if (metodo == "modificar")
            {
                lbNUsuario.Text = "MODIFICAR USUARIO";
                tbCodigo.Text = codigo;
                tbNombreUsuario.Text = nombre_usuario;
                tbContra.Text = contrasenia;
                tbCurp.Text = curp;
                tbNombre.Text = nombre;
                tbApellido.Text = apellido;
                tbCorreo.Text = correo;
                tbColonia.Text = colonia;
                tbCalle.Text = calle;
                tbNoCasa.Text = no_casa;


                tbCodigo.Enabled = false;
                tbNombreUsuario.Enabled = true;
                tbContra.Enabled = true;
                tbCurp.Enabled = false;
                tbNombre.Enabled = true;
                tbApellido.Enabled = true;
                tbCorreo.Enabled = true;
                tbColonia.Enabled = true;
                tbCalle.Enabled = true;
                tbNoCasa.Enabled = true;
                btAgregarU.Enabled = true;
                cbTipo.Enabled = false;
                btAgregarU.Text = "ACTUALIZAR";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Usuario U = new Usuario();
            Administrador a = new Administrador();
            Operador o = new Operador();
            if (this.metodo == "INSERTAR")
            {
                U.insertUsuario(tbCodigo.Text, tbNombreUsuario.Text, tbContra.Text);
                if (cbTipo.SelectedIndex == 0)
                {
                    a.insertAdministrador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);
                }
                if (cbTipo.SelectedIndex == 1)
                {
                    o.insertOperador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);
                }
            }
            else if (this.metodo == "modificar")
            {
                U.updateUsuario(tbCodigo.Text, tbNombreUsuario.Text, tbContra.Text);
                if (cbTipo.SelectedIndex == 0)
                {
                    a.updateAdministrador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);

                }
                if (cbTipo.SelectedIndex == 1)
                {
                    o.updateOperador(tbCurp.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbColonia.Text, tbCalle.Text, tbNoCasa.Text, tbCodigo.Text);

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
