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
		public VideoForm()
		{
			myVideo = new Video();
			InitializeComponent();
		}
        public VideoForm(string editorial, string nombre, string apellido, string titulo, string año)
        {
            myVideo = new Video();
            InitializeComponent();
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
            BAgregar_Video.Enabled = false;
        }
        

        private void BAgregar_Video_Click(object sender, EventArgs e)
		{
			myVideo.insertVideo(tbEditorial.Text, tbNombre_autor.Text, tbApellido.Text, tbTitulo.Text, tbAño.Text);
		}

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
