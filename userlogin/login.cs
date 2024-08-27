using System;
using Npgsql;

namespace Application
{
    public class Loginclass
    {
        public void login()
        {
                Console.WriteLine("Enter a Username :");
                string name= Console.ReadLine();
                Console.WriteLine("Enter a Password :");
                string pass =  Console.ReadLine();
            string connectionString = "Host=localhost;Port=5432;Database=productsdb;User Id=postgres;Password =123;";
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            con.Open();
            using NpgsqlCommand ctm = new NpgsqlCommand("select * from register where  name=@username AND password = @password",con);
          
            ctm.Parameters.AddWithValue("username", name);
            ctm.Parameters.AddWithValue("password", pass);

            using NpgsqlDataReader reader = ctm.ExecuteReader();

            if (reader.Read()){
                Console.WriteLine("Login Sucessful...!");
            }
            else{
                Console.WriteLine("Invalid username and password....!");
            }
        }
    }
}
            


