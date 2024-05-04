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

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVAdministrator
    {
        private VAdministrator vAdministrator;
        private VLogin vLogin;
        private UserRepository userRepository;
        private Repository repository;

        public ControllerVAdministrator()
        {
            this.vAdministrator = new VAdministrator();
            this.userRepository = new UserRepository();
            this.repository = Repository.GetInstance();

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

        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
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
                        MessageBox.Show("Adding was successful!");
                        this.resetGUIControls();

                        if (this.vAdministrator.GetUserTable() == null)
                            MessageBox.Show("There is no user in your table!");

                    }
                    else MessageBox.Show("Adding ended with failure!");
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
                if (Convert.ToBoolean(this.vAdministrator.GetUserID()))
                {
                    User user = this.validInformation();
                    if (user != null)
                    {
                        bool result = this.userRepository.UpdateUser(user);
                        if (result)
                        {
                            MessageBox.Show("Updating was completed successfully!");
                            this.resetGUIControls();
                        }
                        else MessageBox.Show("Updating ended with failure!");
                    }
                }
                else MessageBox.Show("No user has been selected to be updated!");
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
                        MessageBox.Show("Deleting was successfull!");
                        this.resetGUIControls();

                        if (this.vAdministrator.GetUserTable() == null)
                        {
                            MessageBox.Show("There is no user in your table!");
                        }
                    }
                    else MessageBox.Show("Deleting ended with failure!");
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
                    this.vAdministrator.GetUserTable().Rows.Clear();
                if(this.vAdministrator.GetSearch().Text != null && this.vAdministrator.GetSearch().Text.Length > 0)
                {
                    List<User> list = this.userRepository.SearchUserByRole(this.vAdministrator.GetSearch().Text);
                    foreach (User user in list)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(this.vAdministrator.GetUserTable());

                        row.Cells[0].Value = user.UserID;
                        row.Cells[1].Value = user.Username;
                        row.Cells[2].Value = user.Password;
                        row.Cells[3].Value = user.Role;
                        row.Cells[4].Value = user.Language;

                        this.vAdministrator.GetUserTable().Rows.Add(row);
                    }

                }
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
                    this.vAdministrator.GetUserTable().Rows.Clear();
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
                ControllerVLogin login = new ControllerVLogin();
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

                    string language = drvr.Cells[4].Value.ToString();
                    this.vAdministrator.GetLanguage().Text = language;

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
                MessageBox.Show("User ID must be non-zero natural number!");
                return null;
            }

            if (this.vAdministrator.GetUsername().Text == null || this.vAdministrator.GetUsername().Text.Length == 0)
            {
                MessageBox.Show("Username is empty!");
                return null;
            }

            if (this.vAdministrator.GetPassword().Text == null || this.vAdministrator.GetPassword().Text.Length == 0)
            {
                MessageBox.Show("Password is empty!");
                return null;
            }

            if (this.vAdministrator.GetRole().Text == null || this.vAdministrator.GetRole().Text.Length == 0)
            {
                MessageBox.Show("Role is empty!");
                return null;
            }

            if (this.vAdministrator.GetLanguage().Text == null || this.vAdministrator.GetLanguage().Text.Length == 0)
            {
                MessageBox.Show("Language is empty!");
                return null;
            }
                return new User((uint)this.vAdministrator.GetUserID().Value, this.vAdministrator.GetUsername().Text, this.vAdministrator.GetPassword().Text, this.vAdministrator.GetRole().Text, this.vAdministrator.GetLanguage().Text);
        }

        private void resetGUIControls()
        {
            this.vAdministrator.GetUserID().Value = 1;
            this.vAdministrator.GetUsername().Text = string.Empty;
            this.vAdministrator.GetPassword().Text = string.Empty;
            this.vAdministrator.GetRole().Text = string.Empty;
            this.vAdministrator.GetLanguage().Text = string.Empty;
            this.vAdministrator.GetSearch().Text = string.Empty;
            this.vAdministrator.GetUserTable().DataSource = repository.GetTable("SELECT * FROM [User]");
        }
    }
}
