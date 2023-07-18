using Npgsql;
using System;
using System.Data;

namespace BookManagmentSystem_C_.repository
{
    public class ConnectDB
    {
        public NpgsqlConnection connection;
        static ConnectDB connectDB = null;

        private ConnectDB()
        {
            string server = "localhost";
            string port = "5432";
            string database = "bookms";
            string username = "postgres";
            string password = "Metin598";

            string connectionString = $"server={server};port={port};database={database};username={username};password={password}";
            connection = new NpgsqlConnection(connectionString);
        }

        
        public static ConnectDB Connect()
        {
            if(connectDB == null)
            {
                connectDB = new ConnectDB();
            }

            return connectDB;

                
        }

    }
}
