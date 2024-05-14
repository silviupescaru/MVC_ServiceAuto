using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;
using MVC_ServiceAuto.Model;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using MVC_ServiceAuto.Model.Language;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVAdministrator
    {
        private VAdministrator vAdministrator;
        private VLogin vLogin;
        private UserRepository userRepository;
        private Repository repository;
        private LangHelper lang;


        public ControllerVAdministrator(int index)
        {
            this.vAdministrator = new VAdministrator(index);
            this.userRepository = new UserRepository();
            this.repository = Repository.GetInstance();
            this.lang = new LangHelper();
            this.lang.Add(this.vAdministrator);

            this.eventsManagement();
        }

        public VAdministrator GetView()
        {
            this.vAdministrator.Show();
            return this.vAdministrator;
        }

        private void eventsManagement()
        {
            this.vAdministrator.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vAdministrator.GetAddButton().Click += new EventHandler(addUser);
            this.vAdministrator.GetUpdateButton().Click += new EventHandler(updateUser);
            this.vAdministrator.GetDeleteButton().Click += new EventHandler(deleteUser);
            this.vAdministrator.GetSearchButton().Click += new EventHandler(searchUser);
            this.vAdministrator.GetViewAllButton().Click += new EventHandler(viewAllUsers);
            this.vAdministrator.GetLogoutButton().Click += new EventHandler(logout);
            this.vAdministrator.GetUserTable().RowStateChanged += new DataGridViewRowStateChangedEventHandler(setUserControls);
            this.vAdministrator.GetLanguageBox().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.vAdministrator.GetLanguageBox().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.vAdministrator.GetLanguageBox().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.vAdministrator.GetLanguageBox().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }
        }

        private void addUser(object sender, EventArgs e)
        {
            try
            {
                User user = this.validInformation();

                if (user != null)
                {
                    bool result = this.userRepository.AddUser(user);
                    if (result == true)
                    {
                        MessageBox.Show(this.lang.GetString("messageBoxAddSuccess"));
                        this.resetGUIControls();

                        if (this.vAdministrator.GetUserTable() == null)
                            MessageBox.Show(this.lang.GetString("messageBoxNoData"));

                    }
                    else MessageBox.Show(this.lang.GetString("messageBoxAddFail"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateUser(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(this.vAdministrator.GetUserID().Value))
                {
                    User user = this.validInformation();
                    if (user != null)
                    {
                        bool result = this.userRepository.UpdateUser(user);
                        if (result)
                        {
                            MessageBox.Show(this.lang.GetString("messageBoxUpdateSuccess"));
                            this.resetGUIControls();
                        }
                        else MessageBox.Show(this.lang.GetString("messageBoxUpdateFail"));
                    }
                }
                else MessageBox.Show(this.lang.GetString("messageBoxNoDataSelected"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteUser(object sender, EventArgs e)
        {
            try
            {
                User user = this.validInformation();

                if (user != null)
                {
                    bool result = this.userRepository.DeleteUser((uint)this.vAdministrator.GetUserID().Value);
                    if (result == true)
                    {
                        MessageBox.Show(this.lang.GetString("messageBoxDeleteSuccess"));
                        this.resetGUIControls();

                        if (this.vAdministrator.GetUserTable() == null)
                        {
                            MessageBox.Show(this.lang.GetString("messageBoxNoData"));
                        }
                    }
                    else MessageBox.Show(this.lang.GetString("messageBoxDeleteFail"));
                }

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchUser(object sender, EventArgs e)
        {
            try
            {
                if (this.vAdministrator.GetUserTable() != null)
                    this.vAdministrator.GetUserTable().DataSource = repository.GetTable("select * from [User] where 1=0;");
                if (this.vAdministrator.GetSearch().Text != null && this.vAdministrator.GetSearch().Text.Length > 0)
                {
                    
                    List<User> list = this.userRepository.SearchUserByRole(this.vAdministrator.GetSearch().Text);

                    if (list == null)
                    {
                        MessageBox.Show(this.lang.GetString("messageBoxNoUserDesiredRole"));
                    }
                    else
                    {

                        DataTable dt = new DataTable();

                        dt.Columns.Add("userID", typeof(uint));
                        dt.Columns.Add("username", typeof(string));
                        dt.Columns.Add("password", typeof(string));
                        dt.Columns.Add("role", typeof(string));


                        foreach (User user in list)
                        {
                            DataRow row = dt.NewRow();

                            row["userID"] = user.UserID;
                            row["username"] = user.Username;
                            row["password"] = user.Password;
                            row["role"] = user.Role;

                            dt.Rows.Add(row);
                        }

                        this.vAdministrator.GetUserTable().DataSource = dt;
                    }

                }
                else MessageBox.Show(this.lang.GetString("messageBoxSearchEmpty"));
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAllUsers(object sender, EventArgs e)
        {
            try
            {
                if (this.vAdministrator.GetUserTable() != null)
                {
                    this.vAdministrator.GetUserTable().DataSource = repository.GetTable("select * from [User] where 1=0;");
                    this.vAdministrator.GetUserTable().DataSource = this.repository.GetTable("SELECT * FROM [User]");
                }

            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logout(object sender, EventArgs e)
        {
            try
            {
                ControllerVLogin login = new ControllerVLogin(1);
                login.GetView();
                this.vAdministrator.Hide();
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void setUserControls(object sender, EventArgs e)
        {
            try
            {
                if(this.vAdministrator.GetUserTable().SelectedRows.Count > 0)
                {
                    DataGridViewRow drvr = this.vAdministrator.GetUserTable().SelectedRows[0];
                    
                    uint userID = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.vAdministrator.GetUserID().Value = userID;

                    string username = drvr.Cells[1].Value.ToString();
                    this.vAdministrator.GetUsername().Text = username;

                    string password = drvr.Cells[2].Value.ToString();
                    this.vAdministrator.GetPassword().Text = password;

                    string role = drvr.Cells[3].Value.ToString();
                    this.vAdministrator.GetRole().Text = role;

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());    
            }
        }

        private User validInformation()
        {
            if (this.vAdministrator.GetUserID().Value == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxUserIDNonZero"));
                return null;
            }

            if (this.vAdministrator.GetUsername().Text == null || this.vAdministrator.GetUsername().Text.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxUsernameEmpty"));
                return null;
            }

            if (this.vAdministrator.GetPassword().Text == null || this.vAdministrator.GetPassword().Text.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxPasswordEmpty"));
                return null;
            }

            if (this.vAdministrator.GetRole().Text == null || this.vAdministrator.GetRole().Text.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxRoleEmpty"));
                return null;
            }
                return new User((uint)this.vAdministrator.GetUserID().Value, this.vAdministrator.GetUsername().Text, this.vAdministrator.GetPassword().Text, this.vAdministrator.GetRole().Text);
        }

        private void resetGUIControls()
        {
            this.vAdministrator.GetUserID().Value = 1;
            this.vAdministrator.GetUsername().Text = string.Empty;
            this.vAdministrator.GetPassword().Text = string.Empty;
            this.vAdministrator.GetRole().Text = string.Empty;
            this.vAdministrator.GetSearch().Text = string.Empty;
            this.vAdministrator.GetUserTable().DataSource = repository.GetTable("SELECT * FROM [User]");
        }
    }
}
