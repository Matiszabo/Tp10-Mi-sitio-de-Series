using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using temp.Models;
using ser.Models;
using act.Models;

namespace basee.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";
        
        public static List<Actores> TraerActores(int idS)
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Actores where idSerie = @pid";
                return db.Query<Actores>(sql, new {pid = idS }).ToList();
            }
        }
        public static List<Series> TraerSeries()
        {
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Series";
                return db.Query<Series>(sql).ToList();
            }
        }
        public static Series verInfoSerie(int idS)
        {
            Series serieActual = null;
            using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Series WHERE idSerie = @pid";
                serieActual = db.QueryFirstOrDefault<Series>(sql,new {pid = idS});
            }
            return serieActual;
        }
        public static List<Temporadas> TraerTemporadas(int idS)
        {
           using (SqlConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * from Temporadas where idSerie = @pid";
                return db.Query<Temporadas>(sql, new {pid = idS }).ToList();
            }
        }
    }
}
