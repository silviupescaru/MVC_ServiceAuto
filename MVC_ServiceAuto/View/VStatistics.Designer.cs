using System.Drawing;
using System.Windows.Forms;

namespace MVC_ServiceAuto.View
{
    partial class VStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VStatistics));
            this.buttonBack = new System.Windows.Forms.Button();
            this.chartCarStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxCriterion = new System.Windows.Forms.ComboBox();
            this.labelSelectCriterion = new System.Windows.Forms.Label();
            this.labelChangeLanguage = new System.Windows.Forms.Label();
            this.comboBoxChangeLanguage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartCarStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Montserrat", 9F);
            this.buttonBack.Location = new System.Drawing.Point(527, 622);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 29);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back to Manager";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // chartCarStatistics
            // 
            this.chartCarStatistics.BackColor = System.Drawing.Color.Transparent;
            this.chartCarStatistics.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCarStatistics.ChartAreas.Add(chartArea1);
            this.chartCarStatistics.Cursor = System.Windows.Forms.Cursors.No;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartCarStatistics.Legends.Add(legend1);
            this.chartCarStatistics.Location = new System.Drawing.Point(33, 29);
            this.chartCarStatistics.Name = "chartCarStatistics";
            this.chartCarStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCarStatistics.Series.Add(series1);
            this.chartCarStatistics.Size = new System.Drawing.Size(837, 533);
            this.chartCarStatistics.TabIndex = 3;
            this.chartCarStatistics.Text = "chartCarStatistics";
            // 
            // comboBoxCriterion
            // 
            this.comboBoxCriterion.FormattingEnabled = true;
            this.comboBoxCriterion.Items.AddRange(new object[] {
            "",
            "Brand",
            "Fuel"});
            this.comboBoxCriterion.Location = new System.Drawing.Point(399, 610);
            this.comboBoxCriterion.Name = "comboBoxCriterion";
            this.comboBoxCriterion.Size = new System.Drawing.Size(119, 21);
            this.comboBoxCriterion.TabIndex = 4;
            // 
            // labelSelectCriterion
            // 
            this.labelSelectCriterion.AutoSize = true;
            this.labelSelectCriterion.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectCriterion.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelSelectCriterion.ForeColor = System.Drawing.Color.White;
            this.labelSelectCriterion.Location = new System.Drawing.Point(230, 607);
            this.labelSelectCriterion.Name = "labelSelectCriterion";
            this.labelSelectCriterion.Size = new System.Drawing.Size(139, 22);
            this.labelSelectCriterion.TabIndex = 5;
            this.labelSelectCriterion.Text = "Select Criterion";
            // 
            // labelChangeLanguage
            // 
            this.labelChangeLanguage.AutoSize = true;
            this.labelChangeLanguage.BackColor = System.Drawing.Color.Transparent;
            this.labelChangeLanguage.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelChangeLanguage.ForeColor = System.Drawing.Color.White;
            this.labelChangeLanguage.Location = new System.Drawing.Point(230, 641);
            this.labelChangeLanguage.Name = "labelChangeLanguage";
            this.labelChangeLanguage.Size = new System.Drawing.Size(163, 22);
            this.labelChangeLanguage.TabIndex = 7;
            this.labelChangeLanguage.Text = "Change Language";
            // 
            // comboBoxChangeLanguage
            // 
            this.comboBoxChangeLanguage.FormattingEnabled = true;
            this.comboBoxChangeLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "Russian"});
            this.comboBoxChangeLanguage.Location = new System.Drawing.Point(399, 644);
            this.comboBoxChangeLanguage.Name = "comboBoxChangeLanguage";
            this.comboBoxChangeLanguage.Size = new System.Drawing.Size(119, 21);
            this.comboBoxChangeLanguage.TabIndex = 6;
            // 
            // VStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 699);
            this.Controls.Add(this.labelChangeLanguage);
            this.Controls.Add(this.comboBoxChangeLanguage);
            this.Controls.Add(this.labelSelectCriterion);
            this.Controls.Add(this.comboBoxCriterion);
            this.Controls.Add(this.chartCarStatistics);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartCarStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCarStatistics;
        private ComboBox comboBoxCriterion;
        private Label labelSelectCriterion;
        private Label labelChangeLanguage;
        private ComboBox comboBoxChangeLanguage;
    }
}