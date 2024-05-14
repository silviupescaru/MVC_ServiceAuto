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
using System.Data;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Security.Cryptography;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using MVC_ServiceAuto.Model.Language;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVEmployee
    {
        private VEmployee vEmployee;
        private VLogin vLogin;
        private CarRepository carRepository;
        private Repository repository;
        private LangHelper lang;

        public ControllerVEmployee(int index)
        {
            this.vEmployee = new VEmployee(index);
            this.carRepository = new CarRepository();
            this.repository = Repository.GetInstance();
            this.lang = new LangHelper();
            this.lang.Add(this.vEmployee);

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
            this.vEmployee.GetDeleteButton().Click += new EventHandler(deleteCar);
            this.vEmployee.GetSearchButton().Click += new EventHandler(searchBy);
            this.vEmployee.GetFilterBy().SelectedIndexChanged += new EventHandler(filterBy);
            this.vEmployee.GetCarOrderBy().SelectedIndexChanged += new EventHandler(orderBy);
            this.vEmployee.GetViewAllButton().Click += new EventHandler(viewAll);
            this.vEmployee.GetSaveCSVButton().Click += new EventHandler(saveCSV);
            this.vEmployee.GetSaveJSONButton().Click += new EventHandler(saveJSON);
            this.vEmployee.GetSaveXMLButton().Click += new EventHandler(saveXML);
            this.vEmployee.GetSaveDOCButton().Click += new EventHandler(saveDOC);
            this.vEmployee.GetLogoutButton().Click += new EventHandler(logout);
            this.vEmployee.GetCarTable().RowStateChanged += new DataGridViewRowStateChangedEventHandler(setCarControls);
            this.vEmployee.GetLanguageBox().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.vEmployee.GetLanguageBox().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.vEmployee.GetLanguageBox().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.vEmployee.GetLanguageBox().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }

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

        private void deleteCar(object sender, EventArgs e)
        {
            try { 
                if (Convert.ToBoolean(this.vEmployee.GetCarID().Value))
                {
                    uint selectedID = Convert.ToUInt32(this.vEmployee.GetCarID().Value);
                    bool result = this.carRepository.DeleteCar(selectedID);

                    if (result)
                    {
                        MessageBox.Show("Deleting was successful!");
                        this.resetGUIControls();
                    }
                    else MessageBox.Show("Deletion ended with failure!");
                }
                else MessageBox.Show("No car has been selected to be deleted!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchBy(object sender, EventArgs e)
        {
            try
            {
                if(this.vEmployee.GetCarTable() != null)
                    this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0");

                if (this.vEmployee.GetSearch().Text.Length > 0)
                {
                    List<Car> list = this.carRepository.SearchCarByOwner(this.vEmployee.GetSearch().Text);
                    if (list == null)
                    {
                        MessageBox.Show("No car with desired owner!");
                    }
                    else
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();

                        dt.Columns.Add("carID", typeof(uint));
                        dt.Columns.Add("owner", typeof(string));
                        dt.Columns.Add("brand", typeof(string));
                        dt.Columns.Add("color", typeof(string));
                        dt.Columns.Add("fuel", typeof(string));

                        foreach (Car car in list)
                        {
                            DataRow row = dt.NewRow();

                            row["carID"] = car.CarID;
                            row["owner"] = car.Owner;
                            row["brand"] = car.Brand;
                            row["color"] = car.Color;
                            row["fuel"] = car.Fuel;

                            dt.Rows.Add(row);
                        }

                        this.vEmployee.GetCarTable().DataSource = dt;
                    }
                }
                else MessageBox.Show("Search bar is empty!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void filterBy(object sender, EventArgs e)
        {
            try
            {
                if (this.vEmployee.GetCarTable() != null)
                    this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");

                string selectedOption = this.vEmployee.GetFilterBy().Text;

                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Owner(this.vEmployee.GetOwner().Text);
                        if (list != null)
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            dt.Columns.Add("carID", typeof(uint));
                            dt.Columns.Add("owner", typeof(string));
                            dt.Columns.Add("brand", typeof(string));
                            dt.Columns.Add("color", typeof(string));
                            dt.Columns.Add("fuel", typeof(string));

                            foreach (Car car in list)
                            {
                                DataRow row = dt.NewRow();

                                row["carID"] = car.CarID;
                                row["owner"] = car.Owner;
                                row["brand"] = car.Brand;
                                row["color"] = car.Color;
                                row["fuel"] = car.Fuel;

                                dt.Rows.Add(row);
                            }

                            this.vEmployee.GetCarTable().DataSource = dt;
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Brand(this.vEmployee.GetBrand().Text);
                        if (list != null)
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            dt.Columns.Add("carID", typeof(uint));
                            dt.Columns.Add("owner", typeof(string));
                            dt.Columns.Add("brand", typeof(string));
                            dt.Columns.Add("color", typeof(string));
                            dt.Columns.Add("fuel", typeof(string));

                            foreach (Car car in list)
                            {
                                DataRow row = dt.NewRow();

                                row["carID"] = car.CarID;
                                row["owner"] = car.Owner;
                                row["brand"] = car.Brand;
                                row["color"] = car.Color;
                                row["fuel"] = car.Fuel;

                                dt.Rows.Add(row);
                            }
                            this.vEmployee.GetCarTable().DataSource = dt;
                        }
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Color(this.vEmployee.GetColor().Text);
                        if (list != null)
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            dt.Columns.Add("carID", typeof(uint));
                            dt.Columns.Add("owner", typeof(string));
                            dt.Columns.Add("brand", typeof(string));
                            dt.Columns.Add("color", typeof(string));
                            dt.Columns.Add("fuel", typeof(string));

                            foreach (Car car in list)
                            {
                                DataRow row = dt.NewRow();

                                row["carID"] = car.CarID;
                                row["owner"] = car.Owner;
                                row["brand"] = car.Brand;
                                row["color"] = car.Color;
                                row["fuel"] = car.Fuel;

                                dt.Rows.Add(row);
                            }
                            this.vEmployee.GetCarTable().DataSource = dt;
                        }
                    }
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Fuel(this.vEmployee.GetFuel().Text);
                        if (list != null)
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            dt.Columns.Add("carID", typeof(uint));
                            dt.Columns.Add("owner", typeof(string));
                            dt.Columns.Add("brand", typeof(string));
                            dt.Columns.Add("color", typeof(string));
                            dt.Columns.Add("fuel", typeof(string));

                            foreach (Car car in list)
                            {
                                DataRow row = dt.NewRow();

                                row["carID"] = car.CarID;
                                row["owner"] = car.Owner;
                                row["brand"] = car.Brand;
                                row["color"] = car.Color;
                                row["fuel"] = car.Fuel;

                                dt.Rows.Add(row);
                            }
                            this.vEmployee.GetCarTable().DataSource = dt;
                        }
                    }
                    else MessageBox.Show("The cars from desired filter is empty!");

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void orderBy(object sender, EventArgs e) 
        {
            try
            {
                if (this.vEmployee.GetCarTable() != null)
                    this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");

                string selectedOption = this.vEmployee.GetCarOrderBy().Text;
                if (selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car");
                    }
                    else if (selectedOption.ToUpper() == "BRAND AND FUEL")
                    {
                        this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * FROM Car order by [brand], [fuel];");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAll(object sender, EventArgs e) 
        {
            try
            {
                if (this.vEmployee.GetCarTable() != null)
                {
                    this.vEmployee.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                    this.vEmployee.GetCarTable().DataSource = this.repository.GetTable("SELECT * FROM [Car]");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void saveCSV(object sender, EventArgs e) 
        {
            try
            {
                DataGridView dgv = this.vEmployee.GetCarTable();
                if (dgv != null)
                {
                    StringBuilder sb = new StringBuilder();

                    // Get the column names from the DataGridView.
                    IEnumerable<string> columnNames = dgv.Columns.Cast<DataGridViewColumn>().Select(column => column.Name);
                    sb.AppendLine(string.Join(",", columnNames));

                    // Iterate over the rows in the DataGridView.
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        // Get the values from each cell in the row.
                        IEnumerable<string> fields = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value != null ? cell.Value.ToString() : "");
                        sb.AppendLine(string.Join(",", fields));
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveJSON(object sender, EventArgs e) 
        {
            try
            {
                DataGridView dgv = this.vEmployee.GetCarTable();
                if (dgv != null)
                {
                    // Create a list to hold dictionaries.
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

                    // Iterate over the rows in the DataGridView.
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        // Create a dictionary for this row.
                        Dictionary<string, object> dictRow = new Dictionary<string, object>();

                        // Iterate over the cells in the row.
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Add the cell's value to the dictionary.
                            dictRow[dgv.Columns[cell.ColumnIndex].Name] = cell.Value;
                        }

                        // Add the dictionary to the list.
                        rows.Add(dictRow);
                    }

                    // Now we can serialize the list of dictionaries.
                    JsonSerializer serializer = new JsonSerializer
                    {
                        Formatting = Newtonsoft.Json.Formatting.Indented
                    };

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                    saveFileDialog.DefaultExt = "json";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        using (JsonTextWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, rows);
                        }
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveXML(object sender, EventArgs e) 
        {
            try
            {
                DataGridView dgv = this.vEmployee.GetCarTable();
                if (dgv != null)
                {
                    // Create a new DataTable.
                    System.Data.DataTable dt = new System.Data.DataTable();

                    // Add columns to the DataTable.
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        dt.Columns.Add(column.Name, column.ValueType);
                    }

                    // Add rows to the DataTable.
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        dt.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                    saveFileDialog.DefaultExt = "xml";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        dt.TableName = "Cars"; // Set the table name.
                        dt.WriteXml(saveFileDialog.FileName); // Write the DataTable to an XML file.
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveDOC(object sender, EventArgs e) 
        {
            try
            {
                DataGridView dgv = this.vEmployee.GetCarTable();
                if (dgv != null && dgv.Rows.Count > 0)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                    saveFileDialog.DefaultExt = "docx";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (WordprocessingDocument document = WordprocessingDocument.Create(saveFileDialog.FileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                        {
                            MainDocumentPart mainPart = document.AddMainDocumentPart();
                            mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                            DocumentFormat.OpenXml.Wordprocessing.Body body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());

                            Table t = new Table();

                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                TableRow row = new TableRow();

                                for (int j = 0; j < dgv.Columns.Count; j++)
                                {
                                    TableCell cell = new TableCell();
                                    if (dgv.Rows[i].Cells[j].Value != null)
                                    {
                                        cell.Append(new Paragraph(new Run(new Text(dgv.Rows[i].Cells[j].Value.ToString()))));
                                    }
                                    else
                                    {
                                        cell.Append(new Paragraph(new Run(new Text(""))));
                                    }
                                    row.Append(cell);
                                }

                                t.Append(row);
                            }

                            body.Append(t);
                            document.Save();
                            MessageBox.Show("File saved successfully!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logout(object sender, EventArgs e) 
        {
            try
            {
                ControllerVLogin login = new ControllerVLogin(1);
                login.GetView();
                this.vEmployee.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setCarControls(object sender, EventArgs e)
        {
            try
            {
                if(this.vEmployee.GetCarTable().SelectedRows.Count > 0)
                {
                    DataGridViewRow drvr = this.vEmployee.GetCarTable().SelectedRows[0];

                    uint carID = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.vEmployee.GetCarID().Value = carID;

                    string owner = drvr.Cells[1].Value.ToString();
                    this.vEmployee.GetOwner().Text = owner;

                    string brand = drvr.Cells[2].Value.ToString();
                    this.vEmployee.GetBrand().Text = brand;

                    string color = drvr.Cells[3].Value.ToString();
                    this.vEmployee.GetColor().Text = color;

                    string fuel = drvr.Cells[4].Value.ToString();
                    this.vEmployee.GetFuel().Text = fuel;

                    string imageName = brand + "_" + color;
                    string workingDirectory = Environment.CurrentDirectory;
                    workingDirectory = workingDirectory.Substring(0, workingDirectory.Length - 9);





                    string path = workingDirectory + "resources\\cars\\" + imageName + ".jpg";
                    string secondPath = workingDirectory + "resources\\cars\\noCarFound.jpg";

                    try
                    {
                        this.vEmployee.GetPictureBox().Image = Image.FromFile(path);
                    }
                    catch
                    {
                        this.vEmployee.GetPictureBox().Image = Image.FromFile(secondPath);
                    }
                }
            }
            catch( Exception ex)
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
