using MySql.Data.MySqlClient;
using PIM.Models.Permissions;
using PIM.Models.Positions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Controllers.Database
{
    public static class DatabaseController
    {

        private const string HOST = "localhost";
        private const string DATABASE = "Holerite_Pim";
        private const string USER = "root";
        private const string PASSWORD = "elielgomes123";
        private static string ConnectionString => $"server={HOST};user id={USER}; database={DATABASE}; password={PASSWORD}";
        private static MySqlConnection Connection = new MySqlConnection(ConnectionString);

        /// <summary>
        /// Method to build database tables
        /// </summary>
        public static void Create()
        {
            try
            {
                //var result = ExecuteQuery($"SHOW DATABASES LIKE '{DATABASE}';");
                var result = ExecuteQuery($"SELECT count(*) as count FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '{DATABASE}';");

                result.Read();

                long cnt = (long)result["count"];
                result.Close();

                if (cnt == 0)
                {
                    string basePath = Environment.CurrentDirectory.Replace("bin\\Debug", "SqlScripts");
                    string pimDbScript = File.ReadAllText(Path.Combine(basePath, "create_db.sql"));

                    ExecuteQuery(pimDbScript).Close();
                    Seed();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"An error occour on connect to database: {e.Message}");
            }
        }

        /// <summary>
        /// Method to Seed values into tables Cargo and Permissao
        /// </summary>
        private static void Seed()
        {
            try
            {
                List<string> seeds = new List<string>();

                foreach (EnumPositions position in Enum.GetValues(typeof(EnumPositions)))
                {
                    seeds.Add($"INSERT INTO Holerite_Pim.Cargo (Id, Nome) VALUES ({(int)position}, '{Enum.GetName(position.GetType(), position)}');");
                }

                foreach (EnumPermissions permission in Enum.GetValues(typeof(EnumPermissions)))
                {
                    seeds.Add($"INSERT INTO Holerite_Pim.Permissao (Id, Nome) VALUES ({(int)permission}, '{Enum.GetName(permission.GetType(), permission)}');");
                }

                ExecuteQuery(string.Join("\n", seeds)).Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"An error occour on connect to database: {e.Message}");
            }
        }

        /// <summary>
        /// Method to execute query and retrieve data from database
        /// </summary>
        /// <param name="sqlQuery">Raw SQL</param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteQuery(string sqlQuery)
        {
            MySqlDataReader result = null;
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = Connection,
                    CommandText = sqlQuery
                };

                result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"DatabaseController | ExecuteQuery | error: {e.Message}");
            }

            return result;
        }


    }
}
