using DocumentFormat.OpenXml.Drawing.Charts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Database_2.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Database_2
{
    public class DatabaseConnection
    {
        string server = "localhost";
        string database = "schooldatabase";
        string username = "root";
        string password = "Nuha92sn8812";

        string connectionString = "";
        MySqlConnection connection;




        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

        }


        public Dictionary<int, student> GetStudents()
        {
            Dictionary<int, student> studentDictionary = new Dictionary<int, student>();

            connection.Open();

            string query = "SELECT * FROM student;";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string email = "";
                try
                {
                    email = (string)reader["email"];
                }
                catch { }

                int age = -1;
                try
                {
                    age = (int)reader["age"];
                }
                catch { }
                student student = new student((int)reader["studentid"], (string)reader["firstName"], (string)reader["lastName"], age, email);
                studentDictionary.Add(student.ID, student);
            }

            connection.Close();
            return studentDictionary;
        }


        public Dictionary<int, List<string>> GetStudentSubjects(int studentId)
        {
            Dictionary<int, List<string>> studentSubjectsDictionary = new Dictionary<int, List<string>>();

            connection.Open();

            string query = $"SELECT Subject.subjectNamn, studentsubject.Grade FROM Student LEFT JOIN studentsubject ON Student.studentid = studentsubject.studentID LEFT JOIN Subject ON studentsubject.subjectID = Subject.subjectID WHERE Student.studentid = {studentId}";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                string subjectName = reader["subjectNamn"].ToString();
                string grade = reader["Grade"].ToString();

                if (!studentSubjectsDictionary.ContainsKey(studentId))
                {
                    studentSubjectsDictionary.Add(studentId, new List<string>());
                }

                studentSubjectsDictionary[studentId].Add($"{subjectName}: {grade}");
            }

            connection.Close();
            return studentSubjectsDictionary;
        }

        public void SaveStudentToDatabase(student newStudent)
        {

            connection.Open();

            string query = $"INSERT INTO student (studentid,firstName, lastName) VALUES ({newStudent.ID}, '{newStudent.FirstName}', '{newStudent.LastName}')";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();


            connection.Close();
        }

        public Dictionary<int, student> SearchStudentsByFirstName(string searchPattern)
        {
            Dictionary<int, student> studentDictionary = new Dictionary<int, student>();

            try
            {
                connection.Open();

                string query = "SELECT * FROM Student WHERE firstName LIKE @searchPattern;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchPattern", $"%{searchPattern}%");

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int studentId = Convert.ToInt32(reader["studentid"]);
                    string firstNameFromDB = reader["firstName"].ToString();
                    string lastName = reader["lastName"].ToString();
                    int age = Convert.ToInt32(reader["age"]);
                    string email = reader["email"].ToString();

                    student student = new student(studentId, firstNameFromDB, lastName, age, email);
                    studentDictionary.Add(studentId, student);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return studentDictionary;
        }


        public bool DeleteStudent(int studentId)
        {
            try
            {

                connection.Open();


                var query = "DELETE FROM student WHERE studentid = @StudentId;";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);


                var rowsAffected = command.ExecuteNonQuery();


                connection.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fel: " + ex.Message);
                return false;
            }
        }


        public bool UpdateStudentLastName(int studentId, string newLastName)
        {
            try
            {
                connection.Open();

                string query = $"UPDATE student SET lastName = '{newLastName}' WHERE studentid = {studentId}";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fel: " + ex.Message);
                return false;
            }
        }
    }
}
























   

    

























    
























       

























































        





















   





























    

    


