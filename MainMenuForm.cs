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
	public partial class MainMenuForm : Form
	{
        Libro myLibro= new Libro();
        string moduloActual = "USUARIO";
		public MainMenuForm()
		{
			InitializeComponent();
		}
        
        
        private void BtnPeriodico_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:PERIODICO";
			moduloActual = "PERIODICO";
            cbOp.Items.Clear();
            string[] opc = new string[] { "Id", "Editorial", "Nombre_autor","Apellido_autor","titulo","Año","Cantidad","Secciones"};
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;
            
			dataGridView1.DataSource = Conexion.query("SELECT * FROM PERIODICO");
		}

		private void BtnUsuario_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:USUARIO";
			moduloActual = "USUARIO";
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;

            dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,administrador.curp,administrador.apellido, administrador.correo,administrador.colonia,administrador.calle, administrador.no_casa FROM usuario INNER JOIN administrador WHERE usuario.codigo = administrador.codigo_usuario;");
        }

		private void BtnLibro_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:LIBRO";
			moduloActual = "LIBRO";
            cbOp.Items.Clear();
            string[] opc = new string[] { "Isbn", "Edicion", "Editorial", "No_paginas", "Nombre_Autor", "Apellido_autor","Titulo","Año", "Cantidad"};
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;
            btnDevolucion.Enabled = false;
            btnPrestamo.Enabled = false;


            dataGridView1.DataSource = Conexion.query("SELECT * FROM LIBRO");
		}

		private void BtnRevista_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:REVISTA";
			moduloActual = "REVISTA";
            cbOp.Items.Clear();
            string[] opc = new string[] { "Id", "Editorial", "No_paginas", "Nombre_Autor", "Apellido_autor", "Titulo", "Año", "Cantidad" };
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;

            dataGridView1.DataSource = Conexion.query("SELECT * FROM REVISTA");
		}

		private void BtnVideo_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:VIDEO";
			moduloActual = "VIDEO";
            cbOp.Items.Clear();
            string[] opc = new string[] { "Id", "Editorial", "Nombre_Autor", "Apellido_autor", "Titulo", "Año"};
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;

            dataGridView1.DataSource = Conexion.query("SELECT * FROM VIDEO");
		}
        
		private void BtnAgregar_Click(object sender, EventArgs e)
		{
			if (moduloActual == "USUARIO") {
                UsuarioAdOp myusuarioAdOp = new UsuarioAdOp();
                myusuarioAdOp.ShowDialog();

            }
			else if (moduloActual == "CLIENTE")
			{
				ClienteForm myFormClie = new ClienteForm();
				myFormClie.ShowDialog();
                dataGridView1.DataSource = Conexion.query("SELECT * FROM cliente");
            }
			else if (moduloActual == "LIBRO")
			{
				LibroForm myFormLib = new LibroForm();
				myFormLib.ShowDialog();
                dataGridView1.DataSource = Conexion.query("SELECT * FROM libro");
            }
			else if (moduloActual == "REVISTA")
			{
				RevistaForm myFormRev = new RevistaForm();
				myFormRev.ShowDialog();
                dataGridView1.DataSource = Conexion.query("SELECT * FROM revista");
            }
			else if (moduloActual == "VIDEO")
			{
				VideoForm myFormVid = new VideoForm();
				myFormVid.ShowDialog();
                dataGridView1.DataSource = Conexion.query("SELECT * FROM VIDEO");
            }
			else if(moduloActual == "PERIODICO")
			{
				PeriodicoForm myFormPer = new PeriodicoForm();
				myFormPer.ShowDialog();
                dataGridView1.DataSource = Conexion.query("SELECT * FROM PERIODICO");
            }
			
		}

		private void C_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:CLIENTE";
			moduloActual = "CLIENTE";
            cbOp.Items.Clear();
            string[] opc = new string[] { "CURP","Nombre", "Apellido", "Correo", "Colonia", "Calle","No_casa" };
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;

            dataGridView1.DataSource = Conexion.query("SELECT * FROM CLIENTE");
		}

        private void BtnVer_Click(object sender, EventArgs e)
        {
            string curp, nombre, apellido, correo, colonia, calle, no, isbn, edicion, id, editorial, paginas, titulo, año,cantidad,secciones;
            if (moduloActual == "USUARIO")
            {
              // DataTable us = us.(textUser.Text, textPassword.Text);
                UsuarioAdOp myusuarioAdOp = new UsuarioAdOp();
                myusuarioAdOp.ShowDialog();
            }
            else if (moduloActual == "CLIENTE")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    curp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    correo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    colonia = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    calle = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    no = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    ClienteForm myFormClie = new ClienteForm(curp, nombre, apellido, correo, colonia, calle, no,"mostrar");
                    myFormClie.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existen clientes que mostrar");
                }
            }
            else if (moduloActual == "LIBRO")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    isbn = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    edicion = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    paginas = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    cantidad = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    LibroForm myFormLib = new LibroForm(isbn, edicion, editorial, paginas, nombre, apellido, titulo, año, cantidad,"mostrar");
                    myFormLib.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existen libros que mostrar");
                }
                
            }
            else if (moduloActual == "REVISTA")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    paginas = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    cantidad = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    RevistaForm myFormRev = new RevistaForm(id,editorial, paginas, nombre, apellido, titulo, año, cantidad,"mostrar");
                    myFormRev.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existen revistas que mostrar");
                }
            }
            else if (moduloActual == "VIDEO")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    VideoForm myFormVid = new VideoForm(id,editorial, nombre, apellido, titulo, año,"mostrar");
                    myFormVid.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay videos que mostrar");
                }
                
            }
            else if (moduloActual == "PERIODICO")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    paginas = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    cantidad = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    secciones = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    PeriodicoForm myFormPer = new PeriodicoForm(id,editorial, paginas, nombre, apellido, titulo, año, cantidad, secciones,"mostrar");
                    myFormPer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existen periodicos que mostrar");
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (moduloActual == "USUARIO")
            {
                Usuario u = new Usuario();
                Administrador a = new Administrador();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    a.deleteAdministrador(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    u.deleteUsuario(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Usuario y administrador eliminado con exito");

                }
                else
                {
                    MessageBox.Show("No exixten usuarios");

                }
                dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,administrador.curp,administrador.apellido, administrador.correo,administrador.colonia,administrador.calle, administrador.no_casa FROM usuario INNER JOIN administrador WHERE usuario.codigo = administrador.codigo_usuario;");

            }
            else if (moduloActual == "CLIENTE")
            {
                Cliente d= new Cliente();
                if (dataGridView1.SelectedRows.Count> 0)
                {
                   d.deleteCliente(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Cliente eliminado con exito");
                
                }
                else
                {
                   MessageBox.Show("No exixten clientes");
                
                }
                dataGridView1.DataSource = Conexion.query("SELECT * FROM cliente");
            }
            else if (moduloActual == "LIBRO")
            {
                Libro d = new Libro();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    d.deleteLibro(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Libro eliminado con exito");

                }
                else
                {
                    MessageBox.Show("No existen libros");

                }
                dataGridView1.DataSource = Conexion.query("SELECT * FROM libro");
            }
            else if (moduloActual == "REVISTA")
            {
                Revista d = new Revista();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    d.deleteRevista(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Revista eliminado con exito");

                }
                else
                {
                    MessageBox.Show("No existen revistas");

                }
                dataGridView1.DataSource = Conexion.query("SELECT * FROM revista");
            }
            else if (moduloActual == "VIDEO")
            {
                Video d = new Video();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    d.deleteVideo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Video eliminado con exito");

                }
                else
                {
                    MessageBox.Show("No existen videos");

                }
                dataGridView1.DataSource = Conexion.query("SELECT * FROM video");
            }
            else if (moduloActual == "PERIODICO")
            {
                Periodico d = new Periodico();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    d.deletePeriodico(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Periodico eliminado con exito");
                }
                else
                {
                    MessageBox.Show("No existen periodicos");

                }
                dataGridView1.DataSource = Conexion.query("SELECT * FROM periodico");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string curp, nombre, apellido, correo, colonia, calle, no, isbn, edicion, id, editorial, paginas, titulo, año, cantidad, secciones;
            if (moduloActual == "USUARIO")
            {
            }
            else if (moduloActual == "CLIENTE")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    curp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    correo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    colonia = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    calle = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    no = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    ClienteForm myFormClie = new ClienteForm(curp, nombre, apellido, correo, colonia, calle, no, "modificar");
                    myFormClie.ShowDialog();
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM CLIENTE");
                }
                else
                {
                    MessageBox.Show("No existen clientes que modificar");
                }
            }
            else if (moduloActual == "LIBRO")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    isbn = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    edicion = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    paginas = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    cantidad = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    LibroForm myFormLib = new LibroForm(isbn, edicion, editorial, paginas, nombre, apellido, titulo, año, cantidad,"modificar");
                    myFormLib.ShowDialog();
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM LIBRO");
                }
                else
                {
                    MessageBox.Show("No existen libros que modificar");
                }

            }
            else if (moduloActual == "REVISTA")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    paginas = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    cantidad = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    RevistaForm myFormRev = new RevistaForm(id,editorial, paginas, nombre, apellido, titulo, año, cantidad,"modificar");
                    myFormRev.ShowDialog();
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM REVISTA");
                }
                else
                {
                    MessageBox.Show("No existen revistas que modificar");
                }
            }
            else if (moduloActual == "VIDEO")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    VideoForm myFormVid = new VideoForm(id, editorial, nombre, apellido, titulo, año, "modificar");
                    myFormVid.ShowDialog();
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM VIDEO");
                }
                else
                {
                    MessageBox.Show("No hay videos que modificar");
                }
            }
            else if (moduloActual == "PERIODICO")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    editorial = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    paginas = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    nombre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    apellido = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    titulo = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    año = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    cantidad = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    secciones = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    PeriodicoForm myFormPer = new PeriodicoForm(id, editorial, paginas, nombre, apellido, titulo, año, cantidad, secciones, "modificar");
                    myFormPer.ShowDialog();
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM PERIODICO");
                }
                else
                {
                    MessageBox.Show("No existen periodicos que modificar");
                }
            }
        }

        private void TbCodigo_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
