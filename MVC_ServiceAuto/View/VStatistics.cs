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
    public partial class VStatistics : Form
    {
        public VStatistics()
        {
            InitializeComponent();
        }

        public Button GetBackButton()
        {
            return this.buttonBack;
        }

        public Button GetShowButton()
        {
            return this.buttonShowStatistics;
        }

        public Chart GetChart() {
            return this.chartCarStatistics;
        }
    }
}
