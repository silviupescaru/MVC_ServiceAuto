using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MVC_ServiceAuto.Model;
using MVC_ServiceAuto.Model.Repository;
using MVC_ServiceAuto.View;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Net.Mime.MediaTypeNames;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MVC_ServiceAuto.Model.Language;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVManager
    {
        private VManager vManager;
        private VLogin vLogin;
        private CarRepository carRepository;
        private Repository repository;
        private LangHelper lang;
        private int index;

        public ControllerVManager(int index)
        {
            this.vManager = new VManager(index);
            this.vLogin = new VLogin(index);
            this.carRepository = new CarRepository();
            this.repository = Repository.GetInstance();
            this.lang = new LangHelper();
            this.lang.Add(this.vManager);
            this.index = index;


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
            this.vManager.GetFilterBy().SelectedIndexChanged += new EventHandler(filterBy);
            this.vManager.GetOrderBy().SelectedIndexChanged += new EventHandler(orderBy);
            this.vManager.GetViewAllButton().Click += new EventHandler(viewAll);
            this.vManager.GetSaveCSVButton().Click += new EventHandler(saveCSV);
            this.vManager.GetSaveJSONButton().Click += new EventHandler(saveJSON);
            this.vManager.GetSaveXMLButton().Click += new EventHandler(saveXML);
            this.vManager.GetSaveDOCButton().Click += new EventHandler(saveDOC);
            this.vManager.GetStatisticsButton().Click += new EventHandler(showStatistics);
            this.vManager.GetLogoutButton().Click += new EventHandler(logout);
            this.vManager.GetCarTable().RowStateChanged += new DataGridViewRowStateChangedEventHandler(setCarControls);
            this.vManager.GetLanguageBox().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.vManager.GetLanguageBox().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.vManager.GetLanguageBox().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.vManager.GetLanguageBox().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }

        }

        private void searchBy(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                {
                    this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                }
                if (this.vManager.GetSearchBy().Text.Length > 0)
                {
                    string searchedOwner = this.vManager.GetSearchBy().Text;
                    List<Car> list = this.carRepository.SearchCarByOwner(searchedOwner);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("carID", typeof(uint));
                    dt.Columns.Add("owner", typeof(string));
                    dt.Columns.Add("brand", typeof(string));
                    dt.Columns.Add("color", typeof(string));
                    dt.Columns.Add("fuel", typeof(string));


                    if (list != null && list.Count > 0)
                    {
                        foreach (Car cars in list)
                        {
                            DataRow row = dt.NewRow();

                            row["carID"] = cars.CarID;
                            row["owner"] = cars.Owner;
                            row["brand"] = cars.Brand;
                            row["color"] = cars.Color;
                            row["fuel"] = cars.Fuel;

                            dt.Rows.Add(row);
                        }

                        this.vManager.GetCarTable().DataSource = dt;
                    }
                    else MessageBox.Show("There is no car with desired owner!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void filterBy(object sender, EventArgs e) 
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                    this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");

                string selectedOption = this.vManager.GetFilterBy().Text;

                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Owner(this.vManager.GetOwner().Text);
                        if (list != null)
                        {
                            DataTable dt = new DataTable();
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

                            this.vManager.GetCarTable().DataSource = dt;
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Brand(this.vManager.GetBrand().Text);
                        if (list != null)
                        {
                            DataTable dt = new DataTable();
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
                            this.vManager.GetCarTable().DataSource = dt;
                        }
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Color(this.vManager.GetColor().Text);
                        if (list != null)
                        {
                            DataTable dt = new DataTable();
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
                            this.vManager.GetCarTable().DataSource = dt;
                        }
                    }
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                        List<Car> list = this.carRepository.CarList_Fuel(this.vManager.GetFuel().Text);
                        if (list != null)
                        {
                            DataTable dt = new DataTable();
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
                            this.vManager.GetCarTable().DataSource = dt;
                        }
                    }
                    else MessageBox.Show("The cars from desired filter is empty!");

                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void orderBy(object sender, EventArgs e) 
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                    this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");

                string selectedOption = this.vManager.GetOrderBy().Text;
                if(selectedOption.Length > 0)
                {
                    if(selectedOption.ToUpper() == "NONE")
                    {
                        this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car");
                    } else if(selectedOption.ToUpper() == "BRAND AND FUEL")
                    {
                        this.vManager.GetCarTable().DataSource = repository.GetTable("select * FROM Car order by [brand], [fuel];");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAll(object sender, EventArgs e)
        {
            try
            {
                if(this.vManager.GetCarTable() != null)
                {
                    this.vManager.GetCarTable().DataSource = repository.GetTable("select * from Car where 1=0;");
                    this.vManager.GetCarTable().DataSource = this.repository.GetTable("SELECT * FROM [Car]");
                }
            }
            catch(Exception exception) 
            { 
                MessageBox.Show(exception.ToString());
            }
        }

        private void saveCSV(object sender, EventArgs e) 
        {
            try
            {
                DataGridView dgv = this.vManager.GetCarTable();
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
                DataGridView dgv = this.vManager.GetCarTable();
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
                DataGridView dgv = this.vManager.GetCarTable();
                if (dgv != null)
                {
                    // Create a new DataTable.
                    DataTable dt = new DataTable();

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
                DataGridView dgv = this.vManager.GetCarTable();
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

        private void showStatistics(object sender, EventArgs e)
        {
            try
            {
                ControllerVStatistics statistics = new ControllerVStatistics(index);
                statistics.GetView();
                this.vManager.Hide();
            }
            catch(Exception ex)
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

                    string imageName = brand + "_" + color;

                    string workingDirectory = Environment.CurrentDirectory;
                    workingDirectory = workingDirectory.Substring(0, workingDirectory.Length - 9);

                    string path = workingDirectory + "resources\\cars\\" + imageName + ".jpg";
                    string secondPath = workingDirectory + "resources\\cars\\noCarFound.jpg";

                    try
                    {
                        this.vManager.GetPictureBox().Image = System.Drawing.Image.FromFile(path);
                    }
                    catch
                    {
                        this.vManager.GetPictureBox().Image = System.Drawing.Image.FromFile(secondPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
