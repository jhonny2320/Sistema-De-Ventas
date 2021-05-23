using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDatos
{
    public class Conexion
    {
        //desencriptar cadena de conexion
        //public static string Conectar = Convert.ToString(CapaDatos.Desencryptacion.checkServer());
        public static string Conectar = Properties.Settings.Default.cn;
            //"Data Source=JHONNY-PC\\SQLEXPRESS;Initial Catalog = SISTEMA DE VENTAS; Integrated Security = True";
        //public static string Conectar = Convert.ToString(CapaDatos.Desencryptacion.checkServer());
    }

}
