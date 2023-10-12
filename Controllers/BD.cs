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
        private static string _connectionString = @"Server=localhost;DataBase=Login+Registro;Trusted_Connection=True;";
        
       public static Series SeleccionarSeries()
    {
        Series todasLasSeries = new Series();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Series";
            }
        return todasLasSeries;
    }
            public static Actores SeleccionarActores()
    {
        Actores todosLosActores = new Actores();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Actores";
                    }
        return todosLosActores;
    }
           public static Temporadas SeleccionarTemporadas()
    {
        Temporadas todasLasTemporadas = new Temporadas();
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT * FROM Temporadas";
                    }
        return todasLasTemporadas;
    }
  
    }
    }
