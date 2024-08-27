using System;
using Npgsql;

namespace Application
{
    public class Registerclass
    {
        public void register()
        {


                    Console.WriteLine("Enter a Username : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a Email :");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter a password :");
                    string pass = Console.ReadLine();
                   


            string connectionString = "Host=localhost;Port=5432;Database=productsdb;User Id=postgres;Password =123;";
            using NpgsqlConnection con = new NpgsqlConnection(connectionString);
            con.Open();

            // using NpgsqlCommand cmd=new NpgsqlCommand("CREATE TABLE REGISTER (id SERIAL PRIMARY KEY,name TEXT NOT NULL,email TEXT NOT NULL , password TEXT NOT NULL)",con );
           


            using NpgsqlCommand cmd= new NpgsqlCommand($"INSERT INTO REGISTER(name,email,password) VALUES (@name,@email,@password)",con);
            
            
            cmd.Parameters.AddWithValue("name",name);
            cmd.Parameters.AddWithValue("email",email);
            cmd.Parameters.AddWithValue("password",pass);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Registerd Successfully!!");
            con.Close();
            
        }

    }
}