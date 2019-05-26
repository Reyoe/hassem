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
            
			dataGridView1.DataSource = Conexion.query("SELECT * FROM PERIODICO");
		}

		private void BtnUsuario_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:USUARIO";
			moduloActual = "USUARIO";
            //dataGridView1.DataSource = Conexion.query("SELECT usuario.nombre_usuario,admistrator.nombre FROM usuario INNER JOIN  ON usuario.codigo = administrator.codigo_usuario;");
        }

		private void BtnLibro_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:LIBRO";
			moduloActual = "LIBRO";
			dataGridView1.DataSource = Conexion.query("SELECT * FROM LIBRO");
		}

		private void BtnRevista_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:REVISTA";
			moduloActual = "REVISTA";
			dataGridView1.DataSource = Conexion.query("SELECT * FROM REVISTA");
		}

		private void BtnVideo_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:VIDEO";
			moduloActual = "VIDEO";
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
			}
			else if (moduloActual == "LIBRO")
			{
				LibroForm myFormLib = new LibroForm();
				myFormLib.ShowDialog();
			}
			else if (moduloActual == "REVISTA")
			{
				RevistaForm myFormRev = new RevistaForm();
				myFormRev.ShowDialog();
			}
			else if (moduloActual == "VIDEO")
			{
				VideoForm myFormVid = new VideoForm();
				myFormVid.ShowDialog();
			}
			else if(moduloActual == "PERIODICO")
			{
				PeriodicoForm myFormPer = new PeriodicoForm();
				myFormPer.ShowDialog();
			}
			
		}

		private void C_Click(object sender, EventArgs e)
		{
			label1.Text = "MODULO:CLIENTE";
			moduloActual = "CLIENTE";
			dataGridView1.DataSource = Conexion.query("SELECT * FROM CLIENTE");
		}

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (moduloActual == "USUARIO")
            {
              // DataTable us = us.(textUser.Text, textPassword.Text);
                UsuarioAdOp myusuarioAdOp = new UsuarioAdOp();
                myusuarioAdOp.ShowDialog();
            }
            else if (moduloActual == "CLIENTE")
            { 
                
                ClienteForm myFormClie = new ClienteForm();
                myFormClie.ShowDialog();
            }
            else if (moduloActual == "LIBRO")
            {
                LibroForm myFormLib = new LibroForm();
                myFormLib.ShowDialog();
            }
            else if (moduloActual == "REVISTA")
            {
                RevistaForm myFormRev = new RevistaForm();
                myFormRev.ShowDialog();
            }
            else if (moduloActual == "VIDEO")
            {
                VideoForm myFormVid = new VideoForm();
                myFormVid.ShowDialog();
            }
            else if (moduloActual == "PERIODICO")
            {
                PeriodicoForm myFormPer = new PeriodicoForm();
                myFormPer.ShowDialog();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (moduloActual == "USUARIO")
            {
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
                    MessageBox.Show("Cliente eliminado con exito");

                }
                else
                {
                    MessageBox.Show("No exixten clientes");

                }
                dataGridView1.DataSource = Conexion.query("SELECT * FROM cliente");
                dataGridView1.DataSource = Conexion.query("SELECT * FROM libro");
            }
            else if (moduloActual == "REVISTA")
            {
                Revista d = new Revista();
                d.deleteRevista(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM revista");
            }
            else if (moduloActual == "VIDEO")
            {
                Video d = new Video();
                d.deleteVideo(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM video");
            }
            else if (moduloActual == "PERIODICO")
            {
                Periodico d = new Periodico();
                d.deletePeriodico(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM periodico");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (moduloActual == "USUARIO")
            {
            }
            else if (moduloActual == "CLIENTE")
            {
                Cliente d = new Cliente();
                //d.deleteCliente(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM cliente");
            }
            else if (moduloActual == "LIBRO")
            {
                Libro d = new Libro();
                //d.deleteLibro(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM libro");
            }
            else if (moduloActual == "REVISTA")
            {
                Revista d = new Revista();
               // d.deleteRevista(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM revista");
            }
            else if (moduloActual == "VIDEO")
            {
                Video d = new Video();
                //d.deleteVideo(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM video");
            }
            else if (moduloActual == "PERIODICO")
            {
                Periodico d = new Periodico();
               // d.deletePeriodico(tbCodigo.Text);
                dataGridView1.DataSource = Conexion.query("SELECT * FROM periodico");
            }
        }

 
    }
}
