using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CheckboxDemo.Models
{
    public class Signup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool SignupToNewsletter { get; set; }
    }

    public class SignupDb
    {
        private readonly string _connectionString;

        public SignupDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Signup signup)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Signups (Name, Age, SignupToNewsletter) " +
                              "VALUES (@name, @age, @signup)";
            cmd.Parameters.AddWithValue("@name", signup.Name);
            cmd.Parameters.AddWithValue("@age", signup.Age);
            cmd.Parameters.AddWithValue("@signup", signup.SignupToNewsletter);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
