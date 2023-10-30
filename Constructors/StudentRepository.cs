using System.Data.SqlClient;

namespace ADONET.Models
{
    public class StudentRepository
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Lesson;Trusted_Connection = True";

        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Student (Id, Name, Age) VALUES (@Id, @Name, @Age)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Student WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", studentId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}