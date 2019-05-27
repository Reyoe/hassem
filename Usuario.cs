using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Proyecto
{
	class Usuario
	{
		public DataTable GetUsuario(String username, string password)
		{
			string query = "Select * from usuario where nombre_usuario='" + username + "' and contrasenia ='" + password+ "'";
			Console.WriteLine(query);
			Conexion.query(query);
			return Conexion.query(query); ;
		}
		public DataTable GetUsuarioById(string id)
		{
			string query = "Select * from usuario where codigo='" + id +"'";
			Console.WriteLine(query);
			Conexion.query(query);
			return Conexion.query(query);
		}
        public void insertUsuario(string codigo,string nombre,string contrasenia)
        {
            string query = "INSERT INTO usuario(codigo,nombre_usuario,contrasenia) VALUES('" + codigo + "','" + nombre + "','" + contrasenia + "');";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void deleteUsuario(string codigo)
        {
            string query = "DELETE FROM usuario WHERE codigo='" + codigo + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }

    }
}
