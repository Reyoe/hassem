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
