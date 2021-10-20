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
        public static string InsertAccount(Account account)
        {
            string message;
            
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Data\\Database.mdf;Integrated Security=True";
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
    }
}
