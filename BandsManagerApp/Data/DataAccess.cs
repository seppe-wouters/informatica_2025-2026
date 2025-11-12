using Microsoft.Data.Sqlite;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace Data
{
    public static class DataAccess
    {
        //connectie maken
        public static string ConnectTo(string ID = "Default")
        {
            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }

        //haal op methode
        public static List<Band> HaalOp()
        {
            using (IDbConnection cnn = new SqliteConnection(ConnectTo()))
            {
                return cnn.Query<Band>("SELECT * FROM Bands").ToList();
            }
        }

        //Voeg toe methode aan db
        public static void VoegToe(Band b)
        {
            using (IDbConnection cnn = new SqliteConnection(ConnectTo()))
            {
                cnn.Execute("INSERT INTO Bands(Naam, Genre, Land, Populariteit) VALUES(@Naam, @Genre, @Land, @Populariteit)", b);
            }
        }

        //Verwijderen uit db
        public static void Verwijder(Band b)
        {
            using (IDbConnection cnn = new SqliteConnection(ConnectTo()))
            {
                cnn.Execute($"DELETE FROM Bands WHERE ID='{b.ID}'");
            }
        }
    }
}
