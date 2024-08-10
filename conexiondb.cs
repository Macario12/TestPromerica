using System;
using System.Data;
using System.Data.SqlClient;

public class ConexionDB
{
    private readonly string cadenaConexion;

    // Se recibe la cadena de conexión
    public ConexionDB(string cadenaConexion)
    {
        this.cadenaConexion = cadenaConexion;
    }

    // Ejecuta Select y devuleve el DataSet
    public DataSet EjecutarSELECT(string query)
    {
        using (SqlConnection conexion = new SqlConnection(this.cadenaConexion))
        {
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            conexion.Open();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }

    // Devuelve las filas afectadas del INSERT, UPDATE o DELETE
    public int EjecutarQueryNoFilas(string query)
    {
        using (SqlConnection conexion = new SqlConnection(this.cadenaConexion))
        {
            SqlCommand command = new SqlCommand(query, conexion);
            conexion.Open();
            int RowsAfectadas = command.ExecuteNonQuery();
            return RowsAfectadas;
        }
    }

    // Devuelve el numero de filas que ejecuta el SELECT
    public int SelectFilasObtenidas(string query)
    {
        using (SqlConnection conexion = new SqlConnection(this.cadenaConexion))
        {
            string countQuery = $"SELECT COUNT(*) FROM ({query}) AS CountQuery";
            SqlCommand command = new SqlCommand(countQuery, conexion);
            conexion.Open();
            int filas = (int)command.ExecuteScalar();
            return filas;
        }
    }
}