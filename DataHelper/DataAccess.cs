using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataHelper
{
    public class DataAccess
    {
        public static string conStr = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matthew\source\repos\BIT34_StaAna_IntegProg_LabEquipmentSystem\LabEquipmentSystemForms\MasterDB.mdf;Integrated Security=True";



        /* ===========================
         *       LOGIN METHODS
         * =========================== */
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

        public static string GetStudentFullName(string studentID)
        {
            string fullName = "";
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand getNameCmd = new SqlCommand("Student_GetNameById", sqlCon);
                getNameCmd.CommandType = CommandType.StoredProcedure;
                getNameCmd.Parameters.AddWithValue("@StudentID", studentID);
                object result = getNameCmd.ExecuteScalar();
                if (result != null)
                {
                    fullName = result.ToString();
                }
            }
            return fullName.Trim();
        }


        /* ===========================
         *       ADMIN METHODS
         * =========================== */

        // Students
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

        // Equipment
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

        // Requests
        public static bool ApproveEquipmentRequest(string requestID, string adminID)
        {
            bool success = false;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand approveRequestCmd = new SqlCommand("Admin_ApproveEquipmentRequest", sqlCon);
                approveRequestCmd.CommandType = CommandType.StoredProcedure;
                approveRequestCmd.Parameters.AddWithValue("@RequestID", requestID);
                approveRequestCmd.Parameters.AddWithValue("@AdminID", adminID);
                int rowsAffected = approveRequestCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            return success;
        }

        public static bool DenyEquipmentRequest(string requestID, string adminID)
        {
            bool success = false;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand denyRequestCmd = new SqlCommand("Admin_DenyEquipmentRequest", sqlCon);
                denyRequestCmd.CommandType = CommandType.StoredProcedure;
                denyRequestCmd.Parameters.AddWithValue("@RequestID", requestID);
                denyRequestCmd.Parameters.AddWithValue("@AdminID", adminID);
                int rowsAffected = denyRequestCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            return success;
        }

        public static DataTable ViewEquipmentRequests(string status)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Admin_ViewEquipmentRequests", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Status", status);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable ViewEquipmentTransactions()
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Admin_ViewEquipmentTransactions", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        /* ===========================
         *       STUDENT METHODS
         * =========================== */
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

        public static DataTable ViewMyEquipmentRequests(string studentID, string status)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Student_ViewMyEquipmentRequests", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);
                da.SelectCommand.Parameters.AddWithValue("@Status", status);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable ViewMyEquipmentTransactions(string studentID, string status)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("Student_ViewMyEquipmentTransactions", sqlCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);
                da.SelectCommand.Parameters.AddWithValue("@Status", status);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static bool BorrowEquipment(string requestID, string studentID, DateTime dateTimeBorrowed)
        {
            bool success = false;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand borrowEquipmentCmd = new SqlCommand("Student_BorrowEquipment", sqlCon);
                borrowEquipmentCmd.CommandType = CommandType.StoredProcedure;
                borrowEquipmentCmd.Parameters.AddWithValue("@RequestID", requestID);
                borrowEquipmentCmd.Parameters.AddWithValue("@StudentID", studentID);
                borrowEquipmentCmd.Parameters.AddWithValue("@DateTimeBorrowed", dateTimeBorrowed);
                int rowsAffected = borrowEquipmentCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            return success;
        }

        public static bool ReturnEquipment(string requestID, string studentID, DateTime dateTimeReturned)
        {
            bool success = false;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                sqlCon.Open();
                SqlCommand returnEquipmentCmd = new SqlCommand("Student_ReturnEquipment", sqlCon);
                returnEquipmentCmd.CommandType = CommandType.StoredProcedure;
                returnEquipmentCmd.Parameters.AddWithValue("@RequestID", requestID);
                returnEquipmentCmd.Parameters.AddWithValue("@StudentID", studentID);
                returnEquipmentCmd.Parameters.AddWithValue("@DateTimeReturned", dateTimeReturned);
                int rowsAffected = returnEquipmentCmd.ExecuteNonQuery();
                success = rowsAffected > 0;
            }
            return success;
        }
    }
}
