using MVC_ServiceAuto.Model;
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
        public VStatistics()
        {
            InitializeComponent();
        }

        public Button GetBackButton()
        {
            return this.buttonBack;
        }

        public ComboBox GetCriterion()
        {
            return this.comboBoxCriterion;
        }

        public Label GetLabel()
        {
            return this.labelSelectCriterion;
        }

        public Chart GetChart() {
            return this.chartCarStatistics;
        }

        public void Update(Subject obs)
        {
            //CarStatistics carStatistics = (CarStatistics)obs;
        }
    }
}
