using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVManager
    {
        private VManager vManager;
        private VLogin vLogin;
        private CarRepository carRepository;
        private Repository repository;

        public ControllerVManager()
        {
            this.vManager = new VManager();
            this.vLogin = new VLogin();
            this.carRepository = new CarRepository();
            this.repository = Repository.GetInstance();

            this.eventsManagement();
        }

        public VManager GetView()
        {
            this.vManager.Show();
            return this.vManager;
        }

        private void eventsManagement()
        {
            this.vManager.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vManager.GetSearchButton().Click += new EventHandler(searchBy);
            this.vManager.GetViewAllButton().Click += new EventHandler(viewAll);
            this.vManager.GetSaveCSVButton().Click += new EventHandler(saveCSV);
            this.vManager.GetSaveJSONButton().Click += new EventHandler(saveJSON);
            this.vManager.GetSaveXMLButton().Click += new EventHandler(saveXML);
            this.vManager.GetSaveDOCButton().Click += new EventHandler(saveDOC);
            this.vManager.GetLogoutButton().Click += new EventHandler(logout);
            this.vManager.GetCarTable().RowStateChanged += new DataGridViewRowStateChangedEventHandler(setCarControls);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void searchBy(object sender, EventArgs e)
        {
            try
            {
                if(this.vManager.GetCarTable() != null)
                    this.vManager.GetCarTable().Rows.Clear();
                if (this.vManager.GetSearchBy().Text.Length > 0)
                {
                    List<Car> list = this.carRepository.SearchCarByOwner(this.vManager.GetSearchBy().Text);
                    if (list != null && list.Count > 0)
                    {
                        foreach (Car cars in list)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(this.vManager.GetCarTable());

                            row.Cells[0].Value = cars.CarID;
                            row.Cells[1].Value = cars.Owner;
                            row.Cells[2].Value = cars.Brand;
                            row.Cells[3].Value = cars.Color;
                            row.Cells[4].Value = cars.Fuel;

                            this.vManager.GetCarTable().Rows.Add(row);
                        }
                    }
                    else MessageBox.Show("There is no car with desired owner!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void viewAll(object sender, EventArgs e)
        {
            try
            {
                if(this.vManager.GetCarTable() != null)
                {
                    this.vManager.GetCarTable().Rows.Clear();
                    this.vManager.GetCarTable().DataSource = this.repository.GetTable("SELECT * FROM [Car]");
                }
            }
            catch(Exception exception) 
            { 
                MessageBox.Show(exception.ToString());
            }
        }

        private void saveCSV(object sender, EventArgs e) { }
        private void saveJSON(object sender, EventArgs e) { }
        private void saveXML(object sender, EventArgs e) { }
        private void saveDOC(object sender, EventArgs e) { }

        private void logout(object sender, EventArgs e) 
        {
            try
            {
                ControllerVLogin login = new ControllerVLogin();
                login.GetView();
                this.vManager.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setCarControls(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable().SelectedRows.Count > 0)
                {
                    DataGridViewRow drvr = this.vManager.GetCarTable().SelectedRows[0];

                    uint carID = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.vManager.GetCarID().Value = carID;

                    string owner = drvr.Cells[1].Value.ToString();
                    this.vManager.GetOwner().Text = owner;

                    string brand = drvr.Cells[2].Value.ToString();
                    this.vManager.GetBrand().Text = brand;

                    string color = drvr.Cells[3].Value.ToString();
                    this.vManager.GetColor().Text = color;

                    string fuel = drvr.Cells[4].Value.ToString();
                    this.vManager.GetFuel().Text = fuel;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
