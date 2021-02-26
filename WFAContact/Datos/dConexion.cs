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
                SqlParameter nombre = new SqlParameter("@Nombres", contact.Nombres);
                SqlParameter apellido = new SqlParameter("@Apellidos", contact.Apellidos);
                SqlParameter telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter direccion  = new SqlParameter("@Direccion", contact.Direccion);

                SqlCommand command = new SqlCommand(query,conection);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(telefono);
                command.Parameters.Add(direccion);

                command.ExecuteNonQuery();

           }
            catch (Exception)
            {

                throw;
            }
            finally { conection.Close(); }
        }

        public List<lContact> getContacts()
        {
            List<lContact> contacts = new List<lContact>();
            try
            {
                conection.Open();
                string query = @"Select Id,Nombres,Apellidos,Telefono,Direccion From Contact";
                SqlCommand command = new SqlCommand(query, conection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contacts.Add(new lContact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Direccion = reader["Direccion"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conection.Close(); }
            return contacts;
        }

        public void updateContact(lContact contact)
        {
            try
            {
                conection.Open();
                //se realizara el Query(Instruccion SQL) en ves de realizarlo por un Procedimiento Almacenado
                string query = @"UPDATE Contact SET Nombres=@Nombres,Apellidos=@Apellidos,Telefono=@Telefono,Direccion=@Direccion WHERE Id=@Id";

                //esta es la forma normal por parametro y valor agregando el id 
                SqlParameter id = new SqlParameter("@Id", contact.Id);
                SqlParameter nombre = new SqlParameter("@Nombres", contact.Nombres);
                SqlParameter apellido = new SqlParameter("@Apellidos", contact.Apellidos);
                SqlParameter telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter direccion = new SqlParameter("@Direccion", contact.Direccion);

                SqlCommand command = new SqlCommand(query, conection);
                command.Parameters.Add(id);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(telefono);
                command.Parameters.Add(direccion);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conection.Close(); }

        }

        public void deleteContact(int id )
        {
            try
            {
                conection.Open();
                //se realizara el Query(Instruccion SQL) en ves de realizarlo por un Procedimiento Almacenado
                string query = @"DELETE FROM Contact WHERE Id=@Id";

              

                SqlCommand command = new SqlCommand(query, conection);
                command.Parameters.Add(new SqlParameter("@Id",id));
                

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conection.Close(); }
        }
    }
}
