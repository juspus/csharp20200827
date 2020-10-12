using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201008_KCSDatabase
{
    class Program
    {
        static SqlConnection Sql;
        static void Main(string[] args)
        {            
            var ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp20200827\\20201008 KCSDatabase\\20201008 KCSDatabase\\KcsDatabase.mdf\";Integrated Security=True";
            Sql = new SqlConnection(ConnectionString);
            //InsertStudents("Justas", "Puodzius", "+37068449321", "pastas@pastas.pastas");
            //InsertStudents("Pustas", "Juodzius", "+37068981351", "info@gmail.com");
            //InsertStudents("Gustas", "Ruodzius", "+37066819898", "grp@outlook.com");
            //InsertStudents("Guste", "Puode", "+37062216516", "kgkoero@mailas.eu");
            //InsertStudents("Goda", "Toda", "+849819541", "pastelis@pastetas.psr");

            //InsertAddressForStudent(1, "LT", "Kaunas", "Gatve", "551651");
            //InsertAddressForStudent(1, "GB", "London", "evtag", "558881");
            //InsertAddressForStudent(2, "ZB", "Miestas", "esdftag", "5468881");
            //InsertAddressForStudent(2, "GN", "Miestelis", "evtafghd", "59841");
            //InsertAddressForStudent(3, "TD", "Miestelenas", "yryvtag", "158881");
            //InsertAddressForStudent(4, "FB", "Miesteliauskas", "evtdfg", "651881");
            //InsertAddressForStudent(5, "PT", "London", "gldk", "123581");

            //InsertMarkForStudent(1, "Pirmas", 2, DateTime.Now);
            //InsertMarkForStudent(1, "Antras", 8, DateTime.UtcNow);
            //InsertMarkForStudent(2, "Pirmas", 1, DateTime.Now);
            //InsertMarkForStudent(2, "Antras", 8, DateTime.UtcNow);
            //InsertMarkForStudent(3, "Pirmas", 3, DateTime.Now);
            //InsertMarkForStudent(3, "Antras", 10, DateTime.UtcNow);
            //InsertMarkForStudent(4, "Pirmas", 5, DateTime.Now);
            //InsertMarkForStudent(4, "Antras", 9, DateTime.UtcNow);
            //InsertMarkForStudent(5, "Pirmas", 7, DateTime.Now);
            //InsertMarkForStudent(5, "Antras", 9, DateTime.UtcNow);

            //Antras Puslapis
            //GetAllStudentsAscending();
            //GetAllStudentsAsDescending();
            //GetMiestoAdresai("Kaunas");
            //GetHasPostalCode();
            //GetStudentMarksDescending();
            //NumberOfTopMarks();
            //GetAllMarksAboveThreshold(6);

            //Trecias Puslapis
            //UpdateStudentStreets("Gatv");
            //GetAllStudentsAndAdresses();
            //GetAllStudentsAndMarks();
            //GetAllCityStudentsMarksAndAdresses();
            //GetStudentsNoAddressAndMark();

            //Ketvirtas
            //GetTop5();
            //GetBestKaunas();
            //GetAllKCity();
            //GetWorst2();
            //GetPassed();
            Console.Read();
        }

        static void InsertStudents(string name, string surname, string phone, string email)
        {
            var query = "INSERT Students(Name, Surname, Phone, Email) VALUES(@Name, @Surname, @Phone, @Email)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Surname", surname);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email);
            command.ExecuteNonQuery();
            Sql.Close();
        }
        static void InsertAddressForStudent(int studentId, string country, string city, string street, string postCode) 
        {
            var query = "INSERT StudentAdresses(StudentId, Country, City, Street, PostCode) VALUES(@StudentId, @Country, @City, @Street, @PostCode)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@Country", country);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@Street", street);
            command.Parameters.AddWithValue("@PostCode", postCode);
            command.ExecuteNonQuery();
            Sql.Close();
        }
        static void InsertMarkForStudent(int studentId, string title, int mark, DateTime time)
        {
            var query = "INSERT StudentMarks(StudentId, Title, Mark, Time) VALUES(@StudentId, @Title, @Mark, @Time)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Mark", mark);
            command.Parameters.AddWithValue("@Time", time);
            command.ExecuteNonQuery();
            Sql.Close();
        }
        static void GetAllStudentsAscending()
        {
            var query = "Select * FROM Students where Phone != @Student order by Name asc";
            SqlCommand command = new SqlCommand(query, Sql);
            command.Parameters.AddWithValue("@student", "NULL");
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Phone"]}, {reader["Email"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetAllStudentsAsDescending()
        {
            var query = "Select * FROM Students where Name Like '%as' and Surname Like '%as' order by Surname desc";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Phone"]}, {reader["Email"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetMiestoAdresai(string miestas)
        {
            var query = "Select * FROM StudentAdresses where City = @City";
            SqlCommand command = new SqlCommand(query, Sql);
            command.Parameters.AddWithValue("@City", miestas);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Country"]}, {reader["City"]}, {reader["Street"]}, {reader["PostCode"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetHasPostalCode()
        {
            var query = "Select * FROM StudentAdresses where PostCode is not NULL";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Country"]}, {reader["City"]}, {reader["Street"]}, {reader["PostCode"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetStudentMarksDescending()
        {
            var query = "Select Mark FROM StudentMarks order by Mark desc";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Mark"]}";
                Console.WriteLine(outputString);
            }
        }
        static int NumberOfTopMarks()
        {
            int skaitliukas = 0;
            var query = "Select count(Mark) FROM StudentMarks where Mark = 10";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                skaitliukas = reader.GetInt32(0);
                Console.WriteLine(skaitliukas);
            }
            return skaitliukas;
        }
        static void GetAllMarksAboveThreshold(int threshold)
        {
            var query = "Select Mark FROM StudentMarks where Mark > @threshold";
            SqlCommand command = new SqlCommand(query, Sql);
            command.Parameters.AddWithValue("@threshold", threshold);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Mark"]}";
                Console.WriteLine(outputString);
            }
        }
        static void UpdateStudentStreets(string streetName)
        {
            var query = "UPDATE StudentAdresses Set Street = @street Where City in (@city1, @city2)";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            command.Parameters.AddWithValue("@street", streetName);
            command.Parameters.AddWithValue("@city1", "Kaunas");
            command.Parameters.AddWithValue("@city2", "Vilnius");
            command.ExecuteNonQuery();
            Sql.Close();
        }
        static void GetAllStudentsAndAdresses()
        {
            var query = "Select * FROM Students LEFT JOIN StudentAdresses on Students.Id = StudentAdresses.StudentId order by Name asc";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Phone"]}, {reader["Email"]}, {reader["City"]}, {reader["Country"]}, {reader["Street"]}, {reader["PostCode"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetAllStudentsAndMarks()
        {
            var query = "Select * FROM Students Right JOIN StudentMarks on Students.Id = StudentMarks.StudentId order by Mark desc";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Title"]}, {reader["Mark"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetAllCityStudentsMarksAndAdresses()
        {
            var query = "Select * FROM Students " +
                "INNER JOIN StudentMarks on Students.Id = StudentMarks.StudentId " +
                "INNER JOIN StudentAdresses on StudentMarks.StudentId = StudentAdresses.StudentId " +
                "where City = @City and Surname like '%as'";

            SqlCommand command = new SqlCommand(query, Sql);
            command.Parameters.AddWithValue("@city", "Kaunas");
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Title"]}, {reader["Mark"]}, {reader["City"]}, {reader["Country"]}, {reader["Street"]}, {reader["PostCode"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetStudentsNoAddressAndMark()
        {
            var query = "Select * FROM Students " +
                "LEFT JOIN StudentMarks on Students.Id = StudentMarks.StudentId " +
                "LEFT JOIN StudentAdresses on Students.Id = StudentAdresses.StudentId " +
                "where StudentMarks.Id is NULL and StudentAdresses.Id is null";

            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetTop5()
        {
            var query = "Select TOP 5 * FROM Students " +
                        "INNER JOIN StudentMarks on Students.Id = StudentMarks.StudentId " +
                        "Order by StudentMarks.Mark desc";

            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetBestKaunas()
        {
            var query = "Select Students.Name, Students.Surname FROM Students " +
                "INNER JOIN StudentMarks on Students.Id = StudentMarks.StudentId " +
                "INNER JOIN StudentAdresses on Students.Id = StudentAdresses.StudentId " +
                "WHERE Mark = 10 and City = 'Kaunas'";

            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Name"]}, {reader["Surname"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetAllKCity()
        {
            var query = "Select Students.Name, Students.Surname, StudentAdresses.City FROM Students " +
                "INNER JOIN StudentAdresses on Students.Id = StudentAdresses.StudentId " +
                "WHERE City like 'K%'";
            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Name"]}, {reader["Surname"]}, {reader["City"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetWorst2()
        {
            var query = "Select TOP 2 * FROM Students " +
                        "INNER JOIN StudentMarks on Students.Id = StudentMarks.StudentId " +
                        "Order by StudentMarks.Mark asc";

            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Mark"]}";
                Console.WriteLine(outputString);
            }
        }
        static void GetPassed()
        {
            var query = "Select * FROM Students " +
                        "INNER JOIN StudentMarks on Students.Id = StudentMarks.StudentId " +
                        "Where StudentMarks.Mark > 5";

            SqlCommand command = new SqlCommand(query, Sql);
            Sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string outputString = $"{reader["Id"]}, {reader["Name"]}, {reader["Surname"]}, {reader["Mark"]}";
                Console.WriteLine(outputString);
            }
        }
    }
}
