using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
	class Video
	{
		public void insertVideo(string editorial,string nombre_autor, string apellido_autor, string titulo, string anio)
		{
			string query = "INSERT INTO video(editorial,nombre_autor,apellido_autor,titulo,anio) VALUES('" + editorial + "','" + nombre_autor + "','" + apellido_autor + "','" + titulo + "','" + anio + "')";
			Console.WriteLine(query);
			Conexion.query(query); ;
		}
        public void deleteVideo(string code)
        {
            string query = "DELETE FROM video WHERE id=" + code + ";";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }

    }
}
