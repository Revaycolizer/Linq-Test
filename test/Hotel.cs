using System;
using System.Linq;
using MySql.Data.MySqlClient;

class Hotel
{
    public static void RunQuery(MySqlConnection connection)
    {
        string query = "SELECT name FROM Hotel";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
            try{
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
            }
            }catch(MySqlException ex){
                Console.WriteLine("error",ex.Message);
            }
        }
    }
}
