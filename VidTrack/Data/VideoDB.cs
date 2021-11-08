using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidTrack.Classes;

namespace VidTrack.Data
{
    class VideoDB
    {
        //---- ADD VIDEO ------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string InsertVideo(Video video)
        {
            string message;

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "INSERT INTO Videos (title, seriesName, episodeNumber, recorded, edited, rendered, thumbnailMade, uploaded, accountID) " +
                                  "VALUES (@title, @seriesName, @episodeNumber, @recorded, @edited, @rendered, @thumbnailMade, @uploaded, @accountID)";
            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@title", video.Title);
                command.Parameters.AddWithValue("@seriesName", video.Series);
                command.Parameters.AddWithValue("@episodeNumber", video.Episode);
                command.Parameters.AddWithValue("@recorded", video.Recorded);
                command.Parameters.AddWithValue("@edited", video.Edited);
                command.Parameters.AddWithValue("@rendered", video.Recorded);
                command.Parameters.AddWithValue("@thumbnailMade", video.ThumbnailMade);
                command.Parameters.AddWithValue("@uploaded", video.Uploaded);
                command.Parameters.AddWithValue("@accountID", video.AccountID);

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                command.Dispose();

                message = "Video created!";
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

