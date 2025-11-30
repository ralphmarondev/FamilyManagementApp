using Microsoft.Data.Sqlite;
using MyApp.Core.Database;
using MyApp.Core.Models;
using System;
using System.Collections.Generic;

namespace MyApp.Core.Repository
{
    public class FamilyRepository
    {
        public void AddFamily(Family family)
        {
            using var connection = new SqliteConnection(DatabaseContext.ConnectionString);
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Families (Name, CreateDate, UpdateDate, IsDeleted)
                VALUES ($name, $createDate, $updateDate, $isDeleted)";
            cmd.Parameters.AddWithValue("$name", family.Name);
            cmd.Parameters.AddWithValue("$createDate", family.CreateDate);
            cmd.Parameters.AddWithValue("$updateDate", family.UpdateDate);
            cmd.Parameters.AddWithValue("$isDeleted", family.IsDeleted ? 1 : 0);

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<Family> GetFamilies()
        {
            var families = new List<Family>();

            using var connection = new SqliteConnection(DatabaseContext.ConnectionString);
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, CreateDate, UpdateDate, IsDeleted FROM Families";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                families.Add(new Family
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    CreateDate = DateTime.Parse(reader.GetString(2)),
                    UpdateDate = DateTime.Parse(reader.GetString(3)),
                    IsDeleted = reader.GetInt32(4) == 1
                });
            }

            return families;
        }
    }
}