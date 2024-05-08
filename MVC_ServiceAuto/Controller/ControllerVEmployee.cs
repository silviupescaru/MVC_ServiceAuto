using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVEmployee
    {
        private VEmployee vEmployee;
        private VLogin vLogin;
        private CarRepository carRepository;
        private Repository repository;

        public ControllerVEmployee()
        {
            this.vEmployee = new VEmployee();
            this.carRepository = new CarRepository();
            this.repository = Repository.GetInstance();

            this.eventManagement();
        }

        public VEmployee GetView()
        {
            this.vEmployee.Show();
            return this.vEmployee;
        }

        private void eventManagement()
        {
            this.vEmployee.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vEmployee.GetAddButton().Click += new EventHandler(addCar);
            this.vEmployee.GetUpdateButton().Click += new EventHandler(updateCar);
            //this.vEmployee.GetDeleteButton().Click += new EventHandler(deleteCar);
            //this.vEmployee.GetSearchButton().Click += new EventHandler(searchBy);
            //this.vEmployee.GetFilterBy().SelectedIndexChanged += new EventHandler(filterBy);
            //this.vEmployee.GetCarOrderBy().SelectedIndexChanged += new EventHandler(orderBy);
            //this.vEmployee.GetViewAllButton().Click += new EventHandler(viewAll);
            //this.vEmployee.GetSaveCSVButton().Click += new EventHandler(saveCSV);
            //this.vEmployee.GetSaveJSONButton().Click += new EventHandler(saveJSON);
            //this.vEmployee.GetSaveXMLButton().Click += new EventHandler(saveXML);
            //this.vEmployee.GetSaveDOCButton().Click += new EventHandler(saveDOC);
            //this.vEmployee.GetLogoutButton().Click += new EventHandler(logout);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void addCar(object sender, EventArgs e)
        {
            try
            {
                Car car = this.validInformation();

                if(car != null) 
                {
                    bool result = this.carRepository.AddCar(car);
                    if (result == true)
                    {
                        MessageBox.Show("Adding was successful!");
                        this.resetGUIControls();

                        if (this.vEmployee.GetCarTable() == null)
                            MessageBox.Show("There is no car in your table!");
                    }
                    else MessageBox.Show("Adding was ended in failure!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateCar(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(this.vEmployee.GetCarID().Value))
                {
                    Car car = this.validInformation();
                    if (car != null)
                    {
                        bool result = this.carRepository.UpdateCar(car);
                        if (result)
                        {
                            MessageBox.Show("Updating was successful!");
                            this.resetGUIControls();
                        }
                        else MessageBox.Show("Updating ended with failure!");
                    }
                }
                else MessageBox.Show("No car has been selected to be updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void resetGUIControls()
        {
            this.vEmployee.GetCarID().Value = 1;
            this.vEmployee.GetOwner().Text = string.Empty;
            this.vEmployee.GetBrand().Text = string.Empty;
            this.vEmployee.GetColor().Text = string.Empty;
            this.vEmployee.GetFuel().Text = string.Empty;
            this.vEmployee.GetSearch().Text = string.Empty;
            this.vEmployee.GetCarOrderBy().SelectedItem = 0;
            this.vEmployee.GetFilterBy().SelectedItem = 0;
            this.vEmployee.GetCarTable().DataSource = this.repository.GetTable("select * from Car where 1 = 0");
            this.vEmployee.GetCarTable().DataSource = this.repository.GetTable("select * from Car");
        }

        private Car validInformation()
        {
            uint id = (uint)this.vEmployee.GetCarID().Value;
            Debug.Print("Car ID: " + id);
            if (id == 0)
            {
                MessageBox.Show("Car ID must be non-zero natural number!");
                return null;
            }
            string owner = this.vEmployee.GetOwner().Text;
            Debug.Print("Car Owner: " + owner);
            if (owner == null || owner.Length == 0)
            {
                MessageBox.Show("Car Owner is empty!");
                return null;
            }
            string brand = this.vEmployee.GetBrand().Text;
            Debug.Print("Car Brand: " + brand);
            if (brand == null || brand.Length == 0)
            {
                MessageBox.Show("Car Brand is empty!");
                return null;
            }
            string color = this.vEmployee.GetColor().Text;
            Debug.Print("Car Color: " + color);
            if (color == null || color.Length == 0)
            {
                MessageBox.Show("Car Color is empty");
                return null;
            }
            string fuel = this.vEmployee.GetFuel().Text;
            Debug.Print("Car Fuel: " + fuel);
            if (fuel == null || fuel.Length == 0)
            {
                MessageBox.Show("Car Fuel is empty");
                return null;
            }
            return new Car(id, owner, brand, color, fuel);
        }
    }
}
