using System;
using System.Collections.Generic;
using Npgsql;

namespace PassMan
{
    public class DataBaseManager
    {
        private readonly NpgsqlConnection _connection;

        public DataBaseManager()
        {
            _connection =
                new NpgsqlConnection("Host=localhost;" +
                                     "Username=pwmanager;" +
                                     "Password=a0cMxicjYse6HVcx;" +
                                     "Database=pwmanager");
            _connection.Open();
        }
        
        private void ExecuteWrite(string query, Dictionary<string, object>? args)
        {
            if (string.IsNullOrEmpty(query.Trim()))
            {
                return;
            }

            using var cmd = new NpgsqlCommand(query, _connection);
            if (args != null)
            {
                foreach (var pair in args)
                {
                    cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                }
            }

            try
            {
                cmd.ExecuteNonQueryAsync();
            } catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private NpgsqlDataReader? ExecuteRead(string query, Dictionary<string, object>? args)
        {
            if (string.IsNullOrEmpty(query.Trim()))
            {
                return null;
            }

            using var cmd = new NpgsqlCommand(query, _connection);
            if (args != null)
            {
                foreach (var pair in args)
                {
                    cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                }
            }

            try
            {
                return cmd.ExecuteReader();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return null;
        }

        public void AddPassword(PasswordEntry password)
        {
            const string query = "insert into passwords (owner_id, website, username, password)" +
                                 "values (@owner_id, @website, @username, @password)";
            var args = new Dictionary<string, object>
            {
                {"@owner_id", 1},
                {"@website", password.Website},
                {"@username", password.Username},
                {"@password", password.Password},
            };
            ExecuteWrite(query, args);
        }

        public void EditPassword(PasswordEntry password)
        {
            const string query = "update passwords" + 
                                 "set website = @website, username = @username, password = @password" + 
                                 "where id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", password.Id},
                {"@website", password.Website},
                {"@username", password.Username},
                {"@password", password.Password},
            };
            ExecuteWrite(query, args);
        }

        public void DeletePassword(PasswordEntry password)
        {
            const string query = "delete from passwords" + 
                                 "where id = @id";
            var args = new Dictionary<string, object>
            {
                {"@Id", password.Id}
            };
            ExecuteWrite(query, args);
        }

        public List<PasswordEntry>? GetPasswords()
        {
            const string query = "select * from passwords";
            var reader = ExecuteRead(query, null);
            if (reader == null)
            {
                return null;
            }

            var results = new List<PasswordEntry>();
            while (reader.Read())
            {
                results.Add(new PasswordEntry(
                        reader.GetInt64(0),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    ));
            }
            return results;
        }

        public PasswordEntry? GetPassword(int id)
        {
            const string query = "select * from passwords" + 
                                 "where id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", id}
            };

            var reader = ExecuteRead(query, args);
            if (reader == null)
            {
                return null;
            }

            return new PasswordEntry(
                reader.GetInt64(0),
                reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4)
            );
        }
    }
}