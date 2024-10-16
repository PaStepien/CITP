using Npgsql;

string host = "";
string db = "";
string uid = "";
string pwd = "";

var connectionString = $"Host={host};Database={db};Username={uid};Password={pwd}";

using var connection = new NpgsqlConnection(connectionString);

connection.Open();

using var cmd = new NpgsqlCommand("select * from categories");

cmd.Connection = connection;

using var reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader.GetInt32(0));
}