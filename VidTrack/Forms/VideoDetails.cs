using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VidTrack.Classes;
using VidTrack.Data;

namespace VidTrack.Forms
{
    public partial class VideoDetails : Form
    {
        public int UserID { get; set; }

        public VideoDetails()
        {
            InitializeComponent();
        }

        private void VideoDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string series = txtSeries.Text;
            string episode = txtEpisodeNumber.Text;
            bool recorded = chkRecorded.Checked;
            bool edited = chkEdited.Checked;
            bool rendered = chkRendered.Checked;
            bool thumbnailMade = chkThumbnailMade.Checked;
            bool uploaded = chkUploaded.Checked;
            int userID = UserID;

            Video video = new Video(title, series, episode, recorded, edited, rendered, thumbnailMade, uploaded, userID);
            string newVideo = VideoDB.InsertVideo(video);

            if (newVideo == "Video created!")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
