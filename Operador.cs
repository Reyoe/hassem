using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Operador
    {
        public void insertOperador(string curp, string nombre, string apellido, string correo, string colonia, string calle, string no_casa, string codigo)
        {
            string query = "INSERT INTO operador(curp,nombre,apellido,correo,colonia,calle,no_casa,codigo_usuario) VALUES('" + curp + "','" + nombre + "','" + apellido + "','" + correo + "','" + colonia + "','" + calle + "','" + no_casa + "'," + codigo + ")";
            Console.WriteLine(query);
            Conexion.query(query); ;
        }
    }
}
