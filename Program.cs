using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            string connectionString = "Server=cmdlhrdb01;Database=5082_DB;Trusted_Connection=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                //Task 1

                using (SqlCommand command = new SqlCommand("AddStudent", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@FirstName", "Hamza");
                    command.Parameters.AddWithValue("@LastName", "Ali");
                    command.Parameters.AddWithValue("@Age", 25);
                    command.Parameters.AddWithValue("@CourseID", 1);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }


                //Task 2

                using (SqlCommand command = new SqlCommand("StudentsAge", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", 1);
                    command.Parameters.AddWithValue("@NewAge", 41);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                //Task 3
                using (SqlCommand command = new SqlCommand("DeleteStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", 1);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }



                //Task 4

                using (SqlCommand command = new SqlCommand("GetAllStudents", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, FirstName: {reader["FirstName"]},  LastName: {reader["LastName"]}, Age: {reader["Age"]}, COURSEID: {reader["COURSEID"]}");
                    }
                    connection.Close();
                }


                //Task 9;
                //1
                using (SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM Students WHERE COURSEID IS NULL; ", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"FirstName: {reader["FirstName"]},  LastName: {reader["LastName"]}");
                    }
                    connection.Close();
                }
                //2
                using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Courses ", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"CourseID: {reader["CourseID"]}");
                    }
                    connection.Close();
                }
                //3
                using (SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE (Age) > 21;", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Age: {reader["Age"]}");
                    }
                    connection.Close();
                
                }
                //4
                using (SqlCommand command = new SqlCommand("SELECT COUNT(ID) AS  TOTALSTUDENTS , AVG(AGE) AS AVERAGEAGE FROM Students GROUP BY COURSEID", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Age: {reader["Age"]}");
                    }
                    connection.Close();
                }

                //5
                using (SqlCommand command = new SqlCommand("SELECT C.COURSEID FROM Students A JOIN Courses C ON A. = C.CourseName GO ", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Age: {reader["Age"]}");
                    }
                    connection.Close();
                } 
                //6
                using (SqlCommand command = new SqlCommand("SELECT C.COURSEID FROM Students A JOIN Courses C ON A. = C.CourseName GO ", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"COURSEID: {reader["COURSEID"]}");
                    }
                    connection.Close();
                }
                //7
                using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Students WHERE Age > AVG(Age) ;  SELECT* FROM STUDENTS; ", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"FirstName: { reader["FirstName"]},  LastName: { reader["LastName"]} ");
                    }
                    connection.Close();
                }


            }
            Console.ReadKey();

            }

    }
}