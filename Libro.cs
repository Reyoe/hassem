using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
	class Libro
	{
		public void insertLibro(string isbn, string edicion, string editorial, string no_paginas, string nombre_autor, string apellido_autor, string titulo, string anio,string cantidad)
		{
			string query = "INSERT INTO libro(isbn,edicion,editorial,no_paginas,nombre_autor,apellido_autor,titulo,anio,cantidad) VALUES('" + isbn + "','" + edicion + "','" + editorial + "','" + no_paginas + "','" + nombre_autor + "','" + apellido_autor + "','" + titulo + "','" + anio+"','" + cantidad +"')";
			Console.WriteLine(query);
			Conexion.query(query); ;
		}
        public void showLibro(string isbn)
        {
            string query = "SELECT * FROM libro WHERE isbn='"+isbn+"'";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void deleteLibro(string code)
        {
            string query = "DELETE FROM libro WHERE isbn='" + code + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void updateLibro(string isbn, string edicion, string editorial, string no_paginas, string nombre_autor, string apellido_autor, string titulo, string anio, string cantidad)
        {
            string query = "UPDATE libro SET edicion='" + edicion + "',editorial='" + editorial + "',no_paginas='" + no_paginas + "',nombre_autor='" + nombre_autor + "',apellido_autor='" + apellido_autor + "',titulo='" + titulo + "',anio='" + anio + "',cantidad='" + cantidad + "' WHERE isbn='"+ isbn+"';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
    }
}
