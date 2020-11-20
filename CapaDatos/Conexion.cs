using System;

namespace CapaDatos
{
    class Conexion
    {
        //public static string Conectar = "Data Source=JHONNY-PC\\JHONATAN;Initial Catalog=SISTEMA DE VENTAS;Persist Security Info=True;User ID=jhonny;Password=admin962011";
        public static string Conectar = Convert.ToString(CapaDatos.Desencryptacion.checkServer());

    }

}
