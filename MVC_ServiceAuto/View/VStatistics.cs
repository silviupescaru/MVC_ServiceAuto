using MVC_ServiceAuto.Model;
using MVC_ServiceAuto.Model.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MVC_ServiceAuto.View
{
    public partial class VStatistics : Form, Observable
    {

        private int index;

        public VStatistics(int index)
        {
            InitializeComponent();
            this.comboBoxChangeLanguage.SelectedIndex = index;
        }

        public Button GetBackButton()
        {
            return this.buttonBack;
        }

        public ComboBox GetCriterion()
        {
            return this.comboBoxCriterion;
        }

        public ComboBox GetLanguageBox()
        {
            return this.comboBoxChangeLanguage;
        }

        public Chart GetChart() {
            return this.chartCarStatistics;
        }

        public void Update(Subject obs)
        {
            LangHelper lang = (LangHelper)obs;
            this.labelSelectCriterion.Text = lang.GetString("labelCriterion");
            this.labelChangeLanguage.Text = lang.GetString("labelChangeLanguage");
            this.buttonBack.Text = lang.GetString("buttonBack");
        }
    }
}
