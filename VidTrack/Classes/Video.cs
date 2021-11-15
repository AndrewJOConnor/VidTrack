using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VidTrack.Classes
{
    public class Video
    {
        // PROPERTIES
        public int VideoID { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public int Episode { get; set; }
        public string Recorded { get; set; }
        public string Edited { get; set; }
        public string Rendered { get; set; }
        public string ThumbnailMade { get; set; }
        public string Uploaded { get; set; }
        public int AccountID { get; set; }



        public Video(
            string title,
            string series,
            string episode,
            bool recorded,
            bool edited,
            bool rendered,
            bool thumbnailMade,
            bool uploaded,
            int userID
        )
        {
            Title = title;
            Series = series;
            Episode = Convert.ToInt16(episode);

            Recorded = "No";
            Edited = "No";
            Rendered = "No";
            ThumbnailMade = "No";
            Uploaded = "No";
            AccountID = userID;

            // SET RECORDED
            if (recorded == true)
            {
                Recorded = "Yes";
            }

            // SET EDITED
            if (edited == true)
            {
                Edited = "Yes";
            }

            // SET RENDERED
            if (rendered == true)
            {
                Rendered = "Yes";
            }

            // SET THUMBNAIL MADE
            if (thumbnailMade == true)
            {
                ThumbnailMade = "Yes";
            }

            // SET UPLOADED
            if (uploaded == true)
            {
                Uploaded = "Yes";
            }
        }



        // This is the version of the constructor used by the "GetVideoByID" Method of the VideoDB class.
        public Video(
            string title,
            string series,
            int episode,
            string recorded,
            string edited,
            string rendered,
            string thumbnailMade,
            string uploaded
        )
        {
            Title = title;
            Series = series;
            Episode = Convert.ToInt16(episode);
            Recorded = recorded;
            Edited = edited;
            Rendered = rendered;
            ThumbnailMade = thumbnailMade;
            Uploaded = uploaded;
        }
    }
}
