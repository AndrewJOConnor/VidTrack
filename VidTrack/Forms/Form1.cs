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

namespace VidTrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.pnlLogIn.Location = new Point(
                -449,
                this.pnlLogIn.Location.Y
            );  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pnlLogIn.Location = new Point(
                12,
                this.pnlLogIn.Location.Y
            );
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtNewUsername.Text is null || txtNewPassword.Text is null || txtConfirmPassword is null || txtNewEmail is null)
            {
                MessageBox.Show("Make sure you fill all text boxes.");
            }
            else
            {
                // If the passwords match...
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    string username = txtNewUsername.Text;
                    string password = txtNewPassword.Text;
                    string email = txtNewEmail.Text;
                    string accountType = "User";
                    Account account = new Account(username, password, email, accountType);

                    string inserted = AccountDB.InsertAccount(account);

                    if (inserted == "Account created!")
                    {
                        MessageBox.Show(inserted);
                    } else
                    {
                        // MessageBox.Show(account.Username + "\n" + account.Password + "\n" + account.AccountType + "\n" + account.Email);
                        MessageBox.Show(inserted);
                    }
                }
                // If the passwords do NOT match...
                else
                {
                    MessageBox.Show("Your passwords do not match.");
                }
                
            }
            
        }
    }
}
