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
        public string UserIDString { get; set; }
        public int UserID { get; set; }

        public VideoListForm()
        {
            InitializeComponent();
        }

        private void VideoListForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + CurrentUser;
            UserID = AccountDB.GetUserIDByName(CurrentUser);

            // TODO: This line of code loads data into the 'databaseDataSet.Accounts' table. You can move, or remove it, as needed.
            // this.accountsTableAdapter.Fill(this.databaseDataSet.Accounts);

            // TODO: This line of code loads data into the 'databaseDataSet.Videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, UserID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void fillByUserIDToolStripButton_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                this.videosTableAdapter.FillByUserID(this.databaseDataSet.Videos, ((int)(System.Convert.ChangeType(accountIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }
    }
}
