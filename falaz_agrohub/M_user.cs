using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace falaz_agrohub
{
    public class M_user
    {
        string conn = "Host=localhost;Username=postgres;Password=menggokil;Database=falaz_agrohub";
        public string GetDataUser(string username, string password)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(conn))
                {
                    connection.Open();
                    string query = "SELECT role_falaz FROM user_falaz WHERE username_falaz = @username AND password_falaz = @password";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        var hasil = command.ExecuteScalar().ToString();
                        return hasil;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        public bool InsertDataUser(string username, string password)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(conn))
                {
                    connection.Open();
                    string query = "INSERT INTO user_falaz (username_falaz, password_falaz, role_falaz) VALUES (@username, @password, 'Operator')";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
