using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_ServiceAuto.Model.Language;

namespace MVC_ServiceAuto.View
{
    public partial class VLogin : Form
    {

        public VLogin(int index)
        {
            InitializeComponent();
            this.textBoxUsername.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
            this.comboBoxChangeLanguage.SelectedIndex = index;

        }

        public TextBox GetUsername()
        {
            return this.textBoxUsername;
        }

        public TextBox GetPassword()
        {
            return this.textBoxPassword;
        }

        public ComboBox GetChangeLangugae()
        {
            return this.comboBoxChangeLanguage;
        }

        public Label GetChangeLanguageLabel()
        {
            return this.labelChangeLanguage;
        }

        public Button GetLoginButton()
        {
            return this.buttonLogin;
        }
    }
}
