﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
	class Periodico
	{
		public void insertPeriodico(string editorial, string no_paginas, string nombre_autor, string apellido_autor, string titulo, string anio, string cantidad,string secciones)
		{
			string query = "INSERT INTO periodico(editorial,no_paginas,nombre_autor,apellido_autor,titulo,anio,cantidad,secciones) VALUES('" + editorial + "','" + no_paginas + "','" + nombre_autor + "','" + apellido_autor + "','" + titulo + "','" + anio + "','" + cantidad + "','" + secciones+ "')";
			Console.WriteLine(query);
			Conexion.query(query); ;
		}
        public void deletePeriodico(string code)
        {
            string query = "DELETE FROM periodico WHERE id='" + code + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
    }
}
