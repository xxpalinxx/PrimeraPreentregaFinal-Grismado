﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoData
    { 
        //private string connectionString;

        //public ProductoData()
        //{
        //    connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
        //}
        public static bool DeleteProduct(int id)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static bool CreateProduct(Producto producto)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Producto(Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" +
                    "VALUES(@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Descripciones", producto.Descripciones);
                command.Parameters.AddWithValue("@Costo", producto.Costo);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@IdUsuario", producto.IdUsuario);
                conn.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static Producto GetProductByID(int id)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int productId = Convert.ToInt32(reader["Id"]);
                    string descripcion = reader["Descripciones"].ToString();
                    double costo = Convert.ToDouble(reader["Costo"]);
                    double precioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                    int stock = Convert.ToInt32(reader["Stock"]);
                    int idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    Producto producto = new Producto(productId, descripcion, costo, precioVenta, stock, idUsuario);
                    return producto;
                }
                throw new Exception("Id no encontrado");
            }
        }
        public static bool UpdateProduct(Producto producto)
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET Descripciones = @Descripciones, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@Descripciones", producto.Descripciones);
                command.Parameters.AddWithValue("@Costo", producto.Costo);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@IdUsuario", producto.IdUsuario);
                command.Parameters.AddWithValue("@id", producto.Id);                
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static List<Producto> GetProducto()
        {
            string connectionString = "Server=.;Database=SistemaGestion;Trusted_Connection=True;";
            List<Producto> listaProductos = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Producto";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto();
                            producto.Id = Convert.ToInt32(reader["Id"]);
                            producto.Descripciones = reader["Descripciones"].ToString();
                            producto.Costo = Convert.ToDouble(reader["Costo"]);
                            producto.PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                            producto.Stock = Convert.ToInt32(reader["Stock"]);
                            producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            listaProductos.Add(producto);
                        }
                    }
                }
                return listaProductos;
            }
        }

    }
}
