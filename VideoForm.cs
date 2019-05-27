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
	public partial class VideoForm : Form
	{
		Video myVideo;
        string metodo, id;
		public VideoForm()
		{
			myVideo = new Video();
			InitializeComponent();
            lBNVideo.Text = "NUEVO VIDEO";
		}
        public VideoForm(string id,string editorial, string nombre, string apellido, string titulo, string año, string metodo)
        {
            this.metodo = metodo;
            this.id = id;
            if (metodo == "mostrar")
            {
                
                myVideo = new Video();
                InitializeComponent();
                lBNVideo.Text = "DETALLES DEL VIDEO";
                tbEditorial.Text = editorial;
                tbNombre_autor.Text = nombre;
                tbApellido.Text = apellido;
                tbTitulo.Text = titulo;
                tbAño.Text = año;

                tbEditorial.Enabled = false;
                tbNombre_autor.Enabled = false;
                tbApellido.Enabled = false;
                tbTitulo.Enabled = false;
                tbAño.Enabled = false;
                tbCantidad.Enabled = false;
                BAgregar_Video.Enabled = false;
            }
            if (metodo == "modificar")
            {
                
                myVideo = new Video();
                InitializeComponent();
                lBNVideo.Text = "MODIFICAR VIDEO";
                tbEditorial.Text = editorial;
                tbNombre_autor.Text = nombre;
                tbApellido.Text = apellido;
                tbTitulo.Text = titulo;
                tbAño.Text = año;


                BAgregar_Video.Text = "MODIFICAR";
            }
        }
        

        private void BAgregar_Video_Click(object sender, EventArgs e)
		{
            if (this.metodo == "modificar")
            {
                myVideo.updateVideo(this.id,tbEditorial.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text);
            }
            else
            {
                myVideo.insertVideo(tbEditorial.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
