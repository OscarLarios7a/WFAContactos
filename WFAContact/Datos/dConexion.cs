using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAContact.Logica;

namespace WFAContact.Datos
{
    public class dConexion
    {
        private SqlConnection conection = new SqlConnection(@"Data Source = (localdb)\AT_OAXACA; initial catalog = WFAContact; integrated Security = true;");

        //metodos de apertura y cierre de la Conexion 
        public void insertContact(lContact contact)
        {
            try
            {
                conection.Open();
                //se realizara el Query(Instruccion SQL) en ves de realizarlo por un Procedimiento Almacenado
                string query = @"insert into Contact (Nombres,Apellidos,Telefono,Direccion) Values (@Nombres,@Apellidos,@Telefono,@Direccion) ";

                ////esta es la forma extendida
                //SqlParameter nombre = new SqlParameter();
                //nombre.ParameterName = "@Nombres";
                //nombre.Value = contact.Nombres;
                //nombre.DbType = System.Data.DbType.String;

                //esta es la forma normal por parametro y valor
                SqlParameter nombre = new SqlParameter("@Apellidos", contact.Nombres);
                SqlParameter apellido = new SqlParameter("@Apellidos", contact.Apellidos);
                SqlParameter telefono = new SqlParameter("@Apellidos", contact.Telefono);
                SqlParameter direccion  = new SqlParameter("@Apellidos", contact.Direccion);

           }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
