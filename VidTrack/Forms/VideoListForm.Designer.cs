﻿
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
            this.databaseDataSet = new VidTrack.DatabaseDataSet();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videosTableAdapter = new VidTrack.DatabaseDataSetTableAdapters.VideosTableAdapter();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new VidTrack.DatabaseDataSetTableAdapters.AccountsTableAdapter();
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thumbnailMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(19, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(156, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, ";
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
            // lstVideos
            // 
            this.lstVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight = 20;
            this.lstVideos.Location = new System.Drawing.Point(21, 500);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.ScrollAlwaysVisible = true;
            this.lstVideos.Size = new System.Drawing.Size(800, 304);
            this.lstVideos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.episodeNumberDataGridViewTextBoxColumn,
            this.recordedDataGridViewTextBoxColumn,
            this.editedDataGridViewTextBoxColumn,
            this.renderedDataGridViewTextBoxColumn,
            this.thumbnailMadeDataGridViewTextBoxColumn,
            this.uploadedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.videosBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(66, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(703, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // videosBindingSource1
            // 
            this.videosBindingSource1.DataMember = "Videos";
            this.videosBindingSource1.DataSource = this.databaseDataSet;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Name";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // episodeNumberDataGridViewTextBoxColumn
            // 
            this.episodeNumberDataGridViewTextBoxColumn.DataPropertyName = "episodeNumber";
            this.episodeNumberDataGridViewTextBoxColumn.HeaderText = "Episode";
            this.episodeNumberDataGridViewTextBoxColumn.Name = "episodeNumberDataGridViewTextBoxColumn";
            // 
            // recordedDataGridViewTextBoxColumn
            // 
            this.recordedDataGridViewTextBoxColumn.DataPropertyName = "recorded";
            this.recordedDataGridViewTextBoxColumn.HeaderText = "Recorded";
            this.recordedDataGridViewTextBoxColumn.Name = "recordedDataGridViewTextBoxColumn";
            // 
            // editedDataGridViewTextBoxColumn
            // 
            this.editedDataGridViewTextBoxColumn.DataPropertyName = "edited";
            this.editedDataGridViewTextBoxColumn.HeaderText = "Edited";
            this.editedDataGridViewTextBoxColumn.Name = "editedDataGridViewTextBoxColumn";
            // 
            // renderedDataGridViewTextBoxColumn
            // 
            this.renderedDataGridViewTextBoxColumn.DataPropertyName = "rendered";
            this.renderedDataGridViewTextBoxColumn.HeaderText = "Rendered";
            this.renderedDataGridViewTextBoxColumn.Name = "renderedDataGridViewTextBoxColumn";
            // 
            // thumbnailMadeDataGridViewTextBoxColumn
            // 
            this.thumbnailMadeDataGridViewTextBoxColumn.DataPropertyName = "thumbnailMade";
            this.thumbnailMadeDataGridViewTextBoxColumn.HeaderText = "Thumbnail Made";
            this.thumbnailMadeDataGridViewTextBoxColumn.Name = "thumbnailMadeDataGridViewTextBoxColumn";
            // 
            // uploadedDataGridViewTextBoxColumn
            // 
            this.uploadedDataGridViewTextBoxColumn.DataPropertyName = "uploaded";
            this.uploadedDataGridViewTextBoxColumn.HeaderText = "Uploaded";
            this.uploadedDataGridViewTextBoxColumn.Name = "uploadedDataGridViewTextBoxColumn";
            // 
            // VideoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstVideos);
            this.Controls.Add(this.lblWelcome);
            this.Name = "VideoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoListForm";
            this.Load += new System.EventHandler(this.VideoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thumbnailMadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadedDataGridViewTextBoxColumn;
    }
}