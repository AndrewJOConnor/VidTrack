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


namespace VidTrack.Forms
{
    public partial class VideoListForm : Form
    {
        public string CurrentUser { get; set; }
        public int UserID { get; set; }

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
            newVidWindow.ShowDialog();
            this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, UserID);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form logInWindow = new Form1();
            logInWindow.Show();
            this.Close();
        }
    }
}
