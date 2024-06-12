using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class VentaData
    {
        //private string connectionString;

        //public GestorVenta()
        //{
        //    connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
        //}
        public static bool DeleteVenta(int id)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool CreateVenta(Venta venta)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Venta(Comentarios, IdUsuario)" +
                    "VALUES(@Comentarios, @IdUsuario)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static Venta GetVentaByID(int id)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int ventaId = Convert.ToInt32(reader["Id"]);
                    string comentarios = reader["Comentarios"].ToString();
                    int idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    Venta venta = new Venta(ventaId, comentarios, idUsuario);
                    return venta;
                }
                throw new Exception("Id no encontrado");
            }
        }

        public static bool UpdateVenta(Venta venta)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Venta SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);
                command.Parameters.AddWithValue("@id", venta.Id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static List<Venta> GetVenta()
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            List<Venta> listaVenta = new List<Venta>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta();
                            venta.Id = Convert.ToInt32(reader["Id"]);
                            venta.Comentarios = reader["Comentarios"].ToString();
                            venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            listaVenta.Add(venta);
                        }
                    }
                }
                return listaVenta;
            }
        }
    }
}
