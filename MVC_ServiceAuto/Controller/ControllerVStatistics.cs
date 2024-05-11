using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVStatistics
    {
        VStatistics vStatistics;
        CarRepository carRepository;
        Repository repository;

        public ControllerVStatistics() 
        {
            this.vStatistics = new VStatistics();
            this.carRepository = new CarRepository();
            this.repository = Repository.GetInstance();

            this.eventsManagement();
        }

        public VStatistics GetView()
        {
            this.vStatistics.Show();
            return this.vStatistics;
        }

        private void eventsManagement()
        {
            this.vStatistics.GetBackButton().Click += new EventHandler(backToManager);
            this.vStatistics.GetShowButton().Click += new EventHandler(showStatistics);
        }

        private void backToManager(object sender, EventArgs e)
        {

        }

        private void showStatistics(object sender, EventArgs e)
        {
            string criterion = "brand";

            this.vStatistics.GetChart().Series.Clear();
            this.vStatistics.GetChart().Legends.Clear();

            // Add a new legend
            this.vStatistics.GetChart().Legends.Add(criterion);
            this.vStatistics.GetChart().Legends[0].LegendStyle = LegendStyle.Table;
            this.vStatistics.GetChart().Legends[0].Docking = Docking.Bottom;
            this.vStatistics.GetChart().Legends[0].Alignment = StringAlignment.Center;
            this.vStatistics.GetChart().Legends[0].Title = criterion;
            this.vStatistics.GetChart().Legends[0].BorderColor = Color.Black;

            // Add a new series
            var series = this.vStatistics.GetChart().Series.Add(criterion);

            // Set the chart type to Pie
            series.ChartType = SeriesChartType.Pie;


            this.vStatistics.GetChart().Series[criterion].Points.AddXY("Mercedes-Benz", 20);
            this.vStatistics.GetChart().Series[criterion].Points.AddXY("BMW", 40);
            this.vStatistics.GetChart().Series[criterion].Points.AddXY("Audi", 15);
            this.vStatistics.GetChart().Series[criterion].Points.AddXY("Daci", 15);


            this.vStatistics.GetChart().Show();

            Debug.WriteLine("Done statistics!");

        }

    }
}
