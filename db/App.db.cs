using System;
using MySql.Data.MySqlClient;

namespace MySqlConnector.Performance
{
    public class AppDb : IDisposable
    {
        public MySqlConnection Connection;

        public AppDb()
        {			
            //Connection = new MySqlConnection(AppConfig.Config["Data:ConnectionString"]);
            string connectionString="server=127.0.0.1;user id=root;password=;port=3306;database=homa-aseman;";
            Connection = new MySqlConnection(connectionString);
        }

        public AppDb(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}