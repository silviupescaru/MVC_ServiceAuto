namespace MVC_ServiceAuto.View
{
    partial class VManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VManager));
            buttonSaveCSV = new Button();
            buttonSaveJSON = new Button();
            buttonSaveXML = new Button();
            buttonSaveDOC = new Button();
            buttonLogout = new Button();
            labelLoggedIn = new Label();
            dataGridViewCarTable = new DataGridView();
            buttonSearch = new Button();
            buttonViewAll = new Button();
            textBoxSearchBar = new TextBox();
            comboBoxFilterBy = new ComboBox();
            comboBoxCarFilter = new ComboBox();
            labelFilterBy = new Label();
            labelSearchBar = new Label();
            labelCarOrderBy = new Label();
            textBoxBrand = new TextBox();
            textBoxColor = new TextBox();
            textBoxOwner = new TextBox();
            comboBoxFuel = new ComboBox();
            numericUpDownCarID = new NumericUpDown();
            labelFuel = new Label();
            labelColor = new Label();
            labelBrand = new Label();
            labelOwner = new Label();
            labelCarID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarID).BeginInit();
            SuspendLayout();
            // 
            // buttonSaveCSV
            // 
            buttonSaveCSV.Font = new Font("Montserrat", 7.5F);
            buttonSaveCSV.Location = new Point(320, 182);
            buttonSaveCSV.Name = "buttonSaveCSV";
            buttonSaveCSV.Size = new Size(75, 23);
            buttonSaveCSV.TabIndex = 56;
            buttonSaveCSV.Text = "SAVE CSV";
            buttonSaveCSV.UseVisualStyleBackColor = true;
            // 
            // buttonSaveJSON
            // 
            buttonSaveJSON.Font = new Font("Montserrat", 7.5F);
            buttonSaveJSON.Location = new Point(403, 182);
            buttonSaveJSON.Name = "buttonSaveJSON";
            buttonSaveJSON.Size = new Size(75, 23);
            buttonSaveJSON.TabIndex = 55;
            buttonSaveJSON.Text = "SAVE JSON";
            buttonSaveJSON.UseVisualStyleBackColor = true;
            // 
            // buttonSaveXML
            // 
            buttonSaveXML.Font = new Font("Montserrat", 7.5F);
            buttonSaveXML.Location = new Point(320, 211);
            buttonSaveXML.Name = "buttonSaveXML";
            buttonSaveXML.Size = new Size(75, 23);
            buttonSaveXML.TabIndex = 54;
            buttonSaveXML.Text = "SAVE XML";
            buttonSaveXML.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDOC
            // 
            buttonSaveDOC.Font = new Font("Montserrat", 7.5F);
            buttonSaveDOC.Location = new Point(402, 211);
            buttonSaveDOC.Name = "buttonSaveDOC";
            buttonSaveDOC.Size = new Size(75, 23);
            buttonSaveDOC.TabIndex = 53;
            buttonSaveDOC.Text = "SAVE DOC";
            buttonSaveDOC.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Montserrat", 7.5F);
            buttonLogout.Location = new Point(113, 603);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 52;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // labelLoggedIn
            // 
            labelLoggedIn.AutoSize = true;
            labelLoggedIn.BackColor = Color.Transparent;
            labelLoggedIn.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelLoggedIn.ForeColor = Color.White;
            labelLoggedIn.Location = new Point(63, 576);
            labelLoggedIn.Name = "labelLoggedIn";
            labelLoggedIn.Size = new Size(173, 20);
            labelLoggedIn.TabIndex = 51;
            labelLoggedIn.Text = "Logged in as Manager";
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
            dataGridViewCarTable.Location = new Point(52, 276);
            dataGridViewCarTable.Name = "dataGridViewCarTable";
            dataGridViewCarTable.Size = new Size(695, 275);
            dataGridViewCarTable.TabIndex = 50;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Montserrat", 7.5F);
            buttonSearch.Location = new Point(664, 211);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 49;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonViewAll
            // 
            buttonViewAll.Font = new Font("Montserrat", 7.5F);
            buttonViewAll.Location = new Point(664, 162);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(75, 23);
            buttonViewAll.TabIndex = 48;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchBar
            // 
            textBoxSearchBar.Font = new Font("Montserrat", 8.999999F);
            textBoxSearchBar.Location = new Point(496, 211);
            textBoxSearchBar.Name = "textBoxSearchBar";
            textBoxSearchBar.Size = new Size(151, 22);
            textBoxSearchBar.TabIndex = 47;
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.Font = new Font("Montserrat", 8.999999F);
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "", "Owner", "Brand", "Color", "Fuel" });
            comboBoxFilterBy.Location = new Point(496, 161);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(151, 24);
            comboBoxFilterBy.TabIndex = 46;
            comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // comboBoxCarFilter
            // 
            comboBoxCarFilter.Font = new Font("Montserrat", 8.999999F);
            comboBoxCarFilter.FormattingEnabled = true;
            comboBoxCarFilter.Items.AddRange(new object[] { "", "None", "Brand and Fuel" });
            comboBoxCarFilter.Location = new Point(496, 108);
            comboBoxCarFilter.Name = "comboBoxCarFilter";
            comboBoxCarFilter.Size = new Size(151, 24);
            comboBoxCarFilter.TabIndex = 45;
            comboBoxCarFilter.SelectedIndexChanged += comboBoxCarFilter_SelectedIndexChanged;
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilterBy.ForeColor = Color.White;
            labelFilterBy.Location = new Point(492, 136);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(79, 22);
            labelFilterBy.TabIndex = 44;
            labelFilterBy.Text = "Filter By";
            // 
            // labelSearchBar
            // 
            labelSearchBar.AutoSize = true;
            labelSearchBar.BackColor = Color.Transparent;
            labelSearchBar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchBar.ForeColor = Color.White;
            labelSearchBar.Location = new Point(492, 186);
            labelSearchBar.Name = "labelSearchBar";
            labelSearchBar.Size = new Size(99, 22);
            labelSearchBar.TabIndex = 43;
            labelSearchBar.Text = "Search bar";
            // 
            // labelCarOrderBy
            // 
            labelCarOrderBy.AutoSize = true;
            labelCarOrderBy.BackColor = Color.Transparent;
            labelCarOrderBy.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarOrderBy.ForeColor = Color.White;
            labelCarOrderBy.Location = new Point(492, 83);
            labelCarOrderBy.Name = "labelCarOrderBy";
            labelCarOrderBy.Size = new Size(116, 22);
            labelCarOrderBy.TabIndex = 42;
            labelCarOrderBy.Text = "Car Order By";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Montserrat", 8.999999F);
            textBoxBrand.Location = new Point(139, 148);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(161, 22);
            textBoxBrand.TabIndex = 38;
            // 
            // textBoxColor
            // 
            textBoxColor.Font = new Font("Montserrat", 8.999999F);
            textBoxColor.Location = new Point(139, 178);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(161, 22);
            textBoxColor.TabIndex = 37;
            // 
            // textBoxOwner
            // 
            textBoxOwner.Font = new Font("Montserrat", 8.999999F);
            textBoxOwner.Location = new Point(139, 118);
            textBoxOwner.Name = "textBoxOwner";
            textBoxOwner.Size = new Size(161, 22);
            textBoxOwner.TabIndex = 36;
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.Font = new Font("Montserrat", 8.999999F);
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Items.AddRange(new object[] { "", "Diesel", "Gasoline", "LPG", "Hybrid" });
            comboBoxFuel.Location = new Point(139, 208);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(161, 24);
            comboBoxFuel.TabIndex = 35;
            // 
            // numericUpDownCarID
            // 
            numericUpDownCarID.Font = new Font("Montserrat", 8.999999F);
            numericUpDownCarID.Location = new Point(139, 87);
            numericUpDownCarID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownCarID.Name = "numericUpDownCarID";
            numericUpDownCarID.Size = new Size(161, 22);
            numericUpDownCarID.TabIndex = 34;
            // 
            // labelFuel
            // 
            labelFuel.AutoSize = true;
            labelFuel.BackColor = Color.Transparent;
            labelFuel.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelFuel.ForeColor = Color.White;
            labelFuel.Location = new Point(58, 208);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(41, 20);
            labelFuel.TabIndex = 33;
            labelFuel.Text = "Fuel";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = Color.Transparent;
            labelColor.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelColor.ForeColor = Color.White;
            labelColor.Location = new Point(58, 178);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(47, 20);
            labelColor.TabIndex = 32;
            labelColor.Text = "Color";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.BackColor = Color.Transparent;
            labelBrand.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelBrand.ForeColor = Color.White;
            labelBrand.Location = new Point(58, 148);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(54, 20);
            labelBrand.TabIndex = 31;
            labelBrand.Text = "Brand";
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.BackColor = Color.Transparent;
            labelOwner.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelOwner.ForeColor = Color.White;
            labelOwner.Location = new Point(58, 117);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(59, 20);
            labelOwner.TabIndex = 30;
            labelOwner.Text = "Owner";
            // 
            // labelCarID
            // 
            labelCarID.AutoSize = true;
            labelCarID.BackColor = Color.Transparent;
            labelCarID.Font = new Font("Montserrat SemiBold", 9.999999F, FontStyle.Bold);
            labelCarID.ForeColor = Color.White;
            labelCarID.Location = new Point(58, 87);
            labelCarID.Name = "labelCarID";
            labelCarID.Size = new Size(54, 20);
            labelCarID.TabIndex = 29;
            labelCarID.Text = "Car ID";
            // 
            // VManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.managerBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 660);
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
            Name = "VManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCarID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveCSV;
        private Button buttonSaveJSON;
        private Button buttonSaveXML;
        private Button buttonSaveDOC;
        private Button buttonLogout;
        private Label labelLoggedIn;
        private DataGridView dataGridViewCarTable;
        private Button buttonSearch;
        private Button buttonViewAll;
        private TextBox textBoxSearchBar;
        private ComboBox comboBoxFilterBy;
        private ComboBox comboBoxCarFilter;
        private Label labelFilterBy;
        private Label labelSearchBar;
        private Label labelCarOrderBy;
        private TextBox textBoxBrand;
        private TextBox textBoxColor;
        private TextBox textBoxOwner;
        private ComboBox comboBoxFuel;
        private NumericUpDown numericUpDownCarID;
        private Label labelFuel;
        private Label labelColor;
        private Label labelBrand;
        private Label labelOwner;
        private Label labelCarID;
    }
}