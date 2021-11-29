using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using VidTrack.Classes;

namespace VidTrack.Data
{
    class AccountDB
    {

        //---- ADD ACCOUNT ----------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string InsertAccount(Account account)
        {
            string message;

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "INSERT INTO Accounts (username, password, email, accountType) " +
                                  "VALUES (@username, @password, @email, @accountType)";
            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@email", account.Email);
                command.Parameters.AddWithValue("@accountType", account.AccountType);

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                command.Dispose();

                message = "Account created!";
                return message;
            }
            catch (SqlException SqlError)
            {
                return SqlError.ToString();
            }
            catch (Exception error)
            {
                return error.ToString();
            }
            finally
            {
                connection.Close();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        //---- VERIFY PASSWORD ------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool VerifyPassword(string username, string password)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "SELECT * FROM Accounts WHERE username = @username AND password = @password";

            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                command.CommandType = CommandType.Text;

                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException SqlError)
            {
                throw SqlError;
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                connection.Close();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        //---- GET ACCOUNT BY USERNAME ----------------------------------------------------------------------------------------------------------------------------------------------------
        public static int GetUserIDByName(string username)
        {
            int id;

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "SELECT * FROM Accounts WHERE username = @username";

            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@username", username);
                command.CommandType = CommandType.Text;

                var result = command.ExecuteScalar();

                id = Convert.ToInt16(result);

                return id;
            }
            catch (SqlException SqlError)
            {
                throw SqlError;
            }
            catch (Exception error)
            {
                throw error;
            }
            finally
            {
                connection.Close();
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    }
}
