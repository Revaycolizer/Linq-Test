// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string [] args)
    {
        string connectionString = "server=localhost;database=db;uid=username;pwd=pwd;";

        using (MySqlConnection connection = new MySqlConnection(connectionString)){
            try{
                connection.Open();
                
            
           
               string query = args[0].ToLower(); 

                switch (query)
                {
                    case "hotel":
                        Hotel.RunQuery(connection);
                        break;

                        case "user":
                        User.RunQueryUser(connection);
                        break;
                   
                    default:
                        Console.WriteLine("Invalid query.");
                        break;
                }
            }catch(MySqlException ex){
                Console.WriteLine("Error",ex.Message);
            }
        }
    }

    



};


