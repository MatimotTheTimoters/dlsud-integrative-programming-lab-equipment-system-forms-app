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
        public static bool AddStudent(string studentID, string password, byte[] profilePicture, string firstName, string lastName, string gender, string course)
        {
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();

                using (SqlCommand addStudentCmd = new SqlCommand("Admin_AddStudent", sqlCon))
                {
                    addStudentCmd.CommandType = CommandType.StoredProcedure;

                    addStudentCmd.Parameters.AddWithValue("@StudentID", studentID);
                    addStudentCmd.Parameters.AddWithValue("@Password", password);
                    addStudentCmd.Parameters.Add("@ProfilePicture", SqlDbType.Image).Value = (object)profilePicture ?? DBNull.Value;
                    addStudentCmd.Parameters.AddWithValue("@FirstName", firstName);
                    addStudentCmd.Parameters.AddWithValue("@LastName", lastName);
                    addStudentCmd.Parameters.AddWithValue("@Gender", gender);
                    addStudentCmd.Parameters.AddWithValue("@Course", course);

                    int rowsAffected = addStudentCmd.ExecuteNonQuery();
                    success = rowsAffected > 0;
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

        public static bool AddEquipment(string equipmentID, string name, int quantity, string description)
        {
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand addEquipmentCmd = new SqlCommand("Admin_AddEquipment", sqlCon);
                addEquipmentCmd.CommandType = CommandType.StoredProcedure;

                addEquipmentCmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                addEquipmentCmd.Parameters.AddWithValue("@Name", name);
                addEquipmentCmd.Parameters.AddWithValue("@Quantity", quantity);
                addEquipmentCmd.Parameters.AddWithValue("@Description", description);

                int rowsAffected = addEquipmentCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }

            return success;
        }

        public static DataTable ViewEquipment()
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Admin_ViewEquipment", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static bool EditEquipment(
            string oldEquipmentID, string newEquipmentID,
            string oldName, string newName,
            int oldQuantity, int newQuantity,
            string oldDescription, string newDescription)
        {
            bool success = false;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();

                SqlCommand editEquipmentCmd = new SqlCommand("Admin_EditEquipment", sqlCon);
                editEquipmentCmd.CommandType = CommandType.StoredProcedure;

                editEquipmentCmd.Parameters.AddWithValue("@OldEquipmentID", oldEquipmentID);
                editEquipmentCmd.Parameters.AddWithValue("@NewEquipmentID", newEquipmentID);
                editEquipmentCmd.Parameters.AddWithValue("@OldName", oldName);
                editEquipmentCmd.Parameters.AddWithValue("@NewName", newName);
                editEquipmentCmd.Parameters.AddWithValue("@OldQuantity", oldQuantity);
                editEquipmentCmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                editEquipmentCmd.Parameters.AddWithValue("@OldDescription", oldDescription);
                editEquipmentCmd.Parameters.AddWithValue("@NewDescription", newDescription);

                int rowsAffected = editEquipmentCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }

            return success;
        }

        // Student methods

        public static bool RequestEquipment(string studentID, string equipmentID, int quantity, DateTime requestDate, string status)
        {
            bool success = false;

            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();

                SqlCommand requestEquipmentCmd = new SqlCommand("Student_RequestEquipment", sqlCon);
                requestEquipmentCmd.CommandType = CommandType.StoredProcedure;

                requestEquipmentCmd.Parameters.AddWithValue("@StudentID", studentID);
                requestEquipmentCmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                requestEquipmentCmd.Parameters.AddWithValue("@Quantity", quantity);
                requestEquipmentCmd.Parameters.AddWithValue("@RequestDate", requestDate);
                requestEquipmentCmd.Parameters.AddWithValue("@Status", status);

                int rowsAffected = requestEquipmentCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }

            return success;
        }
    }
}
