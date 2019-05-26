using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Proyecto
{
	class Cliente
	{
		public void insertCliente(string curp, string nombre, string apellido, string correo, string colonia, string calle, string no_casa)
		{
			string query = "INSERT INTO cliente(curp,nombre,apellido,correo,colonia,calle,no_casa) VALUES('"+ curp + "','" + nombre + "','" + apellido + "','" + correo + "','" +colonia+ "','" + calle + "','" + no_casa +"')";
			Console.WriteLine(query);
			Conexion.query(query); ;
		}
        public void deleteCliente(string code)
        {
            string query = "DELETE FROM cliente WHERE curp='"+code+"';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public DataTable GetCliente(string code)
        {
            string query = "Select * from cliente where curp='" + code + "';";
            Console.WriteLine(query);
            Conexion.query(query);
            return Conexion.query(query); ;
        }
        public void updateCliente(string code)
        {
            string query = "DELETE FROM cliente WHERE curp='" + code + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
    }
}
