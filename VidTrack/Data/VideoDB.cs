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
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------







        //---- GET VIDEO BY ID ------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static Video GetVideoByID(int id)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "SELECT title, seriesName, episodeNumber, recorded, edited, rendered, thumbnailMade, uploaded FROM Videos WHERE vidID = @vidID";

            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@vidID", id);
                command.CommandType = CommandType.Text;

                var result = command.ExecuteReader();

                if (result.Read())
                {
                    var title = Convert.ToString(result["title"]);
                    var series = Convert.ToString(result["seriesName"]);
                    var episode = Convert.ToInt32(result["episodeNumber"]);
                    var recorded = Convert.ToString(result["recorded"]).Trim();
                    var edited = Convert.ToString(result["edited"]).Trim();
                    var rendered = Convert.ToString(result["rendered"]).Trim();
                    var thumbnailMade = Convert.ToString(result["thumbnailMade"]).Trim();
                    var uploaded = Convert.ToString(result["uploaded"]).Trim();

                    Video video = new Video(title, series, episode, recorded, edited, rendered, thumbnailMade, uploaded);
                    return video;
                }
                else
                {
                    return null;
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






        //---- UPDATE VIDEO BY ID ---------------------------------------------------------------------------------------------------------------------------------------------------------

        public static void UpdateVideo(int vidID, string vidTitle, string vidSeriesName, int vidEpisodeNumber, string vidRecorded, string vidEdited, string vidRendered, string vidThumbnailMade, string vidUploaded)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wammy\source\repos\VidTrack\VidTrack\Data\Database.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;

            string sqlStatement = "UPDATE Videos " +
                                  "SET title = @vidTitle, seriesName = @vidSeriesName, episodeNumber = @vidEpisodeNumber, " +
                                  "recorded = @vidRecorded, edited = @vidEdited, rendered = @vidRendered, " +
                                  "thumbnailMade = @vidThumbnailMade, uploaded = @vidUploaded " +
                                  "WHERE vidID = @vidID";

            try
            {
                connection.Open();
                command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@vidID", vidID);
                command.Parameters.AddWithValue("@vidTitle", vidTitle);
                command.Parameters.AddWithValue("@vidSeriesName", vidSeriesName);
                command.Parameters.AddWithValue("@vidEpisodeNumber", vidEpisodeNumber);
                command.Parameters.AddWithValue("@vidRecorded", vidRecorded);
                command.Parameters.AddWithValue("@vidEdited", vidEdited);
                command.Parameters.AddWithValue("@vidRendered", vidRendered);
                command.Parameters.AddWithValue("@vidThumbnailMade", vidThumbnailMade);
                command.Parameters.AddWithValue("@vidUploaded", vidUploaded);

                command.CommandType = CommandType.Text;

                var result = command.ExecuteNonQuery();
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

