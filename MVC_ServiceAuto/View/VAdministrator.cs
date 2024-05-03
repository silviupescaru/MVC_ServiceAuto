using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_ServiceAuto.View
{
    public partial class VAdministrator : Form
    {

        public VAdministrator()
        {
            InitializeComponent();
            this.numericUpDownUserID.Value = 0;
            this.textBoxUsername.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
            this.textBoxRole.Text = string.Empty;
            this.textBoxSearch.Text = string.Empty;
            this.comboBoxLanguage.SelectedItem = 0;
        }

        public NumericUpDown GetUserID()
        { 
            return this.numericUpDownUserID;
        }

        public TextBox GetUsername()
        {
            return this.textBoxUsername;
        }

        public TextBox GetPassword()
        {
            return this.textBoxPassword;
        }

        public TextBox GetRole()
        {
            return this.textBoxRole;
        }

        public ComboBox GetLanguage()
        {
            return this.comboBoxLanguage;
        }

        public TextBox GetSearch()
        {
            return this.textBoxSearch;
        }

        public DataGridView GetUserTable()
        {
            return this.dataGridViewUsers;
        }

        public Button GetAddButton()
        {
            return this.buttonAdd;
        }

        public Button GetUpdateButton() 
        {
            return this.buttonUpdate;
        }

        public Button GetDeleteButton()
        {
            return this.buttonDelete;
        }

        public Button GetSearchButton()
        {
            return this.buttonSearch;
        }

        public Button GetViewAllButton()
        {
            return this.buttonViewAll;
        }

        public Button GetLogoutButton()
        {
            return this.buttonLogout;
        }


    }
}
