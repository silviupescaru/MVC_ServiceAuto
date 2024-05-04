using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model;
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

namespace MVC_ServiceAuto.View
{
    public partial class VManager : Form
    {

        public VManager()
        {
            InitializeComponent();
            this.numericUpDownCarID.Value = 1;
            this.textBoxOwner.Text = string.Empty;
            this.textBoxBrand.Text = string.Empty;
            this.textBoxColor.Text = string.Empty;
            this.textBoxSearchBar.Text = string.Empty;
            this.comboBoxFuel.SelectedItem = 0;
            this.comboBoxFilterBy.SelectedItem = 0;
            this.comboBoxCarFilter.SelectedItem = 0;
        }

        public NumericUpDown GetCarID()
        {
            return this.numericUpDownCarID;
        }

        public TextBox GetOwner()
        {
            return this.textBoxOwner;
        }

        public TextBox GetBrand()
        {
            return this.textBoxBrand;
        }

        public TextBox GetColor()
        {
            return this.textBoxColor;
        }

        public ComboBox GetFuel()
        {
            return this.comboBoxFuel;
        }

        public ComboBox GetOrderBy()
        {
            return this.comboBoxCarFilter;
        }

        public ComboBox GetFilterBy()
        {
            return this.comboBoxFilterBy;
        }

        public DataGridView GetCarTable()
        {
            return this.dataGridViewCarTable;
        }

        public TextBox GetSearchBy()
        {
            return this.textBoxSearchBar;
        }

        public Button GetSaveCSVButton()
        {
            return this.buttonSaveCSV;
        }

        public Button GetSaveJSONButton()
        {
            return this.buttonSaveJSON;
        }

        public Button GetSaveXMLButton()
        {
            return this.buttonSaveXML;
        }

        public Button GetSaveDOCButton()
        {
            return this.buttonSaveDOC;
        }

        public Button GetViewAllButton()
        {
            return this.buttonViewAll;
        }

        public Button GetSearchButton()
        {
            return this.buttonSearch;
        }

        public Button GetLogoutButton()
        {
            return this.buttonLogout;
        }

    }
}
