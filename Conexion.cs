using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;


namespace Proyecto
{
	public static class Conexion
	{
		static MySqlConnection con;
		//static MySqlCommand comando = new MySqlCommand();
		public static string servidor;
		static string usuario;
		static string password;
		static string bd;
		//static string puerto;
		static string cadenadeconexion = "";

		static public void crearConexionLocal()
		{
			servidor = "localhost";
			usuario = "root";
			bd = "biblioteca";
			password = "";
			Conexion.cadenadeconexion = "server=" + servidor + "; user=" + usuario + "; password=" + password + "; database=" + bd + "; SslMode = none";
		}

		static public void desconectar()
		{
			con.Close();
		}

		static public void conectar()
		{
			con.Open();
		}

		static public void resetear()
		{
			con.Close();
			con.Open();
		}

		static public DataTable query(string consulta)
		{
			var dt = new DataTable();
			using (MySqlConnection connection = new MySqlConnection(Conexion.cadenadeconexion))
			{
				connection.Open();
				using (MySqlCommand command = new MySqlCommand(consulta, connection))
				using (MySqlDataReader reader = command.ExecuteReader())
				{
					dt.Load(reader);
				}
				connection.Close();
				return dt;
			}
		}


	}
}
