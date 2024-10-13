using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;
using CentralProdutos.BaseDados.Entidades;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;

namespace CentralProdutos.BaseDados
{
    public static class BasedeDadosContextConnection
    {
        public static SQLiteConnection GetDatabaseConnection()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\BaseDados\baseCentralProdutos.db";
            SQLiteConnection sqliteConnection = new SQLiteConnection($"Data Source={path};Version = 3; New = False;Compress=True");
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }

    public class CentralProdutosDataContext : DbContext
    {
        public CentralProdutosDataContext() : base(BasedeDadosContextConnection.GetDatabaseConnection(), true)
        {
            //disable initializer
            Database.SetInitializer<CentralProdutosDataContext>(null);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<USUARIO> Usuario { get; set; }
    }
}