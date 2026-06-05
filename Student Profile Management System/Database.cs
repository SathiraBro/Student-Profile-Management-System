using Microsoft.Data.SqlClient;


namespace Student_Profile_Management_System
{
    public class Database
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDB;Integrated Security=True;";

        
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
