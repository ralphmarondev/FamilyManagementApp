using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace MyApp.Core.Database
{
    public static class DatabaseContext
    {
        private static readonly string dbPath = Path.Combine(
            AppContext.BaseDirectory,
           "church.db");

        private static readonly string connectionString = $"Data Source={dbPath}";

        public static string ConnectionString => connectionString;

        public static void Initialize()
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Families (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    CreateDate TEXT NOT NULL,
                    UpdateDate TEXT NOT NULL,
                    IsDeleted INTEGER NOT NULL DEFAULT 0
                );
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Email TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    FamilyId INTEGER,
                    FOREIGN KEY(FamilyId) REFERENCES Families(Id)
                );
            ";
            cmd.ExecuteNonQuery();
        }
    }
}
