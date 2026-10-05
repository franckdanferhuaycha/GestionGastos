using System;
using System.Collections.Generic;
using System.Text;
using GestionGastos.Config;
using GestionGastos.Models;
using Microsoft.Data.Sqlite;

namespace GestionGastos.DAO
{
    public class GastoDAO
    {
        ConexionSqlite conexionDB = new ConexionSqlite();

        public void CrearTabla()
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS gasto
                             (
                             IdGasto INTEGER PRIMARY KEY AUTOINCREMENT, 
                             Descripcion TEXT NOT NULL,
                             Categoria TEXT NOT NULL,
                             Monto REAL NOT NULL,
                             Fecha TEXT NOT NULL,  
                             MetodoPago TEXT NOT NULL
                             );";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Código para insertar datos
        public void InsertarGasto(Gasto gasto)
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"INSERT INTO gasto
                             (
                             Descripcion, 
                             Categoria,
                             Monto,
                             Fecha,  
                             MetodoPago
                             ) 
                             VALUES
                            (
                                $descripcion,
                                $categoria,
                                $monto,
                                $fecha,
                                $metodoPago
                            )";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("$descripcion", gasto.Descripcion);
                    cmd.Parameters.AddWithValue("$categoria", gasto.Categoria);
                    cmd.Parameters.AddWithValue("$monto", gasto.Monto);
                    cmd.Parameters.AddWithValue("$fecha", gasto.Fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("$metodoPago", gasto.MetodoPago);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Código para listar
        public List<Gasto> Lista()
        {
            var lista = new List<Gasto>();

            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"SELECT
                               IdGasto,
                               Descripcion,
                               Categoria,
                               Monto,
                               Fecha,
                               MetodoPago
                           FROM gasto
                           ORDER BY Fecha DESC;";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    using (var resultado = cmd.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            lista.Add(new Gasto
                            {
                                IdGasto = resultado.GetInt32(0),
                                Descripcion = resultado.GetString(1),
                                Categoria = resultado.GetString(2),
                                Monto = Convert.ToDecimal(resultado["Monto"]),
                                Fecha = Convert.ToDateTime(resultado["Fecha"]),
                                MetodoPago = resultado.GetString(5)
                            });
                        }
                    }
                }
            }

            return lista;
        }

        //este codigo para actualizar 
        public void Editar(Gasto gasto)
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"UPDATE gasto SET 
                               Descripcion = $descripcion,
                               Categoria = $categoria,
                               Monto = $monto,
                               Fecha = $fecha,
                               MetodoPago = $metodoPago
                               WHERE IdGasto = $idgasto;";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("$idgasto", gasto.IdGasto);
                    cmd.Parameters.AddWithValue("$descripcion", gasto.Descripcion);
                    cmd.Parameters.AddWithValue("$categoria", gasto.Categoria);
                    cmd.Parameters.AddWithValue("$monto", gasto.Monto);
                    cmd.Parameters.AddWithValue("$fecha", gasto.Fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("$metodoPago", gasto.MetodoPago);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // este codigo es para eliminar
        public void Eliminar(int id)
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"DELETE FROM gasto WHERE IdGasto = $id;";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("$id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
    
}