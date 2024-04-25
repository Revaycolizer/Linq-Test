using System;
using System.Linq;
using MySql.Data.MySqlClient;


class User{

    public static void RunQueryUser(MySqlConnection connection){

        string query="SELECT email FROM User";

        MySqlCommand cmd = new MySqlCommand(query,connection);

        using(MySqlDataReader reader = cmd.ExecuteReader()){
            try{
                while(reader.Read()){
                    Console.WriteLine(reader[0]);
                }
            }catch(MySqlException ex){
                Console.WriteLine("error",ex.Message);
            }
        }

    }
}