
namespace VidTrack
{
    partial class Form1
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
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogInPassword = new System.Windows.Forms.TextBox();
            this.txtLogInUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.btnCancel);
            this.pnlLogIn.Controls.Add(this.txtNewEmail);
            this.pnlLogIn.Controls.Add(this.label8);
            this.pnlLogIn.Controls.Add(this.txtConfirmPassword);
            this.pnlLogIn.Controls.Add(this.label7);
            this.pnlLogIn.Controls.Add(this.btnCreateAccount);
            this.pnlLogIn.Controls.Add(this.label4);
            this.pnlLogIn.Controls.Add(this.txtNewPassword);
            this.pnlLogIn.Controls.Add(this.txtNewUsername);
            this.pnlLogIn.Controls.Add(this.label5);
            this.pnlLogIn.Controls.Add(this.label6);
            this.pnlLogIn.Controls.Add(this.btnRegister);
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.label3);
            this.pnlLogIn.Controls.Add(this.txtLogInPassword);
            this.pnlLogIn.Controls.Add(this.txtLogInUsername);
            this.pnlLogIn.Controls.Add(this.label2);
            this.pnlLogIn.Controls.Add(this.label1);
            this.pnlLogIn.Location = new System.Drawing.Point(-449, 12);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(981, 426);
            this.pnlLogIn.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(653, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(622, 282);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(193, 20);
            this.txtNewEmail.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email address";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(622, 209);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(193, 20);
            this.txtConfirmPassword.TabIndex = 24;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(653, 328);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(131, 23);
            this.btnCreateAccount.TabIndex = 22;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 69);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sign up";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(622, 157);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(193, 20);
            this.txtNewPassword.TabIndex = 20;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(622, 108);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(193, 20);
            this.txtNewUsername.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(192, 317);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(192, 250);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(131, 23);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to VidTrack!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.Location = new System.Drawing.Point(161, 205);
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.PasswordChar = '•';
            this.txtLogInPassword.Size = new System.Drawing.Size(193, 20);
            this.txtLogInPassword.TabIndex = 3;
            this.txtLogInPassword.UseSystemPasswordChar = true;
            // 
            // txtLogInUsername
            // 
            this.txtLogInUsername.Location = new System.Drawing.Point(161, 156);
            this.txtLogInUsername.Name = "txtLogInUsername";
            this.txtLogInUsername.Size = new System.Drawing.Size(193, 20);
            this.txtLogInUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.pnlLogIn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogInPassword;
        private System.Windows.Forms.TextBox txtLogInUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

