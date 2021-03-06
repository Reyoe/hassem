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
	public partial class MainMenuForm : Form
	{
        int tipo;
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
            comboBox1.Visible = false;

            dataGridView1.DataSource = Conexion.query("SELECT * FROM PERIODICO");
        }

		private void BtnUsuario_Click(object sender, EventArgs e)
		{
            label1.Text = "MODULO:USUARIO";
            moduloActual = "USUARIO";
            cbOp.Items.Clear();
            string[] opc = new string[] { "Codigo", "Nombre_Usuario", "CURP", "Nombre", "Apellido", "Correo", "Colonia", "Calle", "No_casa" };
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;
            comboBox1.Visible = true;
            
            comboBox1.SelectedIndex = 0;
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,usuario.contrasenia,administrador.curp,administrador.nombre,administrador.apellido, administrador.correo,administrador.colonia,administrador.calle, administrador.no_casa FROM usuario INNER JOIN administrador WHERE usuario.codigo = administrador.codigo_usuario;");
                dataGridView1.Columns[2].Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,usuario.contrasenia,operador.curp,operador.nombre,operador.apellido, operador.correo,operador.colonia,operador.calle, operador.no_casa FROM usuario INNER JOIN operador WHERE usuario.codigo = operador.codigo_usuario;");
                dataGridView1.Columns[2].Visible = false;
            }

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
            comboBox1.Visible = false;

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
            comboBox1.Visible = false;

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
            comboBox1.Visible = false;

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
            comboBox1.Visible = false;

            dataGridView1.DataSource = Conexion.query("SELECT * FROM CLIENTE");
		}

        private void BtnVer_Click(object sender, EventArgs e)
        {
            string curp, nombre, apellido, correo, colonia, calle, no, isbn, edicion, id, editorial, paginas, titulo, año,cantidad,secciones,codigo,nombre_usuario,contra;
            if (moduloActual == "USUARIO")
            {
                codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                nombre_usuario = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                contra = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                curp = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                nombre = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                apellido = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                correo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                colonia = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                calle = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                no = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                UsuarioAdOp myusuarioAdOp = new UsuarioAdOp(codigo,nombre_usuario,contra,curp,nombre,apellido,correo,colonia,calle,no,"mostrar",comboBox1.SelectedIndex);
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
                Operador o = new Operador();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        a.deleteAdministrador(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        u.deleteUsuario(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Usuario y administrador eliminado con exito");
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        o.deleteOperador(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        u.deleteUsuario(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        MessageBox.Show("Usuario y administrador eliminado con exito");
                    }
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
            string codigo, nombre_usuario, contra,curp, nombre, apellido, correo, colonia, calle, no, isbn, edicion, id, editorial, paginas, titulo, año, cantidad, secciones;
            if (moduloActual == "USUARIO")
            {
                codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                nombre_usuario = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                contra = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                curp = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                nombre = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                apellido = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                correo = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                colonia = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                calle = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                no = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                UsuarioAdOp myusuarioAdOp = new UsuarioAdOp(codigo, nombre_usuario, contra, curp, nombre, apellido, correo, colonia, calle, no, "modificar",comboBox1.SelectedIndex);
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
            CurrencyManager myCurrency = (CurrencyManager)BindingContext[dataGridView1.DataSource];

            if (moduloActual == "USUARIO")
            {
                if (this.tbCodigo.Text.Length != 0)
                {
                    if (cbOp.SelectedIndex == 0)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[0].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[1].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                //MessageBox.Show(fila.Cells[2].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 2)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[3].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 3)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[4].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 4)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[5].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 5)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[6].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 6)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[7].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 7)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[8].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 8)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[9].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                }
                else
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,usuario.contrasenia,administrador.curp,administrador.nombre,administrador.apellido, administrador.correo,administrador.colonia,administrador.calle, administrador.no_casa FROM usuario INNER JOIN administrador WHERE usuario.codigo = administrador.codigo_usuario;");
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,usuario.contrasenia,operador.curp,operador.nombre,operador.apellido, operador.correo,operador.colonia,operador.calle, operador.no_casa FROM usuario INNER JOIN operador WHERE usuario.codigo = operador.codigo_usuario;");

                    }
                }
            }
            else if (moduloActual == "LIBRO")
            {
                if (this.tbCodigo.Text.Length != 0)
                {
                    if (cbOp.SelectedIndex == 0)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[0].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[1].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                //MessageBox.Show(fila.Cells[2].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 2)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[2].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 3)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[3].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 4)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[4].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 5)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[5].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 6)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[6].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 7)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[7].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 8)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[8].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM LIBRO");
                }
            }
            else if (moduloActual == "PERIODICO")
            {
                if (this.tbCodigo.Text.Length != 0)
                {
                    if (cbOp.SelectedIndex == 0)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[0].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[1].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                //MessageBox.Show(fila.Cells[2].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 2)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[3].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 3)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[4].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 4)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[5].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 5)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[6].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 6)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[7].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 7)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[8].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM PERIODICO");
                }
            }
            else if (moduloActual == "REVISTA")
            {
                if (this.tbCodigo.Text.Length != 0)
                {
                    if (cbOp.SelectedIndex == 0)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[0].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[1].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                //MessageBox.Show(fila.Cells[2].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 2)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[3].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 3)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[4].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 4)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[5].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 5)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[6].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 6)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[7].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 7)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[8].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM REVISTA");
                }
            }
            else if (moduloActual == "VIDEO")
            {
                if (this.tbCodigo.Text.Length != 0)
                {
                    if (cbOp.SelectedIndex == 0)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[0].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[1].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                //MessageBox.Show(fila.Cells[2].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 2)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[2].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 3)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[3].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 4)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[4].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 5)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[5].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM VIDEO");
                }
            }
            else if (moduloActual == "CLIENTE")
            {
                if (this.tbCodigo.Text.Length != 0)
                {
                    if (cbOp.SelectedIndex == 0)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[0].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 1)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[1].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                //MessageBox.Show(fila.Cells[2].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 2)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[2].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 3)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[3].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 4)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[4].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 5)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[5].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                    else if (cbOp.SelectedIndex == 6)
                    {
                        foreach (DataGridViewRow fila in dataGridView1.Rows)
                        {
                            //MessageBox.Show(fila.Cells[0].RowIndex.ToString());
                            if (fila.Cells[6].Value.ToString() != tbCodigo.Text)
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = false;
                                myCurrency.ResumeBinding();
                                // MessageBox.Show(fila.Cells[0].Value.ToString(),tbCodigo.Text);
                            }
                            else
                            {
                                myCurrency.SuspendBinding();
                                fila.Visible = true;
                                myCurrency.ResumeBinding();
                            }
                        }
                    }
                }
                else
                {
                    dataGridView1.DataSource = Conexion.query("SELECT * FROM CLIENTE");
                }
            }
        }

        private void BtnEjemplar_Click(object sender, EventArgs e)
        {
            label1.Text = "MODULO:EJEMPLAR";
            moduloActual = "EJEMPLAR";
            cbOp.Items.Clear();
            string[] opc = new string[] { "id_ejemplar","isbn_libro" ,"descripcion","estado","observaciones","caducidad","status" };
            cbOp.Items.AddRange(opc);
            cbOp.SelectedIndex = 0;

            btnPrestamo.Enabled = true;
            btnDevolucion.Enabled = true;
            dataGridView1.DataSource = Conexion.query("SELECT * FROM EJEMPLAR");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,usuario.contrasenia,administrador.curp,administrador.nombre,administrador.apellido, administrador.correo,administrador.colonia,administrador.calle, administrador.no_casa FROM usuario INNER JOIN administrador WHERE usuario.codigo = administrador.codigo_usuario;");
                dataGridView1.Columns[2].Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = Conexion.query("SELECT usuario.codigo, usuario.nombre_usuario,usuario.contrasenia,operador.curp,operador.nombre,operador.apellido, operador.correo,operador.colonia,operador.calle, operador.no_casa FROM usuario INNER JOIN operador WHERE usuario.codigo = operador.codigo_usuario;");
                dataGridView1.Columns[2].Visible = false;
            }
        }
    }
}
