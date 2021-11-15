
namespace VidTrack.Forms
{
    partial class VideoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new VidTrack.DatabaseDataSet();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videosTableAdapter = new VidTrack.DatabaseDataSetTableAdapters.VideosTableAdapter();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new VidTrack.DatabaseDataSetTableAdapters.AccountsTableAdapter();
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewVideo = new System.Windows.Forms.Button();
            this.btnEditVideo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbnailMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(19, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(156, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // lstVideos
            // 
            this.lstVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight = 20;
            this.lstVideos.Location = new System.Drawing.Point(19, 611);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.ScrollAlwaysVisible = true;
            this.lstVideos.Size = new System.Drawing.Size(800, 304);
            this.lstVideos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.titleDataGridViewTextBoxColumn,
            this.episodeNumberDataGridViewTextBoxColumn,
            this.recordedDataGridViewTextBoxColumn,
            this.editedDataGridViewTextBoxColumn,
            this.renderedDataGridViewTextBoxColumn,
            this.thumbnailMadeDataGridViewTextBoxColumn,
            this.uploadedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.videosBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(26, 117);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(793, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // videosBindingSource1
            // 
            this.videosBindingSource1.DataMember = "Videos";
            this.videosBindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "Videos";
            this.videosBindingSource.DataSource = this.databaseDataSet;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.databaseDataSet;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataMember = "Accounts";
            this.accountsBindingSource1.DataSource = this.databaseDataSet;
            // 
            // btnNewVideo
            // 
            this.btnNewVideo.Location = new System.Drawing.Point(728, 498);
            this.btnNewVideo.Name = "btnNewVideo";
            this.btnNewVideo.Size = new System.Drawing.Size(91, 26);
            this.btnNewVideo.TabIndex = 3;
            this.btnNewVideo.Text = "New...";
            this.btnNewVideo.UseVisualStyleBackColor = true;
            this.btnNewVideo.Click += new System.EventHandler(this.btnNewVideo_Click);
            // 
            // btnEditVideo
            // 
            this.btnEditVideo.Location = new System.Drawing.Point(623, 498);
            this.btnEditVideo.Name = "btnEditVideo";
            this.btnEditVideo.Size = new System.Drawing.Size(91, 26);
            this.btnEditVideo.TabIndex = 4;
            this.btnEditVideo.Text = "Edit...";
            this.btnEditVideo.UseVisualStyleBackColor = true;
            this.btnEditVideo.Click += new System.EventHandler(this.btnEditVideo_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(26, 498);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 26);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your videos...";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "vidID";
            this.Column1.HeaderText = "videoID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Name";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 190;
            // 
            // episodeNumberDataGridViewTextBoxColumn
            // 
            this.episodeNumberDataGridViewTextBoxColumn.DataPropertyName = "episodeNumber";
            this.episodeNumberDataGridViewTextBoxColumn.HeaderText = "Episode";
            this.episodeNumberDataGridViewTextBoxColumn.Name = "episodeNumberDataGridViewTextBoxColumn";
            this.episodeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordedDataGridViewTextBoxColumn
            // 
            this.recordedDataGridViewTextBoxColumn.DataPropertyName = "recorded";
            this.recordedDataGridViewTextBoxColumn.HeaderText = "Recorded";
            this.recordedDataGridViewTextBoxColumn.Name = "recordedDataGridViewTextBoxColumn";
            this.recordedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editedDataGridViewTextBoxColumn
            // 
            this.editedDataGridViewTextBoxColumn.DataPropertyName = "edited";
            this.editedDataGridViewTextBoxColumn.HeaderText = "Edited";
            this.editedDataGridViewTextBoxColumn.Name = "editedDataGridViewTextBoxColumn";
            this.editedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renderedDataGridViewTextBoxColumn
            // 
            this.renderedDataGridViewTextBoxColumn.DataPropertyName = "rendered";
            this.renderedDataGridViewTextBoxColumn.HeaderText = "Rendered";
            this.renderedDataGridViewTextBoxColumn.Name = "renderedDataGridViewTextBoxColumn";
            this.renderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thumbnailMadeDataGridViewTextBoxColumn
            // 
            this.thumbnailMadeDataGridViewTextBoxColumn.DataPropertyName = "thumbnailMade";
            this.thumbnailMadeDataGridViewTextBoxColumn.HeaderText = "Thumbnail Made";
            this.thumbnailMadeDataGridViewTextBoxColumn.Name = "thumbnailMadeDataGridViewTextBoxColumn";
            this.thumbnailMadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uploadedDataGridViewTextBoxColumn
            // 
            this.uploadedDataGridViewTextBoxColumn.DataPropertyName = "uploaded";
            this.uploadedDataGridViewTextBoxColumn.HeaderText = "Uploaded";
            this.uploadedDataGridViewTextBoxColumn.Name = "uploadedDataGridViewTextBoxColumn";
            this.uploadedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VideoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEditVideo);
            this.Controls.Add(this.btnNewVideo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstVideos);
            this.Controls.Add(this.lblWelcome);
            this.Name = "VideoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Videos";
            this.Load += new System.EventHandler(this.VideoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private DatabaseDataSetTableAdapters.VideosTableAdapter videosTableAdapter;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DatabaseDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
        private System.Windows.Forms.ListBox lstVideos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource videosBindingSource1;
        private System.Windows.Forms.Button btnNewVideo;
        private System.Windows.Forms.Button btnEditVideo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailMadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadedDataGridViewTextBoxColumn;
    }
}