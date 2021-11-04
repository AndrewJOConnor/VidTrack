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
        public int Episode { get; set; }
        public string Recorded { get; set; }
        public string Edited { get; set; }
        public string Rendered { get; set; }
        public string ThumbnailMade { get; set; }
        public string Uploaded { get; set; }
}
}
