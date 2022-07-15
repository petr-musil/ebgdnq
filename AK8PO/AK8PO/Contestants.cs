using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace AK8PO
{
    internal static class Contestants
    {
        public static void DeleteContestant(string email)
        {
            using (var connection = new SqliteConnection("Data Source=" + Database.databaseFilename))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = "DELETE FROM contestants WHERE email = @email";
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        public static int AddContestant(Contestant newContestant)
        {
            using (var connection = new SqliteConnection("Data Source=" + Database.databaseFilename))
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = "INSERT INTO contestants VALUES (@name, @surname, @email, @age, @level)";
                command.Parameters.AddWithValue("@name", newContestant.Name);
                command.Parameters.AddWithValue("@surname", newContestant.Surname);
                command.Parameters.AddWithValue("@email", newContestant.Email);
                command.Parameters.AddWithValue("@age", newContestant.Age);
                command.Parameters.AddWithValue("@level", newContestant.Level);

                command.ExecuteNonQuery();

                connection.Close();
            }
            return 0;
        }

        internal static List<Contestant> GetAllContestants()
        {
            List<Contestant> contestantsList = new List<Contestant>();  
            

            using (SqliteConnection connection = new SqliteConnection("Data Source=" + Database.databaseFilename))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM contestants";
                SqliteDataReader sqliteDataReader = command.ExecuteReader();

                try
                {
                    while(sqliteDataReader.Read())
                    {
                        Contestant contestantElement = new Contestant(sqliteDataReader.GetString(0), sqliteDataReader.GetString(1),
                                                                      sqliteDataReader.GetString(2), sqliteDataReader.GetInt16(3),
                                                                      (ArtLevel)sqliteDataReader.GetInt16(4));
                        contestantsList.Add(contestantElement);
                    }
                }
                finally
                {
                    sqliteDataReader.Close();
                    connection.Close();
                }

                return contestantsList;                
            }
        }
    }
}
