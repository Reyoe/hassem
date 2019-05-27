using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Administrador
    {
        public void insertAdministrador(string curp, string nombre, string apellido, string correo, string colonia, string calle, string no_casa,string codigo)
        {
            string query = "INSERT INTO administrador(curp,nombre,apellido,correo,colonia,calle,no_casa,codigo_usuario) VALUES('" + curp + "','" + nombre + "','" + apellido + "','" + correo + "','" + colonia + "','" + calle + "','" + no_casa + "',"+codigo+")";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void deleteAdministrador(string codigo)
        {
            string query = "DELETE FROM administrador WHERE codigo_usuario='" + codigo + "';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
        public void updateAdministrador(string curp, string nombre, string apellido, string correo, string colonia, string calle, string no_casa, string codigo)
        {
            string query = "UPDATE administrador SET nombre='" + nombre + "', apellido='" + apellido + "', correo='" + correo + "', colonia='" + colonia + "', calle='" + calle + "', no_casa='" + no_casa + "', codigo_usuario='" + codigo + "' WHERE curp='"+curp+"';";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
    }
}
