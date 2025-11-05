using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public class DataAccess
    {
        public static string conStr = $@"";

        // Login methods
        public static bool LoginAdmin (string adminID, string password)
        {
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(conStr)) 
            {
                sqlCon.Open();

                SqlCommand loginCmd = new SqlCommand("Login_Admin", sqlCon);
                loginCmd.CommandType = CommandType.StoredProcedure;

                loginCmd.Parameters.AddWithValue("@AdminId", adminID);
                loginCmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(loginCmd.ExecuteScalar());
                if (count >= 0)
                {
                    success = true;
                }
            }

            return success;
        }

        public static bool LoginStudent (string studentID, string password)
        {
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();

                SqlCommand loginCmd = new SqlCommand("Login_User", sqlCon);
                loginCmd.CommandType = CommandType.StoredProcedure;

                loginCmd.Parameters.AddWithValue("@StudentID", studentID);
                loginCmd.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(loginCmd.ExecuteScalar());
                if (count >= 0)
                {
                    success = true;
                }
            }

            return success;
        }

        // Admin methods
        public static bool AddStudent (string studentID, string password, string profilePicture, string firstName, string lastName, string gender, string course)
        {
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand addStudentCmd = new SqlCommand("Admin_AddStudent", sqlCon);
                addStudentCmd.CommandType = CommandType.StoredProcedure;

                addStudentCmd.Parameters.AddWithValue("@StudentID", studentID);
                addStudentCmd.Parameters.AddWithValue("@Password", password);
                addStudentCmd.Parameters.AddWithValue("@ProfilePicture", profilePicture);
                addStudentCmd.Parameters.AddWithValue("@FirstName", firstName);
                addStudentCmd.Parameters.AddWithValue("@LastName", lastName);
                addStudentCmd.Parameters.AddWithValue("@Gender", gender);
                addStudentCmd.Parameters.AddWithValue("@Course", course);

                int rowsAffected = addStudentCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    success = true;
                }
            }

            return success;
        }

        public static DataTable ViewStudents ()
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Admin_ViewStudents", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }

        }
    }
}
