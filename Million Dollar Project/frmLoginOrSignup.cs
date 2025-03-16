using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Million_Dollar_Project
{
    public partial class frmLoginOrSignup : Form
    {
        struct stRegisterUser
        {
            public string UserName;
            public string Password;

            public stRegisterUser(string UsName,string Passw)
            {
                UserName= UsName;
                Password= Passw;
            }
        }

        string PathOfUsersFile = @"C:\Users\aymane\source\repos\programming advices\14 - C# - Level 1\Users.txt";

        public frmLoginOrSignup()
        {
            InitializeComponent();
        }

        private stRegisterUser ConvertLineUserToRecord(string Line)
        {
            List<string> UserData = new List<string>(Line.Split(new string[] { "/**/" }, StringSplitOptions.None));
            stRegisterUser stUsersData = new stRegisterUser(UserData[0], UserData[1]);
            return stUsersData;
        }

        private List<stRegisterUser> LoadUsersDataFromFile(string FilePath)
        {
            List<stRegisterUser> UsersList = new List<stRegisterUser>();
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(PathOfUsersFile))
                {
                    string Line;
                    while ((Line = reader.ReadLine()) != null)
                    {
                        UsersList.Add(ConvertLineUserToRecord(Line));
                    }
                }
            }
            return UsersList;

        }

        private bool IsUserExist(string username,string Password,bool isPasswordIncluded)
        {
            List<stRegisterUser> UsersList = new List<stRegisterUser>(LoadUsersDataFromFile(PathOfUsersFile));
            foreach(stRegisterUser User in UsersList)
            {
                if(isPasswordIncluded)
                {
                    if (User.UserName == username && User.Password == Password)
                    {
                        return true;
                    }

                }
                else
                {
                    if (User.UserName == username )
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }

        private void chkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxShowPassword.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxUserName.Text) || string.IsNullOrEmpty(tbxPassword.Text))
            {
                return; 
            }
            if(IsUserExist(tbxUserName.Text,tbxPassword.Text,true))
            {
                if(MessageBox.Show("You are logged in with successfully","Success Login",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Username/Password incorrect!", "Faild Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbxUserName.Text) || string.IsNullOrWhiteSpace(tbxUserName.Text))
            {
                e.Cancel=true;
                tbxUserName.Focus();
                errorProvider1.SetError(tbxUserName,"You don't enter your username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbxUserName, "");
            }
        }

        private void tbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                e.Cancel = true;
                tbxUserName.Focus();
                errorProvider1.SetError(tbxPassword, "You don't enter your username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbxPassword, "");
            }
        }

        private void AppendNewUserToFile(string username, string password)
        {
            File.AppendAllText(PathOfUsersFile,username+"/**/"+password+Environment.NewLine);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUserName.Text) || string.IsNullOrEmpty(tbxPassword.Text))
            {
                return;
            }
            if (!IsUserExist(tbxUserName.Text, tbxPassword.Text,false))
            {
                AppendNewUserToFile(tbxUserName.Text, tbxPassword.Text);
                if (MessageBox.Show("You are sign up in with successfully and automatically login", "Success Login", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Username is not available! ", "Faild Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
