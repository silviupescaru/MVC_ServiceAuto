using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model.Language;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVLogin
    {
        private VLogin vLogin;
        private UserRepository userRepository;
        private string language;

        public ControllerVLogin(int index)
        {
            this.vLogin = new VLogin(index);
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
            this.vLogin.GetChangeLangugae().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.vLogin.GetChangeLangugae().SelectedIndex == 1)
            {
                LangHelper.ChangeLanguage("en");
                language = "en";
            }
            else if (this.vLogin.GetChangeLangugae().SelectedIndex == 2)
            {
                LangHelper.ChangeLanguage("ru");
                language = "ru";
            }
            else if (this.vLogin.GetChangeLangugae().SelectedIndex == 3)
            {
                LangHelper.ChangeLanguage("fr");
                language = "fr";
            }

            this.vLogin.GetChangeLanguageLabel().Text = ($"{LangHelper.GetString("labelChangeLanguage")}");
            this.vLogin.GetLoginButton().Text = ($"{LangHelper.GetString("buttonLogin")}");


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
                            ControllerVAdministrator ad = new ControllerVAdministrator(language);
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
