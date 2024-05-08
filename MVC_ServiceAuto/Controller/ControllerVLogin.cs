using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVLogin
    {
        private VLogin vLogin;
        private UserRepository userRepository;

        public ControllerVLogin()
        {
            this.vLogin = new VLogin();
            this.userRepository = new UserRepository();

            this.eventsManagement();
        }

        public VLogin GetView()
        {
            this.vLogin.Show();
            return this.vLogin;
        }

        private void eventsManagement() 
        {
            this.vLogin.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vLogin.GetLoginButton().Click += new EventHandler(login);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void login(object sender, EventArgs e)
        {
            try
            {
                string username = this.vLogin.GetUsername().Text;
                string password = this.vLogin.GetPassword().Text;

                if (username.Length > 0 && password.Length > 0)
                {
                    bool result = this.userRepository.LoginUser(username, password);
                    if(result == true) 
                    {
                        string role = userRepository.GetRole(username, password);
                        if (role.Equals("Employee"))
                        {
                            this.vLogin.Hide();
                            ControllerVEmployee em = new ControllerVEmployee();
                            em.GetView();
                        } else if (role.Equals("Manager"))
                        {
                            this.vLogin.Hide();
                            ControllerVManager ma = new ControllerVManager();
                            ma.GetView();
                        } else if (role.Equals("Administrator"))
                        {
                            this.vLogin.Hide();
                            ControllerVAdministrator ad = new ControllerVAdministrator();
                            ad.GetView();
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
