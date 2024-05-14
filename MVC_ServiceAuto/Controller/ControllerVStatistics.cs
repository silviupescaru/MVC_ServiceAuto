using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.Model;
using MVC_ServiceAuto.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVStatistics
    {
        private VStatistics vStatistics;
        private CarStatistics carStatistics;
        private CarRepository carRepository;
        private Repository repository;

        public ControllerVStatistics() 
        {
            this.vStatistics = new VStatistics();
            this.carRepository = new CarRepository();
            this.carStatistics = new CarStatistics(carRepository.CarTable());

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
            this.vStatistics.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vStatistics.GetBackButton().Click += new EventHandler(backToManager);
            this.vStatistics.GetCriterion().SelectedIndexChanged += new EventHandler(showStatistics);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void backToManager(object sender, EventArgs e)
        {
            try
            {
                ControllerVManager manager = new ControllerVManager(0);
                manager.GetView();
                this.vStatistics.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void showStatistics(object sender, EventArgs e)
        {

            string criterion = this.vStatistics.GetCriterion().SelectedItem.ToString();

            this.carStatistics.Criterion = criterion;
            Dictionary<string, uint> dictionary = this.carStatistics.Result;
            if (dictionary != null)
            {
                this.vStatistics.GetChart().Series.Clear();
                this.vStatistics.GetChart().Legends.Clear();
                this.vStatistics.GetChart().Legends.Add(criterion);
                this.vStatistics.GetChart().Legends[0].LegendStyle = LegendStyle.Table;
                this.vStatistics.GetChart().Legends[0].Docking = Docking.Bottom;
                this.vStatistics.GetChart().Legends[0].Alignment = StringAlignment.Center;
                this.vStatistics.GetChart().Legends[0].Title = criterion;
                this.vStatistics.GetChart().Legends[0].TitleForeColor = Color.White;
                this.vStatistics.GetChart().Legends[0].TitleFont = new Font("Montserrat", 9);
                this.vStatistics.GetChart().Legends[0].BorderColor = Color.Transparent;
                this.vStatistics.GetChart().Legends[0].BackColor = Color.Transparent;
                this.vStatistics.GetChart().Legends[0].ForeColor = Color.White;
                this.vStatistics.GetChart().Legends[0].Font = new Font("Montserrat", 9);
                this.vStatistics.GetChart().Series.Add(criterion);
                this.vStatistics.GetChart().Series[criterion].ChartType = SeriesChartType.Pie;

                foreach (KeyValuePair<string, uint> pair in dictionary)
                {
                    this.vStatistics.GetChart().Series[criterion].Points.AddXY(pair.Key, pair.Value);
                }

                foreach (DataPoint p in this.vStatistics.GetChart().Series[criterion].Points)
                {
                    p.Label = "#PERCENT";
                }

                this.vStatistics.GetChart().Series[criterion].LegendText = "#VALX";
            }
            else MessageBox.Show("The list of cars is empty!");


            Debug.WriteLine("Done statistics!");

        }

    }
}
