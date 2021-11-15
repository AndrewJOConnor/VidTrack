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
        public Video video { get; set; }
        public bool editing { get; set; }

        public VideoDetails()
        {
            InitializeComponent();
        }

        private void VideoDetails_Load(object sender, EventArgs e)
        {
            if (editing == true)
            {
                txtTitle.Text = video.Title.Trim();
                txtSeries.Text = video.Series.Trim();
                txtEpisodeNumber.Text = video.Episode.ToString();
                
                if (video.Recorded == "Yes")      { chkRecorded.Checked      = true; } else { chkRecorded.Checked      = false; }
                if (video.Edited == "Yes")        { chkEdited.Checked        = true; } else { chkEdited.Checked        = false; }
                if (video.Rendered == "Yes")      { chkRendered.Checked      = true; } else { chkRendered.Checked      = false; }
                if (video.ThumbnailMade == "Yes") { chkThumbnailMade.Checked = true; } else { chkThumbnailMade.Checked = false; }
                if (video.Uploaded == "Yes")      { chkUploaded.Checked      = true; } else { chkUploaded.Checked      = false; }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (editing == false)
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
            else
            {
                string title = txtTitle.Text;
                string series = txtSeries.Text;
                int episode = Convert.ToInt16(txtEpisodeNumber.Text);
                string recorded;
                string edited;
                string rendered;
                string thumbnailMade;
                string uploaded;

                if (chkRecorded.Checked)      { recorded      = "Yes"; } else { recorded      = "No"; }
                if (chkEdited.Checked)        { edited        = "Yes"; } else { edited        = "No"; }
                if (chkRendered.Checked)      { rendered      = "Yes"; } else { rendered      = "No"; }
                if (chkThumbnailMade.Checked) { thumbnailMade = "Yes"; } else { thumbnailMade = "No"; }
                if (chkUploaded.Checked)      { uploaded      = "Yes"; } else { uploaded      = "No"; }

                string updateVideo = VideoDB.UpdateVideo(video.VideoID, title, series, episode, recorded, edited, rendered, thumbnailMade, uploaded);

                if (updateVideo == "Video Updated.")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }

                this.Close();
            }
        }
    }
}
