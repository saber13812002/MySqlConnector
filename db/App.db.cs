using System;
using MySql.Data.MySqlClient;

namespace MySqlConnector.Performance
{
    public class AppDb : IDisposable
    {
        public MySqlConnection Connection;

        public AppDb() //
        {			
            //Connection = new MySqlConnection(AppConfig.Config["Data:ConnectionString"]);
            string connectionString="server=s1.liara.ir;user id=root;password=jUweMpsn4qtNLA7ZOzRlLuGu;port=30618;database=homa-aseman;";
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