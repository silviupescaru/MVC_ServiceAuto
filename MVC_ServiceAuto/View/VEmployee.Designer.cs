namespace MVC_ServiceAuto.View
{
    partial class VEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VEmployee));
            labelCarID = new Label();
            labelOwner = new Label();
            labelColor = new Label();
            labelBrand = new Label();
            labelFuel = new Label();
            numericUpDownCarID = new NumericUpDown();
            comboBoxFuel = new ComboBox();
            textBoxOwner = new TextBox();
            textBoxColor = new TextBox();
            textBoxBrand = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            labelCarOrderBy = new Label();
            labelSearchBar = new Label();
            labelFilterBy = new Label();
            comboBoxCarFilter = new ComboBox();
            comboBoxFilterBy = new ComboBox();
            textBoxSearchBar = new TextBox();
            buttonSearch = new Button();
            buttonViewAll = new Button();
            dataGridViewCarTable = new DataGridView();
            labelLoggedIn = new Label();
            buttonLogout = new Button();
            buttonSaveXML = new Button();
            buttonSaveDOC = new Button();
            buttonSaveCSV = new Button();
            buttonSaveJSON = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarTable).BeginInit();
            SuspendLayout();
            // 
            // labelCarID
            // 
            labelCarID.AutoSize = true;
            labelCarID.BackColor = Color.Transparent;
            labelCarID.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelCarID.ForeColor = Color.White;
            labelCarID.Location = new Point(63, 77);
            labelCarID.Name = "labelCarID";
            labelCarID.Size = new Size(54, 20);
            labelCarID.TabIndex = 0;
            labelCarID.Text = "Car ID";
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.BackColor = Color.Transparent;
            labelOwner.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelOwner.ForeColor = Color.White;
            labelOwner.Location = new Point(63, 107);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(59, 20);
            labelOwner.TabIndex = 1;
            labelOwner.Text = "Owner";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = Color.Transparent;
            labelColor.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelColor.ForeColor = Color.White;
            labelColor.Location = new Point(63, 168);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(47, 20);
            labelColor.TabIndex = 3;
            labelColor.Text = "Color";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.BackColor = Color.Transparent;
            labelBrand.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelBrand.ForeColor = Color.White;
            labelBrand.Location = new Point(63, 138);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(54, 20);
            labelBrand.TabIndex = 2;
            labelBrand.Text = "Brand";
            // 
            // labelFuel
            // 
            labelFuel.AutoSize = true;
            labelFuel.BackColor = Color.Transparent;
            labelFuel.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelFuel.ForeColor = Color.White;
            labelFuel.Location = new Point(63, 198);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(41, 20);
            labelFuel.TabIndex = 4;
            labelFuel.Text = "Fuel";
            // 
            // numericUpDownCarID
            // 
            numericUpDownCarID.Font = new Font("Montserrat", 8.999999F);
            numericUpDownCarID.Location = new Point(144, 77);
            numericUpDownCarID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownCarID.Name = "numericUpDownCarID";
            numericUpDownCarID.Size = new Size(161, 22);
            numericUpDownCarID.TabIndex = 5;
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.Font = new Font("Montserrat", 8.999999F);
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Items.AddRange(new object[] { "", "Diesel", "Gasoline", "LPG", "Hybrid" });
            comboBoxFuel.Location = new Point(144, 198);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(161, 24);
            comboBoxFuel.TabIndex = 6;
            // 
            // textBoxOwner
            // 
            textBoxOwner.Font = new Font("Montserrat", 8.999999F);
            textBoxOwner.Location = new Point(144, 108);
            textBoxOwner.Name = "textBoxOwner";
            textBoxOwner.Size = new Size(161, 22);
            textBoxOwner.TabIndex = 7;
            // 
            // textBoxColor
            // 
            textBoxColor.Font = new Font("Montserrat", 8.999999F);
            textBoxColor.Location = new Point(144, 168);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(161, 22);
            textBoxColor.TabIndex = 8;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Montserrat", 8.999999F);
            textBoxBrand.Location = new Point(144, 138);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(161, 22);
            textBoxBrand.TabIndex = 9;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Montserrat", 7.5F);
            buttonAdd.Location = new Point(63, 229);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Montserrat", 7.5F);
            buttonDelete.Location = new Point(230, 229);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Montserrat", 7.5F);
            buttonUpdate.Location = new Point(144, 229);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // labelCarOrderBy
            // 
            labelCarOrderBy.AutoSize = true;
            labelCarOrderBy.BackColor = Color.Transparent;
            labelCarOrderBy.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarOrderBy.ForeColor = Color.White;
            labelCarOrderBy.Location = new Point(354, 81);
            labelCarOrderBy.Name = "labelCarOrderBy";
            labelCarOrderBy.Size = new Size(116, 22);
            labelCarOrderBy.TabIndex = 13;
            labelCarOrderBy.Text = "Car Order By";
            // 
            // labelSearchBar
            // 
            labelSearchBar.AutoSize = true;
            labelSearchBar.BackColor = Color.Transparent;
            labelSearchBar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchBar.ForeColor = Color.White;
            labelSearchBar.Location = new Point(354, 184);
            labelSearchBar.Name = "labelSearchBar";
            labelSearchBar.Size = new Size(99, 22);
            labelSearchBar.TabIndex = 14;
            labelSearchBar.Text = "Search bar";
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilterBy.ForeColor = Color.White;
            labelFilterBy.Location = new Point(354, 134);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(79, 22);
            labelFilterBy.TabIndex = 15;
            labelFilterBy.Text = "Filter By";
            // 
            // comboBoxCarFilter
            // 
            comboBoxCarFilter.Font = new Font("Montserrat", 8.999999F);
            comboBoxCarFilter.FormattingEnabled = true;
            comboBoxCarFilter.Items.AddRange(new object[] { "", "None", "Brand and Fuel" });
            comboBoxCarFilter.Location = new Point(358, 106);
            comboBoxCarFilter.Name = "comboBoxCarFilter";
            comboBoxCarFilter.Size = new Size(151, 24);
            comboBoxCarFilter.TabIndex = 17;
            //comboBoxCarFilter.SelectedIndexChanged += comboBoxCarFilter_SelectedIndexChanged;
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.Font = new Font("Montserrat", 8.999999F);
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "", "Owner", "Brand", "Color", "Fuel" });
            comboBoxFilterBy.Location = new Point(358, 159);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(151, 24);
            comboBoxFilterBy.TabIndex = 18;
            //comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // textBoxSearchBar
            // 
            textBoxSearchBar.Font = new Font("Montserrat", 8.999999F);
            textBoxSearchBar.Location = new Point(358, 209);
            textBoxSearchBar.Name = "textBoxSearchBar";
            textBoxSearchBar.Size = new Size(151, 22);
            textBoxSearchBar.TabIndex = 19;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Montserrat", 7.5F);
            buttonSearch.Location = new Point(526, 209);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 21;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonViewAll
            // 
            buttonViewAll.Font = new Font("Montserrat", 7.5F);
            buttonViewAll.Location = new Point(612, 209);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(75, 23);
            buttonViewAll.TabIndex = 20;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCarTable
            // 
            dataGridViewCarTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCarTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCarTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCarTable.Location = new Point(67, 301);
            dataGridViewCarTable.Name = "dataGridViewCarTable";
            dataGridViewCarTable.Size = new Size(690, 317);
            dataGridViewCarTable.TabIndex = 22;
            // 
            // labelLoggedIn
            // 
            labelLoggedIn.AutoSize = true;
            labelLoggedIn.BackColor = Color.Transparent;
            labelLoggedIn.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelLoggedIn.ForeColor = Color.White;
            labelLoggedIn.Location = new Point(63, 655);
            labelLoggedIn.Name = "labelLoggedIn";
            labelLoggedIn.Size = new Size(180, 20);
            labelLoggedIn.TabIndex = 23;
            labelLoggedIn.Text = "Logged in as Employee";
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Montserrat", 7.5F);
            buttonLogout.Location = new Point(116, 683);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 24;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonSaveXML
            // 
            buttonSaveXML.Font = new Font("Montserrat", 7.5F);
            buttonSaveXML.Location = new Point(526, 159);
            buttonSaveXML.Name = "buttonSaveXML";
            buttonSaveXML.Size = new Size(75, 23);
            buttonSaveXML.TabIndex = 26;
            buttonSaveXML.Text = "SAVE XML";
            buttonSaveXML.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDOC
            // 
            buttonSaveDOC.Font = new Font("Montserrat", 7.5F);
            buttonSaveDOC.Location = new Point(612, 159);
            buttonSaveDOC.Name = "buttonSaveDOC";
            buttonSaveDOC.Size = new Size(75, 23);
            buttonSaveDOC.TabIndex = 25;
            buttonSaveDOC.Text = "SAVE DOC";
            buttonSaveDOC.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCSV
            // 
            buttonSaveCSV.Font = new Font("Montserrat", 7.5F);
            buttonSaveCSV.Location = new Point(526, 107);
            buttonSaveCSV.Name = "buttonSaveCSV";
            buttonSaveCSV.Size = new Size(75, 23);
            buttonSaveCSV.TabIndex = 28;
            buttonSaveCSV.Text = "SAVE CSV";
            buttonSaveCSV.UseVisualStyleBackColor = true;
            // 
            // buttonSaveJSON
            // 
            buttonSaveJSON.Font = new Font("Montserrat", 7.5F);
            buttonSaveJSON.Location = new Point(612, 107);
            buttonSaveJSON.Name = "buttonSaveJSON";
            buttonSaveJSON.Size = new Size(75, 23);
            buttonSaveJSON.TabIndex = 27;
            buttonSaveJSON.Text = "SAVE JSON";
            buttonSaveJSON.UseVisualStyleBackColor = true;
            // 
            // VEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.employeeBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 739);
            Controls.Add(buttonSaveCSV);
            Controls.Add(buttonSaveJSON);
            Controls.Add(buttonSaveXML);
            Controls.Add(buttonSaveDOC);
            Controls.Add(buttonLogout);
            Controls.Add(labelLoggedIn);
            Controls.Add(dataGridViewCarTable);
            Controls.Add(buttonSearch);
            Controls.Add(buttonViewAll);
            Controls.Add(textBoxSearchBar);
            Controls.Add(comboBoxFilterBy);
            Controls.Add(comboBoxCarFilter);
            Controls.Add(labelFilterBy);
            Controls.Add(labelSearchBar);
            Controls.Add(labelCarOrderBy);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxBrand);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxOwner);
            Controls.Add(comboBoxFuel);
            Controls.Add(numericUpDownCarID);
            Controls.Add(labelFuel);
            Controls.Add(labelColor);
            Controls.Add(labelBrand);
            Controls.Add(labelOwner);
            Controls.Add(labelCarID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeGUI";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarID;
        private Label labelOwner;
        private Label labelColor;
        private Label labelBrand;
        private Label labelFuel;
        private NumericUpDown numericUpDownCarID;
        private ComboBox comboBoxFuel;
        private TextBox textBoxOwner;
        private TextBox textBoxColor;
        private TextBox textBoxBrand;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label labelCarOrderBy;
        private Label labelSearchBar;
        private Label labelFilterBy;
        private ComboBox comboBoxCarFilter;
        private ComboBox comboBoxFilterBy;
        private TextBox textBoxSearchBar;
        private Button buttonSearch;
        private Button buttonViewAll;
        private DataGridView dataGridViewCarTable;
        private Label labelLoggedIn;
        private Button buttonLogout;
        private Button buttonSaveXML;
        private Button buttonSaveDOC;
        private Button buttonSaveCSV;
        private Button buttonSaveJSON;
    }
}