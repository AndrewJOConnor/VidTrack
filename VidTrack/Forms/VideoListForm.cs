using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VidTrack.Data;
using VidTrack.Classes;


namespace VidTrack.Forms
{
    public partial class VideoListForm : Form
    {
        public string CurrentUser { get; set; }
        public int UserID { get; set; }
        public Video selectedVideo { get; set; }

        public VideoListForm()
        {
            InitializeComponent();
        }

        private void VideoListForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + CurrentUser + "!";
            UserID = AccountDB.GetUserIDByName(CurrentUser);

            // TODO: This line of code loads data into the 'databaseDataSet.Accounts' table. You can move, or remove it, as needed.
            // this.accountsTableAdapter.Fill(this.databaseDataSet.Accounts);

            // TODO: This line of code loads data into the 'databaseDataSet.Videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, UserID);
        }

        private void btnNewVideo_Click(object sender, EventArgs e)
        {
            var newVidWindow = new Forms.VideoDetails();
            newVidWindow.UserID = UserID;
            newVidWindow.editing = false;
            newVidWindow.ShowDialog();
            this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, UserID);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form logInWindow = new Form1();
            logInWindow.Show();
            this.Close();
        }

        private void btnEditVideo_Click(object sender, EventArgs e)
        {
            int videoID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            // This was for debugging purposes.
            // lblWelcome.Text = videoID.ToString();

            selectedVideo = VideoDB.GetVideoByID(videoID);

            var newVidWindow = new Forms.VideoDetails();
            newVidWindow.UserID = UserID;
            newVidWindow.video = selectedVideo;
            newVidWindow.video.VideoID = videoID;
            newVidWindow.editing = true;
            newVidWindow.ShowDialog();
            this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, UserID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int videoID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string videoName = (string)dataGridView1.SelectedRows[0].Cells[1].Value;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete \"" + videoName.Trim() + "\"?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                VideoDB.DeleteVideo(videoID);
            }

            this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, UserID);
        }
    }
}
