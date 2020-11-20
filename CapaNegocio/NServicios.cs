
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NServicios
    {

        public static string Insertar(string Ser_servicio, decimal Ser_costo)
        {
            DServicios obj = new DServicios();
            obj.Ser_Servicio = Ser_servicio;
            obj.Ser_Costo = Ser_costo;

            return obj.Insertar(obj);
        }
        public static string Editar(int Ser_id, string Ser_servicio, decimal Ser_costo)
        {
            DServicios obj = new DServicios();
            obj.Ser_Id = Ser_id;
            obj.Ser_Servicio = Ser_servicio;
            obj.Ser_Costo = Ser_costo;

            return obj.Editar(obj);
        }
        public static string Eliminar(int Ser_id)
        {
            DServicios obj = new DServicios();
            obj.Ser_Id = Ser_id;

            return obj.Eliminar(obj);
        }

        public static DataTable Mostrar()
        {
            return new DServicios().Mostrar();
        }
        public static DataTable BuscarServicio(string textoBuscar)
        {
            DServicios obj = new DServicios();
            obj.TextoBuscar = textoBuscar;
            return obj.BuscarServicio(obj);
        }
    }
}
