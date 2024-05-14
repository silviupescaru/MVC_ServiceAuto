﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model;
using MVC_ServiceAuto.Model.Language;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVLogin
    {
        private VLogin vLogin;
        private UserRepository userRepository;
        private LangHelper lang;

        public ControllerVLogin(int index)
        {
            this.vLogin = new VLogin(index);
            this.userRepository = new UserRepository();
            this.lang = new LangHelper();
            this.lang.Add(this.vLogin);


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
            if (this.vLogin.GetChangeLangugae().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.vLogin.GetChangeLangugae().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.vLogin.GetChangeLangugae().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }

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
                            ControllerVEmployee em = new ControllerVEmployee(this.vLogin.GetChangeLangugae().SelectedIndex);
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
