
namespace VidTrack.Forms
{
    partial class VideoDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtEpisodeNumber = new System.Windows.Forms.TextBox();
            this.chkRecorded = new System.Windows.Forms.CheckBox();
            this.chkRendered = new System.Windows.Forms.CheckBox();
            this.chkEdited = new System.Windows.Forms.CheckBox();
            this.chkUploaded = new System.Windows.Forms.CheckBox();
            this.chkThumbnailMade = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Series (Optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Episode Number (Optional)";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(49, 53);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(315, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(49, 129);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(315, 20);
            this.txtSeries.TabIndex = 9;
            // 
            // txtEpisodeNumber
            // 
            this.txtEpisodeNumber.Location = new System.Drawing.Point(49, 178);
            this.txtEpisodeNumber.Name = "txtEpisodeNumber";
            this.txtEpisodeNumber.Size = new System.Drawing.Size(61, 20);
            this.txtEpisodeNumber.TabIndex = 10;
            // 
            // chkRecorded
            // 
            this.chkRecorded.AutoSize = true;
            this.chkRecorded.Location = new System.Drawing.Point(49, 245);
            this.chkRecorded.Name = "chkRecorded";
            this.chkRecorded.Size = new System.Drawing.Size(73, 17);
            this.chkRecorded.TabIndex = 11;
            this.chkRecorded.Text = "Recorded";
            this.chkRecorded.UseVisualStyleBackColor = true;
            // 
            // chkRendered
            // 
            this.chkRendered.AutoSize = true;
            this.chkRendered.Location = new System.Drawing.Point(291, 245);
            this.chkRendered.Name = "chkRendered";
            this.chkRendered.Size = new System.Drawing.Size(73, 17);
            this.chkRendered.TabIndex = 12;
            this.chkRendered.Text = "Rendered";
            this.chkRendered.UseVisualStyleBackColor = true;
            // 
            // chkEdited
            // 
            this.chkEdited.AutoSize = true;
            this.chkEdited.Location = new System.Drawing.Point(177, 245);
            this.chkEdited.Name = "chkEdited";
            this.chkEdited.Size = new System.Drawing.Size(56, 17);
            this.chkEdited.TabIndex = 13;
            this.chkEdited.Text = "Edited";
            this.chkEdited.UseVisualStyleBackColor = true;
            // 
            // chkUploaded
            // 
            this.chkUploaded.AutoSize = true;
            this.chkUploaded.Location = new System.Drawing.Point(177, 283);
            this.chkUploaded.Name = "chkUploaded";
            this.chkUploaded.Size = new System.Drawing.Size(72, 17);
            this.chkUploaded.TabIndex = 14;
            this.chkUploaded.Text = "Uploaded";
            this.chkUploaded.UseVisualStyleBackColor = true;
            // 
            // chkThumbnailMade
            // 
            this.chkThumbnailMade.AutoSize = true;
            this.chkThumbnailMade.Location = new System.Drawing.Point(49, 283);
            this.chkThumbnailMade.Name = "chkThumbnailMade";
            this.chkThumbnailMade.Size = new System.Drawing.Size(105, 17);
            this.chkThumbnailMade.TabIndex = 15;
            this.chkThumbnailMade.Text = "Thumbnail Made";
            this.chkThumbnailMade.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(332, 343);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // VideoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 382);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkThumbnailMade);
            this.Controls.Add(this.chkUploaded);
            this.Controls.Add(this.chkEdited);
            this.Controls.Add(this.chkRendered);
            this.Controls.Add(this.chkRecorded);
            this.Controls.Add(this.txtEpisodeNumber);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VideoDetails";
            this.Text = "Video Details";
            this.Load += new System.EventHandler(this.VideoDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtEpisodeNumber;
        private System.Windows.Forms.CheckBox chkRecorded;
        private System.Windows.Forms.CheckBox chkRendered;
        private System.Windows.Forms.CheckBox chkEdited;
        private System.Windows.Forms.CheckBox chkUploaded;
        private System.Windows.Forms.CheckBox chkThumbnailMade;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}