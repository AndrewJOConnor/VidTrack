using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidTrack.Data
{
    class VideoDB
    {
        //---- GET VIDEOS BY USER ID ------------------------------------------------------------------------------------------------------------------------------------------------------

        public static string GetVideosOfUser(string accountID)
        {
            //int id;

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "SELECT * FROM Videos WHERE accountID = @accountID";

            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@accountID", accountID);
                command.CommandType = CommandType.Text;

                var result = command.ExecuteScalar();

                return result.ToString();

                //id = Convert.ToInt16(result);
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

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        }
    }
}

