using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201008_DuomenuBazes
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp20200827\\20201008 DuomenuBazes\\20201008 DuomenuBazes\\DuomenuBaze.mdf\";Integrated Security=True";
            SqlConnection sql = new SqlConnection(ConnectionString);
            StudentuPasirinkimas(sql);
            Console.WriteLine("--------------------------");
            IrasytiVartotoja("Tomas", "Tomuxxxxx", sql);
            StudentuPasirinkimas(sql);
            Console.Read();
        }

        public static void StudentuPasirinkimas(SqlConnection sql)
        {
            string query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.WriteLine(reader["Id"]);
                Console.WriteLine(reader.GetString(2));
                Console.WriteLine(reader["Login_Name"]);
                Console.WriteLine(reader["Load"]);
            }
            sql.Close();
        }

        public static void IrasytiVartotoja(string vardas, string login, SqlConnection sql)
        {
            string query = "INSERT INTO Users (Login_Name, Name) VALUES(@Login_Name, @Name)";
            using(SqlCommand command = new SqlCommand(query, sql))
            {
                command.Parameters.AddWithValue("@Login_Name", login);
                command.Parameters.AddWithValue("@Name", vardas);
                sql.Open();
                int result = command.ExecuteNonQuery();
                sql.Close();
                if(result<0)
                {
                    throw new InvalidOperationException();
                }

            }
        }
    }
}
