using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidTrack.Forms
{
    public partial class VideoListForm : Form
    {
        public string CurrentUser { get; set; }

        public VideoListForm()
        {
            InitializeComponent();
        }

        private void VideoListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.databaseDataSet.Accounts);
            // TODO: This line of code loads data into the 'databaseDataSet.Videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.Fill(this.databaseDataSet.Videos);
            lblWelcome.Text = "Welcome, " + CurrentUser;
        }
    }
}
