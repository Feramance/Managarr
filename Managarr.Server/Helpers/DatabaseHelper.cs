using System.Data.SQLite;

namespace Managarr.Server.Helpers
{
    public class DatabaseHelper
    {
        private static string connectionString = @"Data Source=..\..\data\Managarr.db;Version=3";
        private static string file = @"..\..\data\Managarr.db";

        public static void InitialiseDatabase()
        {
            if (!File.Exists(file))
            {
                SQLiteConnection.CreateFile(file);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    //Create tables for data
                    string createMoviesTableQuery = @"
                        CREATE TABLE IF NOT EXISTS movies (
                            hash 
                        );";
                }
            }
        }
    }
}
