﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
	class Revista
	{
		public void insertRevista(string editorial, string no_paginas, string nombre_autor, string apellido_autor, string titulo, string anio, string cantidad)
		{
			string query = "INSERT INTO revista(editorial,no_paginas,nombre_autor,apellido_autor,titulo,anio,cantidad) VALUES('" + editorial + "','" + no_paginas + "','" + nombre_autor + "','" + apellido_autor + "','" + titulo + "','" + anio + "','" + cantidad + "')";
			Console.WriteLine(query);
			Conexion.query(query); ;
		}
        public void deleteRevista(string code)
        {
            string query = "DELETE FROM revista WHERE id='" + code + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void updateRevista(string id,string editorial, string no_paginas, string nombre_autor, string apellido_autor, string titulo, string anio, string cantidad)
        {
            string query = "UPDATE revista SET editorial='" + editorial + "',no_paginas='" + no_paginas + "',nombre_autor='" + nombre_autor + "',apellido_autor='" + apellido_autor + "',titulo='" + titulo + "',anio='" + anio + "',cantidad='" + cantidad + "' WHERE id='"+id+"';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
    }
}
